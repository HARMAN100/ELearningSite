using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ELearningSite.DataModel;
namespace ELearningSite
{
    public partial class HTML : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Data obj_Data = new Data();
            DataTable tbl = new DataTable();
            String x = "<h1 align='center'>HTML</h1>";
            tbl = obj_Data.srchRecord("Select * from Subject where Category='HTML'");
            if (tbl.Rows.Count > 0)
            {
                for (int i=0;i<tbl.Rows.Count;i++) {
                    x = x + "<div class='col-md-12'><h3>"+tbl.Rows[i]["Material"]+"</h3></div>";
                }
                x = x + "<hr color='black'/>";
                details.InnerHtml =x;

            }
            else {
                details.InnerHtml = "No Record Found ";
            }
        }
    }
}