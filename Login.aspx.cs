using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaNet
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click1(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-IH9506Q;Initial Catalog=EjercicioTecnico;Integrated Security=True");
            conexion.Open();
            String Cadena = "select * from Usuario where Nombre='" + txtUser.Text + "' AND Contra ='" + password.Text + "';";
            SqlCommand comando = new SqlCommand(Cadena, conexion);
            Console.WriteLine("Llega");
            try
            {
                comando.ExecuteNonQuery();
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.GetValue(0) != null)
                {
                    txtUser.Text = "Correcto";
                }
                else
                {
                    txtUser.Text = "InCorrecto";
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        protected void btnIngresar_Click1(object sender, EventArgs e)
        {
            try {
                SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-IH9506Q;Initial Catalog=EjercicioTecnico;Integrated Security=True");
                conexion.Open();
                string query = "select Nombre,Contra from Usuario where Nombre= @usuario and Contra = @password";
                SqlCommand cm = new SqlCommand(query, conexion);
                cm.Parameters.AddWithValue("@usuario", txtUser.Text);
                cm.Parameters.AddWithValue("@password", password.Text);
                SqlDataReader registros = cm.ExecuteReader();
                if (registros.Read())
                {
                    txtUser.Text = registros["Nombre"].ToString() + " Elegido";
                    password.Text = registros["Contra"].ToString() + " Elegido";
                }
                else {
                    error.Text = "Usuario O Contraseña no Validos 1";
                }
                
            
            } catch (Exception ex) { error.Text = "Usuario O Contraseña no Validos"; }
           
        }
    }
}