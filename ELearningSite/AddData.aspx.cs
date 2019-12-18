using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ELearningSite.DataModel;

namespace ELearningSite
{
    public partial class AddData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (!txtCategory.Text.ToString().Equals("") && !TxtData.Text.ToString().Equals("")) {
                Data obj = new Data();
                obj.SqlQuery("insert into Subject(Category,Material) values('"+txtCategory.Text.ToString()+"','"+TxtData.Text.ToString()+"')");
                data.InnerHtml = "Record saved ";
                txtCategory.Text = "";
                TxtData.Text = "";

            }
        }
    }
}