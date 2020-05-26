using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;

static class Utilitarios
{
    public static void CulturaInfo()
    {
        // Colocar Cultura Estandar para Costa Rica
        // esto me permite no tener problemas con (.) de los decimales
        CultureInfo Micultura = new CultureInfo("es-CR", false);
        Micultura.NumberFormat.CurrencySymbol = "¢";
        Micultura.NumberFormat.CurrencyDecimalDigits = 2;
        Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
        Micultura.NumberFormat.CurrencyGroupSeparator = ",";
        int[] grupo = new int[] { 3, 3, 3 };
        Micultura.NumberFormat.CurrencyGroupSizes = grupo;
        Micultura.NumberFormat.NumberDecimalDigits = 2;
        Micultura.NumberFormat.NumberGroupSeparator = ",";
        Micultura.NumberFormat.NumberDecimalSeparator = ".";
        Micultura.NumberFormat.NumberGroupSizes = grupo;
        //Micultura.DateTimeFormat.
        Thread.CurrentThread.CurrentCulture = Micultura;

    }
    public static string CreateSQLExceptionsErrorDetails(SqlException pExcepcion)
    {
        StringBuilder msg = new StringBuilder();
        msg.AppendFormat("Message         {0}\n", pExcepcion.Message);
        msg.AppendFormat("Source          {0}\n", pExcepcion.Source);
        msg.AppendFormat("InnerException  {0}\n", pExcepcion.InnerException);
        msg.AppendFormat("TargetSite      {0}\n", pExcepcion.TargetSite);
        msg.AppendFormat("Linea           {0}\n", pExcepcion.LineNumber);
        msg.AppendFormat("Procedure       {0}\n", pExcepcion.Procedure ?? "N/A");
        msg.AppendFormat("Numero de Error {0}\n", pExcepcion.Number);
        msg.AppendFormat(@"Listado de errores para investigar mas https://technet.microsoft.com/en-us/library/cc645603(v=sql.105).aspx");
        msg.AppendFormat("\n");
        msg.AppendFormat("Lista de Errores \n");
        for (int i = 0; i < pExcepcion.Errors.Count; i++)
        {
            msg.AppendFormat("\t{0} - ItemError: {1}\n", i + 1, pExcepcion.Errors[i].ToString());
        }
        msg.AppendFormat("\n");
        msg.AppendFormat("StackTrace     {0}\n", pExcepcion.StackTrace);
        return msg.ToString();
    }


    public static string CreateGenericErrorExceptionDetail(Exception pExcepcion)
    {
        StringBuilder msg = new StringBuilder();
        msg.AppendFormat("Message        {0}\n", pExcepcion.Message);
        msg.AppendFormat("Source         {0}\n", pExcepcion.Source);
        msg.AppendFormat("InnerException {0}\n", pExcepcion.InnerException);
        msg.AppendFormat("StackTrace     {0}\n", pExcepcion.StackTrace);
        msg.AppendFormat("TargetSite     {0}\n", pExcepcion.TargetSite);

        return msg.ToString();
    }

    public static void EnviarCorreo(string pSubject,string pBody,string pFrom,string pEmailDestino,string pUsuario,string pContrasena)
    {

        MailMessage mensaje = new MailMessage();
        mensaje.IsBodyHtml = true;
        mensaje.Subject = pSubject;
        mensaje.Body = pBody;
        mensaje.From = new MailAddress(pFrom);
        mensaje.To.Add(pEmailDestino);
        SmtpClient smtp = new SmtpClient("smtp.gmail.com"); // NO TOCAR
        smtp.Port = 587;  //  NO TOCAR
        smtp.Credentials = new NetworkCredential(pUsuario, pContrasena); // Usuario y  Contrasena de la cuenta de su correo.
        smtp.EnableSsl = true; // NO TOCAR

        Attachment attachment = new Attachment(@"C:\temp\proyecto.xml"); 
        Attachment attachmentqr = new Attachment(@"C:\temp\reporteFactura.pdf");
        mensaje.Attachments.Add(attachment);
        mensaje.Attachments.Add(attachmentqr);

        smtp.Send(mensaje);
    }

    public static void Hablar(string pMensaje)
    {
        SpeechSynthesizer voice = new SpeechSynthesizer();
        voice.Volume = 90;
        voice.Rate = -3;
        voice.SpeakAsync(pMensaje);
    }


}

