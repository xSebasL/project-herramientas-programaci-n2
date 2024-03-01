using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace login
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validateForm(txtUsuario.Text, txtClave.Text))
            {
                formBienvenida form_bienvenida = new formBienvenida(txtUsuario.Text);
                form_bienvenida.Show();
            }
            
        }   
        int errors = 0;
        private Boolean validateForm(string usuario, string clave)
        {
            if (errors == 3)
            {
                lblError.Text = "Intentos agotados";
                return false;
            }
            if (usuario != "admin")
            {
                lblError.Text = "Usuario incorrecto";
                errors++;
                return false;
            }
            else if (clave != "12345")
            {
                lblError.Text = "Contraseña incorrecta";
                errors++;
                return false;
            }
            return true;
        }
    }
}
