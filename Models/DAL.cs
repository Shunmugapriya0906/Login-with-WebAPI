using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;

namespace LoginWebApi.Models
{
    public class DAL
    {
        SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);
        SqlDataAdapter da = null;
        DataTable dt = null;
        public string GetLogin(Login login)
        {
            da = new SqlDataAdapter("select * from users where Username='" + login.Username +"' and password= '" + login.password + " ' ", con);
            dt=new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                return "Logged In";
            }
            else
            {
                return "Login Failed";
            }

        
        }
    }
}