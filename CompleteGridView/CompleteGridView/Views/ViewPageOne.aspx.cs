using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CompleteGridView.Views
{
    public partial class ViewPageOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Instances
            CompletedGridViewMethod oGried = new CompletedGridViewMethod();
            #endregion

            using (DataTable dt = new DataTable())
            {
                dt.Columns.AddRange(
                        new DataColumn[3]
                        {
                        new DataColumn("Id",typeof(int)),
                        new DataColumn("Nombre", typeof(string)),
                        new DataColumn("Apellido", typeof(string))
                        }
                    );
                dt.Rows.Add(1, "Juan David Moreno");
                dt.Rows.Add(2, "Alba Cecilia");
                dt.Rows.Add(3, "Gabriela Montaño");
                GridView1.DataSource = dt;
                GridView1.DataBind();

                //get info griedViewTwo
                GridView2.DataSource = oGried.GetInfo();
                GridView2.DataBind();



            }
        }

    }
}