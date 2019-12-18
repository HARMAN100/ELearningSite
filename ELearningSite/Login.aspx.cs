using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ELearningSite.DataModel;
using System.Data;
namespace ELearningSite
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.ToString().Equals("") && !TxtPassword.Text.ToString().Equals(""))
            {
                //object of the model class to verfiy the details 
                Admin obj_Admin = new Admin();
                Data obj_Data = new Data();
                //object of the data table class 
                DataTable tbl = new DataTable();
                //pass the query and check the details 
                tbl = obj_Data.srchRecord("select * from Login where Admin='"+txtName.Text+"' and Password='"+TxtPassword.Text+"'");
                //check the details 
                if (tbl.Rows.Count > 0)
                {
                    Response.Redirect("Dashboard.aspx");
                }
                else {
                    data.InnerHtml = "<script> alert('Invalid User Name or Password ')</script>";
                }
            }
            else {
                data.InnerHtml = "<script> alert('Fill User Name or Password ')</script>";
            }
        }
    }
}