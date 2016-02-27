using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacturarEscaneos.Modelos;

namespace FacturarEscaneos.GUIS
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Microsip.DesconectarTodo();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            if (cbEscaneo.Items.Count!=0)
                cbEscaneo.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Se movio la fecha");
        }

        private void cbEscaneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Se movió el ComboBox");
        }
    }
}
