using ELearningSite.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ELearningSite
{
    public partial class Java : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Data obj_Data = new Data();
            DataTable tbl = new DataTable();

            String x = "";
            tbl = obj_Data.srchRecord("Select * from Subject where Category='Java'");
            if (tbl.Rows.Count > 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    x = x + "<div class='col-md-12'><p>" + tbl.Rows[i]["Material"] + "</p></div>";
                }
                details.InnerHtml = x;

            }
            else
            {
                details.InnerHtml = "No Record Found ";
            }

        }
    }
}