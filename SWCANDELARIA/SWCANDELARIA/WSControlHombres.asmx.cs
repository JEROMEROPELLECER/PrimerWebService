using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;


namespace SWCANDELARIA
{
    /// <summary>
    /// Descripción breve de WSControlHombres
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]


    public class WSControlHombres : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet Getdata()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "@Data Source= 127.0.0.1\\SQL ;Initial Catalog = CANDE;Integrated Security=False;User Id=sa;Password=Dpdlanman2010";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ADM_MAESTRO_HOMBRES_2010 " ,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

       /* [WebMethod]
        public double Square(double a, double b)
        {
            return Math.Pow(a, b);
        }
        




        /*[WebMethod]
        public string Hola(string Nombre)
        {
            return "Hola" + Nombre;
        }
        /*public string FyH()
        {
            return DateTime.Now.ToString();
        }*/

       /* [WebMethod]
        public string HelloWorld()
        {
            return "Control de candelaria Hombres  ";
            
        }
        [WebMethod]
        public bool consultahombre()
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }*/
        //}
    }
}
