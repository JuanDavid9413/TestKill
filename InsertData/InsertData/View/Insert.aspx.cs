using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InsertData.View
{
    public partial class Insert : System.Web.UI.Page
    {
        #region Instances
        MethodInsertController vInsertController = new MethodInsertController();
        MethodInsertData vMethodInsertData = new MethodInsertData();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = vMethodInsertData.GetInfo();
            GridView1.DataBind();
        }

        #region Events
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            int vCodigo = Convert.ToInt16(txtCodigo.Text);
            DateTime vDate = Convert.ToDateTime(txtFecha.Text);
            List<InfoDataModel> List = new List<InfoDataModel>()
            {
                new InfoDataModel()
                {
                    Id = vCodigo,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Ciudad = txtCiudad.Text,
                    Fecha = vDate

                }
            };

            vInsertController.DataInsert(vCodigo,List);
        }
        #endregion

    }
}