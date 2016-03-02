using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacturarEscaneos.Modelos;
using FacturarEscaneos.DAL;
using System.IO;

namespace FacturarEscaneos.GUIS
{
    public partial class Frm_Principal : Form
    {
        private int cbIndex;
        private List<string> lstSalidasSeleccionadas;
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
            cbIndex = -99;
            lstSalidasSeleccionadas = new List<string>();
            CargarComboSucursales();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MySQL_DAL myDAL = new MySQL_DAL();
                var lstCodigosDeSalida = new List<string>();
                lstCodigosDeSalida.Add("- Seleccione un código -");
                lstCodigosDeSalida.AddRange(myDAL.getSalidasPorDia(dtpFecha.Value.Date));

                cbEscaneo.DataSource = lstCodigosDeSalida;
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbEscaneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIndex != cbEscaneo.SelectedIndex)
            {
                cbIndex = cbEscaneo.SelectedIndex;
                var sCodigo = Convert.ToString(cbEscaneo.SelectedItem);

                CargarGridDetalles(sCodigo);
            }
        }
        private void CargarGridDetalles(string sCodigo)
        {
            try
            {
                MySQL_DAL myDAL = new MySQL_DAL();
                var lstDetalles = myDAL.getDatosEscaneo(sCodigo);

                gridVistaPrevia.DataSource = lstDetalles;
                gvVistaPrevia.BestFitColumns();
            }
            catch(Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarSalida();
        }
        private void AgregarSalida()
        {
            try
            {
                if (cbEscaneo.SelectedIndex != 0)
                {
                    var salidaSeleccionada = Convert.ToString(cbEscaneo.SelectedItem);
                    lstSalidasSeleccionadas.Add(salidaSeleccionada);
                    lstSalidasSeleccionadas = lstSalidasSeleccionadas.Distinct().ToList();
                    Logger.AgregarLog(string.Format("Se agregó la salida {0} a la lista...", salidaSeleccionada));

                    listSalidas.DataSource = lstSalidasSeleccionadas;
                }
            }
            catch(Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            QuitarSalida();
        }
        private void QuitarSalida()
        {
            try
            {
                if (lstSalidasSeleccionadas.Count > 0)
                {
                    var salidaSeleccionada = Convert.ToString(listSalidas.SelectedItem);
                    lstSalidasSeleccionadas.Remove(salidaSeleccionada);
                    Logger.AgregarLog(string.Format("Se eliminó la salida {0} de la lista...", salidaSeleccionada));

                    listSalidas.DataSource = null;
                    listSalidas.DataSource = lstSalidasSeleccionadas;
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            tbControl.SelectedIndex = 1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbControl.SelectedIndex = 0;
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbControl.SelectedIndex == 1)
            {
                CargarDetallesPedido();
            }
        }
        private void CargarDetallesPedido()
        {
            try
            {
                if (listSalidas.Items.Count > 0)
                {
                    MySQL_DAL myDAL = new MySQL_DAL();
                    gridDetallesSalidas.DataSource = myDAL.getDetallesPedido((List<string>)listSalidas.DataSource);
                    gvSalidasDetalles.BestFitColumns();
                }
            }
            catch(Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarComboSucursales()
        {
            var lstSucursales = new List<Sucursal>();
            string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\Config\\Sucursales");

            Sucursal suc;
            foreach (string line in lines)
            {
                var vectorSucursal = line.Split('-');

                suc = new Sucursal();
                suc.iID = Convert.ToInt32(vectorSucursal[0].Trim());
                suc.sNombre = vectorSucursal[1].Trim();

                lstSucursales.Add(suc);
            }

            cbSucursales.DataSource = lstSucursales;
            cbSucursales.DisplayMember = "sNombre";
            cbSucursales.ValueMember = "iID";

            if (cbSucursales.Items.Count > 0)
                cbSucursales.SelectedIndex = 0;
        }
    }
}
