using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Mensajeria.Winform.DAL;
using UTN.Mensajeria.Winform.Entidades;
using UTN.Mensajeria.Winform.Interfaces;

namespace UTN.Mensajeria.Winform.BLL
{
    /// <summary>
    /// Clase de acceso a datos de PrecioEnvio
    /// </summary>
    public class BLLPrecioEnvio : IBLLPrecioEnvio
    {
        #region Actualizar PrecioEnvio
        /// <summary>
        /// Método que actualiza el precio en la base de datos
        /// </summary>
        /// <param name="oEnvio">Objeto que modificará en la base de datos</param>
        /// <returns>Rertorna una string con la respuesta del stored procedure</returns>
        public EnvioPaquete ActualizarPrecioEnvio(EnvioPaquete oEnvio)
        {
            IDALPrecioEnvio _DALPrecioEnvio = new DALPrecioEnvio();
            List<EnvioPaquete> lista = new List<EnvioPaquete>();
            int error = 0;
            int igualdad = 0;
            try
            {
                lista = this.ListaPrecios();
                foreach (EnvioPaquete item in lista)
                {
                    if (oEnvio.TipoEnvio.Equals(item.TipoEnvio))
                    {
                        igualdad++;
                    }
                    if ((oEnvio.KilometroInicial >= item.KilometroInicial && oEnvio.KilometroInicial <= item.KilometroFinal) || (oEnvio.KilometroFinal >= item.KilometroInicial && oEnvio.KilometroFinal <= item.KilometroFinal))
                    {
                        if ((oEnvio.KilometroInicial == item.KilometroInicial && oEnvio.KilometroFinal == item.KilometroFinal))
                        {
                            igualdad++;
                        }
                        else
                        {
                            error++;
                        }
                    }
                }
                if (igualdad > 0)
                {
                    return _DALPrecioEnvio.ActualizarPrecioEnvio(oEnvio);
                }
                else
                {
                    if (error > 0)
                    {
                        throw new Exception("No es posible agregar el rango deseado, revise si no está incluido en otro");
                    }
                    else
                    {
                        return _DALPrecioEnvio.ActualizarPrecioEnvio(oEnvio);
                    }
                }
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }

        }
        #endregion

        #region Borrar PrecioEnvio
        /// <summary>
        /// Método que elimina el envio de la base de datos
        /// </summary>
        /// <param name="id">Id del envio que se eliminará</param>
        /// <returns>Retorna una string con la respuesta del stored procedure</returns>
        public string BorrarEnvio(string id)
        {
            IDALPrecioEnvio _DALPrecioEnvio = new DALPrecioEnvio();
            try
            {
                return _DALPrecioEnvio.BorrarEnvio(id);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
        #endregion

        #region Instertar PrecioEnvio
        /// <summary>
        /// Método que inserta el precio en la base de datos
        /// </summary>
        /// <param name="oEnvio">Objeto que se va a agregar a la base de datos</param>
        /// <returns>Retorna una string con la respuesta del storedprocedure</returns>
        public EnvioPaquete InsertarPrecioEnvio(EnvioPaquete oEnvio)
        {
            IDALPrecioEnvio _DALPrecioEnvio = new DALPrecioEnvio();
            List<EnvioPaquete> lista = new List<EnvioPaquete>();
            int error = 0;
            try
            {
                lista = this.ListaPrecios();
                foreach (EnvioPaquete item in lista)
                {
                    if ((oEnvio.KilometroInicial >= item.KilometroInicial && oEnvio.KilometroInicial <= item.KilometroFinal) || (oEnvio.KilometroFinal >= item.KilometroInicial && oEnvio.KilometroFinal <= item.KilometroFinal))
                    {
                        error++;
                    }
                }
                if (error > 0)
                {
                    throw new Exception("No es posible agregar el rango deseado, revise si no está incluido en otro");
                }
                else
                {
                    return _DALPrecioEnvio.InsertarPrecioEnvio(oEnvio);
                }
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
        #endregion

        #region Obtener PreciosEnvio
        /// <summary>
        /// Método que muestra todos los precios de envio que hay en la base de datos
        /// </summary>
        /// <returns>Retorna una lista con los precios que hay en la base de datos</returns>
        public List<EnvioPaquete> ListaPrecios()
        {
            IDALPrecioEnvio _DALPrecioEnvio = new DALPrecioEnvio();
            try
            {
                return _DALPrecioEnvio.ListaPrecios();
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }
        #endregion

        #region Obtener PrecioEnvio por ID
        /// <summary>
        /// Método que muestra el paquete por ID 
        /// </summary>
        /// <param name="id">Id que buscará en la base de datos</param>
        /// <returns>Retorna el envio que se encuentre</returns>
        public EnvioPaquete MostrarXID(string id)
        {
            IDALPrecioEnvio _DALPrecioEnvio = new DALPrecioEnvio();
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("El parametro id esta vacío");
            }
            else
            {
                return _DALPrecioEnvio.MostrarXID(id);
            }
        }
        #endregion
    }
}
