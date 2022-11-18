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
        public struct structTurnos
        {
            public int intNumeroTurno;
            public string strDominio;
            public int intAnioFabricacion;
            public string strTitular;
        };
        public structTurnos[] vecTurnos = new structTurnos[50];
        public int intContador = 0;

        private void LimpiezaInterfaz()
        {
            txtTurno.Clear();
            txtDominio.Clear();
            nudModelo.Value = 2022;
            txtTitular.Clear();
            txtTurno.Focus();
        }

        public frmMain()
        {
            InitializeComponent();
        }
        
        private void txtTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente números","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solamente números o letras!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool validador = true;
            if (txtTurno.Text != "" && txtTitular.Text != "" && txtDominio.Text != "")
            {
                if (txtDominio.Text.Length >= 6 && txtTitular.Text.Length >= 2)
                {
                    for (int i = 0; i < intContador; i++)
                    {
                        if (vecTurnos[i].intNumeroTurno == int.Parse(txtTurno.Text))
                        {
                            validador = false;
                        }
                    }
                    if (validador == true)
                    {
                        vecTurnos[intContador].intNumeroTurno = int.Parse(txtTurno.Text);
                        vecTurnos[intContador].strDominio = txtDominio.Text;
                        vecTurnos[intContador].intAnioFabricacion = Convert.ToInt32(nudModelo.Value);
                        vecTurnos[intContador].strTitular = txtTitular.Text;
                        intContador++;
                        MessageBox.Show("Datos ingresados correctamente!","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LimpiezaInterfaz();
                        txtDominioSeisChars.Clear();
                        txtModeloAntiguo.Clear();
                        txtCantidadTurnos.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El turno de registro ya ha sido registrado!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El número de dominio debe ser mayor o igual a 6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan o hay datos ingresados incorrectamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int contadorDominio6 = 0;
            int modeloAntiguo = vecTurnos[0].intAnioFabricacion;
            for (int i = 0; i < intContador; i++)
            {
                if (modeloAntiguo > vecTurnos[i].intAnioFabricacion)
                {
                    modeloAntiguo = vecTurnos[i].intAnioFabricacion;
                }
            }
            txtModeloAntiguo.Text = modeloAntiguo.ToString();
            for (int i = 0; i < intContador; i++)
            {
                if (vecTurnos[i].strDominio.Length == 6)
                {
                    contadorDominio6++;
                }
            }
            txtDominioSeisChars.Text = contadorDominio6.ToString();
            txtCantidadTurnos.Text = intContador.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
