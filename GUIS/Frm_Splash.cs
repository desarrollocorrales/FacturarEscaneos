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
        }
    }
}
