using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestCompleteGriedView.Views
{
    public partial class ViewInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Instances
            AccessMethodsCRUD vGetInfo = new AccessMethodsCRUD();
            #endregion

            #region Methods
            GriedView1.DataSource = vGetInfo.GetInfo();
            GriedView1.DataBind();
            #endregion
        }
    }
}