using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIOS
{
    public class CatBodega
    {
     private string TableName = "CRUD_CAT_BODEGA";
     public string Parametro { get; set; }   
    public int IdBodega { get; set; }

    public string DescipcionBodega { get; set; }
    public string EstadoBodega { get; set; }

    //
    public Object SaveBodega(CatBodega Inst)
    {
        try
        {
                SqlADOCConexion.IniciarConexion();
                return SqlADOCConexion.SQLM.InsertObject(TableName, Inst);
        }
        catch
        {
            throw;
        }
    }

    //
    public Object GetBodega(CatBodega Inst)
    {
        try
        {
                SqlADOCConexion.IniciarConexion();
                return SqlADOCConexion.SQLM.TakeList(TableName, Inst, null);
        }
        catch
        {
            throw;
        }
    }
}
}
