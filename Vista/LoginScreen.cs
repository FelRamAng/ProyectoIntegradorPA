using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = string.Format("SELECT * FROM login WHERE usuario = '{0}' AND contra = '{1}';", usuarioTB.Text.Trim(), ContraTB.Text.Trim());
                DataSet connect = Libreria.Herramientas(consulta);

                string nombreusuario = connect.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string contra = connect.Tables[0].Rows[0]["contra"].ToString().Trim();
                int rol = Int32.Parse(connect.Tables[0].Rows[0]["rol"].ToString().Trim());
                int id = Int32.Parse(connect.Tables[0].Rows[0]["id_usuario"].ToString().Trim());


                if (nombreusuario == usuarioTB.Text.Trim() && contra == ContraTB.Text.Trim())
                {
                    Principal principal = new Principal(id, rol, connect);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario / Contraseña Incorrecta");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Ocurrió un Error: " + error);
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (VerContra.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                ContraTB.PasswordChar = '\0';
                VerContra.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                ContraTB.PasswordChar = 'X';
                VerContra.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void ContraTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
