using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace PuntodeVentaFinal
{
    public partial class Login : Form
    {
        ConexionSQL_Neg cn = new ConexionSQL_Neg();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txt_usuario.Text,txt_clave.Text)==1) 
            {
                MessageBox.Show("EXITO, El usuario y la clave son correctas");
            }
            else 
            {
                MessageBox.Show("ERROR!!!!, No existe Usuario o contraseña incorrecta");
            }
        }
    }
}
