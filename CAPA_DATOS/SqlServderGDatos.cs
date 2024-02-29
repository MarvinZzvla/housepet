using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CAPA_DATOS
{
    public class SqlServderGDatos: GDatosAbstract
    {

        //contruccion para crear la conexion
        protected override IDbConnection CreaConexion(string ConexionString)
        {
            return new SqlConnection(ConexionString);
        }

        //contructor para la conexion
        public SqlServderGDatos(string ConexionString)
        {
            SQLMCon = CreaConexion(ConexionString);
        }

        //ejecuta comando en sql
        protected override IDbCommand ComandoSql(string comandosql, IDbConnection Conexion)
        {
            var com = new SqlCommand(comandosql, (SqlConnection)Conexion);
            return com;
        }

        //Listqa de datos de la tabla
        protected override IDataAdapter CrearDataAdapterSql(string comandosql, IDbConnection Conexion)
        {
            var da = new SqlDataAdapter((SqlCommand)ComandoSql(comandosql, Conexion));
            return da;
        }

        protected override IDataAdapter CrearDataAdapterSql(IDbCommand comandoSql)
        {
            var da = new SqlDataAdapter((SqlCommand)comandoSql);
            return da;
        }

		protected override List<T> ConvertDataTable<T>(DataTable table, object inst)
		{
			throw new NotImplementedException();
		}
	}
}
