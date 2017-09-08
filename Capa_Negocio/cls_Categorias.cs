using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos.Orm
{
    public class cls_Categorias
    {
        #region "Propiedades"

        public Guid CatIntIdValue { get; set; }


        //public Guid CatIntId
        //{
        //    get { return CatIntIdValue; }
        //    set { CatIntIdValue = value; }
        //}

        public string CatNombreValue { get; set; }

        //public string CatNombre
        //{
        //    get { return CatNombreValue; }
        //    set { CatNombreValue = value; }
        //}

        public string CatCodigoValue { get; set; }

        //public string CatCodigo
        //{
        //    get { return CatCodigoValue; }
        //    set { CatCodigoValue = value; }
        //}

        public bool CatStatusValue { get; set; }

        //public bool CatStatus
        //{
        //    get { return CatStatusValue; }
        //    set { CatStatusValue = value; }
        //}

        #endregion


        #region "Metodos"
        public void Create(cls_Categorias objCat)
        {
            Conexion.GDatos.Ejecutar("SP_IM_Categoria",objCat.CatIntIdValue, objCat.CatNombreValue, objCat.CatCodigoValue, objCat.CatStatusValue);
        }


        public  List<cls_Categorias> Listar()
        {
            Conexion.IniciarSesion(@"TXNICARAGUA\SQLEXPRESS", "DB_Farmacia","sa","josvany");

            var objCat = new List<cls_Categorias>();

           var dt =  Conexion.GDatos.TraerDataTable("SP_Listar", "CAT_CATEGORIA");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objCat.Add(new cls_Categorias
                {
                    CatIntIdValue = (Guid)dt.Rows[i][0],
                    CatNombreValue = dt.Rows[i][1].ToString()
                });
            }
            //if (dt.Rows.Count > 0)
            //{
            //    objCat.CatIntIdValue = (Guid)dt.Rows[0][0];
            //    objCat.CatNombreValue = dt.Rows[0][1].ToString();
            //}
            Conexion.FinalizarSesion();
            return objCat;
        }

        #endregion
    }
}
