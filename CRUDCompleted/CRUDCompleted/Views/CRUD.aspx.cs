using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDCompleted.Views
{
    public partial class CRUD : System.Web.UI.Page
    {
        #region Instances
        CRUDController vCRUDController = new CRUDController();
        #endregion

        #region Propierties
        public int vCodigo;
        public DateTime vFecha;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = vCRUDController.GetInfo();
            GridView1.DataBind();
        }

        #region Methods
        public List<InfoDataModel> InfoDataModel()
        {
            vCodigo = Convert.ToInt16(txtCodigo.Text);
            vFecha = Convert.ToDateTime(txtFecha.Text);

            List<InfoDataModel> oInfoDataModel = new List<InfoDataModel>()
            {
                new InfoDataModel
                {
                    Codigo = vCodigo,
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Ciudad = txtCiudad.Text,
                    Fecha = vFecha,

                }
            };

            return oInfoDataModel;
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            vCRUDController.InsertInfo(InfoDataModel());
            BorrarData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            vCRUDController.DeleteInfo(InfoDataModel());
            BorrarData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            vCRUDController.UpdateInfo(InfoDataModel());
            BorrarData();
        }

        public void BorrarData()
        {
            txtCodigo.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtCiudad.Text = null;
            txtFecha.Text = null;
            GridView1.DataSource = vCRUDController.GetInfo();
            GridView1.DataBind();

        }
        #endregion
    }
}