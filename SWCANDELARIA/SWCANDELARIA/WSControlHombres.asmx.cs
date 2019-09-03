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
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Data Source= 172.1.1.230\sqlexpress ;Initial Catalog = CODACA ;Integrated Security=False;User id=SA ;Password=sa"
            };
            SqlDataAdapter da = new SqlDataAdapter("select * from openquery(integra,'select * from INTGEN.FGEN029')", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        [WebMethod]
        public double Square(double a, double b)
        {
            return Math.Pow(a, b);
        }

        [WebMethod]
        public string Hola(string Nombre)
        {
            return "Hola" + Nombre;
        }
        public string FyH()
        {
            return DateTime.Now.ToString();
        }

        [WebMethod]
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
            }
            //}
        }
    }

