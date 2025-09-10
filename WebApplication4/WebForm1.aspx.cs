using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-2U6GAUD\SQLEXPRESS;database=DB1;Intergrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string==>'"+ +"'
            //int==>"+ +"
            string ins = "insert into Table_1 values('"+TextBox1.Text+"',"+TextBox2.Text+",'"+TextBox3.Text+"')";
            SqlCommand cmd = new SqlCommand(ins, con);//cmd=insert query
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
                Label1.Text = "Inserted";
            else
                Label1.Text = "Not Inserted";
        }

       
    }
}