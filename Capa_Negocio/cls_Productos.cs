using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Datos.Orm
{
    public class cls_Productos
    {
        #region "Propiedades"

        public Guid ProdIntId { get; set; }

        public string ProdNombre { get; set; }

        public string ProdSysName { get; set; }

        public decimal ProdPreV { get; set; }

        public decimal ProdPreC { get; set; }

        public decimal ProdCant { get; set; }

        public Guid CatIntId { get; set; }

        public Guid UseInfIntId { get; set; }


        public bool ProdStatus { get; set; }


        #endregion



        #region "Metodos"

        public List<cls_Productos> ListarProductos()
        {
            Conexion.IniciarSesion(@"TXNICARAGUA\SQLEXPRESS", "DB_Farmacia", "sa", "josvany");

            var objPro = new List<cls_Productos>();

            var dt = Conexion.GDatos.TraerDataTable("SP_Listar", "TBL_PRODUCTO");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objPro.Add(new cls_Productos
                {
                    ProdIntId = (Guid)dt.Rows[i][0],
                    ProdNombre = dt.Rows[i][1].ToString()
                });
            }

            return objPro;
        }

        #endregion
    }
}
