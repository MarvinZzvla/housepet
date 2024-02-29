using Microsoft.Extensions.Configuration;
using System;

namespace CAPA_DATOS
{
    public class SqlADOCConexion
    {
        public const string UserSQLConexion = "Data Source=DESKTOP-C3RJN04\\SQLEXPRESS;Initial Catalog=HOUSEPETS;Integrated Security=True";
        public static SqlServderGDatos SQLM;

       
        static public bool IniciarConexion()
        {
            try
            {
                
                SQLM = new SqlServderGDatos(UserSQLConexion);
                return true;
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}
