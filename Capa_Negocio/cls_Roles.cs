using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class cls_Roles
    {
        #region "propiedades"

        public Guid RolIntId { get; set; }

        public string RolName { get; set; }

        #endregion


        #region "Metodos"


        public List<cls_Roles> ListarRoles()
        {
            Conexion.IniciarSesion(@"TXNICARAGUA\SQLEXPRESS", "DB_Farmacia", "sa", "josvany");

            var objRol = new List<cls_Roles>();

            var dt = Conexion.GDatos.TraerDataTable("SP_Listar", "CAT_ROLE");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objRol.Add(new cls_Roles
                {
                    RolIntId = (Guid)dt.Rows[i][0],
                    RolName = dt.Rows[i][1].ToString()
                });
            }
       
            return objRol;
        }

        #endregion
    }
}
