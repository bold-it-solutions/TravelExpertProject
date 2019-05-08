using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExperts
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["PackageID"] = GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Session["PackageID"] = int.Parse(GridView1.Rows[e.NewEditIndex].Cells[0].Text);
        }
    }
}