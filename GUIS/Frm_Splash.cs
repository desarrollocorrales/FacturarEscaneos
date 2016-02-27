using System;
using System.Windows.Forms;
using FacturarEscaneos.Modelos;

namespace FacturarEscaneos.GUIS
{
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
        }

        private void Frm_Splash_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();

            Microsip.sPathBD = @"Servidorx:C:\Microsip datos\Libertad.FDB";
            Microsip.sPathMetadatos = @"Servidorx:C:\Microsip datos\System\Metadatos.FDB";
            Microsip.sUser = @"SYSDBA";
            Microsip.sPass = @"PIARPE";
            Microsip.ComprobarCompatibilidad(lblAccion);

            this.Hide();
            new Frm_Principal().ShowDialog();
            this.Close();
        }
    }
}
