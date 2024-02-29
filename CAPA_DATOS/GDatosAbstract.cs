using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CAPA_DATOS
{
    public abstract class GDatosAbstract
    {
        protected IDbConnection SQLMCon;
        protected abstract IDbConnection CreaConexion(string cadena);
        protected abstract IDbCommand ComandoSql(string comandosql, IDbConnection connection);
        protected abstract IDataAdapter CrearDataAdapterSql(string comandosql, IDbConnection connection);

        protected abstract IDataAdapter CrearDataAdapterSql(IDbCommand comandoSql);

        //verifica los Campos de las tablas
        private static Object GetItem(DataRow dr, Object Inst)
        {
            Type temp = Inst.GetType();
            var obj = Activator.CreateInstance(Inst.GetType());
            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else continue;
                }
            }

            return obj;
        }

        //Convertir datos de una tabla
        private static List<Object> ConvertDataTable(DataTable dt, Object Inst)
        {
            List<Object> data = new List<Object>();
            foreach (DataRow row in dt.Rows)
            {
                var item = GetItem(row, Inst);
                data.Add(item);
            }

            return data;
        }

        //mandar select a una tabla o vista
        public object TakeList(string TableName, Object Inst, string? condicion)
        {
            try
            {
                string CondicionString = "";
                if (condicion != null)
                {
                    CondicionString = "WHERE" + condicion;
                }

                string queryString = "SELECT * FROM" + TableName + CondicionString;
                DataTable Table = TrerDatosSQL(queryString);
                List<Object> ListD = ConvertDataTable(Table, Inst);
                return ListD;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //insertar datos a las tablas
        public Object InsertObject(string TableName, Object Inst)
        {
            try
            {
                string Values = "";
                Type _type = Inst.GetType();
                PropertyInfo[] lst = _type.GetProperties();
                foreach (PropertyInfo oProperty in lst)
                {
                    string AtributeName = oProperty.Name;
                    var AtributeValue = oProperty.GetValue(Inst);
                    Values = Values + "'" + AtributeValue.ToString() + "',";
                }

                Values = Values.TrimEnd(',');
                string strQuery = TableName + " " + Values;
                return ExecuteSqlQuery(strQuery);
            }
            catch (Exception ex)
            {
                return new { error = ex.Message };
            }
        }

        //enlistar datos de las tablas
        public DataTable TrerDatosSQL(string queryString)
        {

            DataSet ObjDS = new DataSet();
            CrearDataAdapterSql(queryString, SQLMCon).Fill(ObjDS);
            return ObjDS.Tables["Table"];

        }

        public DataTable TrerDatosSQL(IDbCommand Command)
        {

            DataSet ObjDS = new DataSet();
            CrearDataAdapterSql(Command).Fill(ObjDS);
            return ObjDS.Tables[0].Copy();

        }

        //ejecutar vistas, inserciones, procedimientos almacenados, funciones etc
        public bool ExecuteSqlQuery(string strQuery)
        {
            try
            {
                SQLMCon.Open();
                var com = ComandoSql(strQuery, SQLMCon);
                com.ExecuteNonQuery();
                SQLMCon.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader TakeListWithProcedure(string ProcedureName, Object Inst, List<Object> Params,SqlConnection connection)
        {
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = $"{ProcedureName}", 
                    Connection =
                        connection,
                    CommandType = CommandType.StoredProcedure
                };
                    
                SqlParameter param1 = new SqlParameter
                {
                    ParameterName = "@fecha1", 
                    SqlDbType = SqlDbType.DateTime,
                    Value = Params.FirstOrDefault(), 
                    Direction = ParameterDirection.Input 
                };
                    
                SqlParameter param2 = new SqlParameter
                {
                    ParameterName = "@fecha2", 
                    SqlDbType = SqlDbType.DateTime,
                    Value = Params.LastOrDefault(),
                    Direction = ParameterDirection.Input
                };
                    
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                
                SqlDataReader sdr = cmd.ExecuteReader();
                    
                
                return sdr;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
                return null;
            } 
        }

        protected abstract List<T> ConvertDataTable<T>(DataTable table, object inst);
    }
}


        

    
   

