using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Orm
{
    public class cls_Categorias
    {
        #region "Propiedades"

        private Guid CatIntIdValue;

        public Guid CatIntId
        {
            get { return CatIntIdValue; }
            set { CatIntIdValue = value; }
        }

        private string CatNombreValue;

        public string CatNombre
        {
            get { return CatNombreValue; }
            set { CatNombreValue = value; }
        }

        private string CatCodigoValue;

        public string CatCodigo
        {
            get { return CatCodigoValue; }
            set { CatCodigoValue = value; }
        }

        private bool CatStatusValue;

        public bool CatStatus
        {
            get { return CatStatusValue; }
            set { CatStatusValue = value; }
        }

        #endregion


        #region "Metodos"
        public void Create(cls_Categorias objCat)
        {
            Conexion.GDatos.Ejecutar("SP_IM_Categoria",objCat.CatIntId, objCat.CatNombre, objCat.CatCodigo, objCat.CatStatus);
        }

        #endregion
    }
}
