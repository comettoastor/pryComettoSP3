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
        int vContadorTurnos = 0;
        int vModeloMasAntiguo = 0;
        int vCantidadDom6 = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void txtTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
                if (numModelo.Value < vModeloMasAntiguo || vModeloMasAntiguo == 0)
                {
                    vModeloMasAntiguo = Convert.ToInt32(numModelo.Value);                
                }
                if (txtDominio.Text.Length == 6)
                {
                    vCantidadDom6++;
                }
            }
            else
            {
                MessageBox.Show("Faltan o hay datos ingresados incorrectamente");
            }
        }
    }
}
