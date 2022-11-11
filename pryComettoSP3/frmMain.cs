using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoSP3
{
    public partial class frmMain : Form
    {
        //DECLARACION DE VARIABLES GLOBALES (EXCLUSIVAS PARA ESTE FORMULARIO)
        int vContadorTurnos = 0;
        int vModeloMasAntiguo = 0;
        int vCantidadDom6 = 0;

        //Vector - Array 1 Dimension
        string[] vector = new string[0];

        //Matriz - Array 2 Dimensiones
        string[,] vector2 = new string[0,0];
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void txtTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente números","Error");
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDominio.Text.Length >= 6 && txtTitular.Text.Length >= 2)
            {
                MessageBox.Show("Datos ingresados correctamente");
                vContadorTurnos++;
                if (nudModelo.Value < vModeloMasAntiguo || vModeloMasAntiguo == 0)
                {
                    vModeloMasAntiguo = Convert.ToInt32(nudModelo.Value);                
                }
                if (txtDominio.Text.Length == 6)
                {
                    vCantidadDom6++;
                }
                LimpiezaInterfaz();
            }
            else
            {
                MessageBox.Show("Faltan o hay datos ingresados incorrectamente");
            }
        }

        private void txtTurno_TextChanged(object sender, EventArgs e)
        {
            if (txtTurno.Text != "")
            {
                lblDominio.Enabled = true;
                txtDominio.Enabled = true;
            }
            else
            {
                lblDominio.Enabled = false;
                txtDominio.Enabled = false;
            }
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtDominio.Text != "")
            {
                lblModelo.Enabled = true;
                nudModelo.Enabled = true;
                lblTitular.Enabled = true;
                txtTitular.Enabled = true;
            }
            else
            {
                lblModelo.Enabled = false;
                nudModelo.Enabled = false;
                lblTitular.Enabled = false;
                txtTitular.Enabled = false;
            }
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtTitular.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void LimpiezaInterfaz()
        {
            txtTurno.Clear();
            txtDominio.Clear();
            nudModelo.Value = 2022;
            txtTitular.Clear();
            txtTurno.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtCantidadTurnos.Text = vContadorTurnos.ToString();
            txtModeloAntiguo.Text = vModeloMasAntiguo.ToString();
            txtDominioSeisChars.Text = vCantidadDom6.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
