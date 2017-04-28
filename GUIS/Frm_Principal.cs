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
                lstCodigosDeSalida.AddRange(myDAL.getSalidasPorDia(dtpFecha.Value.Date));

                if (lstCodigosDeSalida.Count > 0)
                {
                    cbEscaneo.DataSource = lstCodigosDeSalida;

                    cbEscaneo.SelectedIndex = 1;
                    cbEscaneo.SelectedIndex = 0;
                    gridEscaneos.DataSource = lstCodigosDeSalida;
                }
                
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
                var salidaSeleccionada = Convert.ToString(cbEscaneo.SelectedItem);
                lstSalidasSeleccionadas.Add(salidaSeleccionada);
                lstSalidasSeleccionadas = lstSalidasSeleccionadas.Distinct().ToList();
                Logger.AgregarLog(string.Format("Se agregó la salida {0} a la lista...", salidaSeleccionada));

                listSalidas.DataSource = lstSalidasSeleccionadas;
            }
            catch (Exception ex)
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

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            try
            {
                CrearPedido();
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        private void CrearPedido()
        {
            Logger.AgregarLog("Obtener fecha...");
            DateTime dtFecha = getFechaServer();

            Logger.AgregarLog("Obtener Lista de Artículos...");
            List<Articulo> lstArticulos = getListaArticulosMicrosip();


            Logger.AgregarLog("Obtener Sucursal Cliente");
            var oSucursal = (Sucursal)cbSucursales.SelectedItem;
            var lstRenglonesPedido = (List<VistaPrevia>)gridDetallesSalidas.DataSource;

            string sFecha = dtFecha.ToString("dd/MM/yyyy");
            string sFolio = txbFolio.Text;

            bool bExito = false;

            Logger.AgregarLog("--------------------    INICIA EL PEDIDO    --------------------");
            Logger.AgregarLog("Fecha del Pedido: " + sFecha);
            Logger.AgregarLog("Folio del Pedido: " + sFolio);
            Logger.AgregarLog("Cliente del Pedido: " + oSucursal.sNombre + " - " + oSucursal.iID);
            Logger.AgregarLog("Invocar al Metodo 'Nuevo Pedido'");
            bExito = Microsip.NuevoPedido(sFecha, sFolio, oSucursal.iID, "Descripcion de pedido automatico");
            if (bExito == true)
            {
                //Se creó el encabezado con exito
                bool bExitoRenglones = true;
                Logger.AgregarLog("   El encabezado se creó con Exito");
                foreach (VistaPrevia renglonPedido in lstRenglonesPedido)
                {
                    Logger.AgregarLog("      Invocar al Metodo 'Nuevo Renglon'");
                    var articulo = lstArticulos.FirstOrDefault(o => o.sClave == renglonPedido.sClaveArticulo);
                    Logger.AgregarLog("        Articulo a ingresar: " + articulo.sNombre);
                    var cantidad = Convert.ToDouble(renglonPedido.dCantidad);
                    Logger.AgregarLog("        Cantidad a ingresar: " + cantidad.ToString("n"));

                    bExito = Microsip.NuevoRenglon(articulo.iID, cantidad, string.Empty);
                    if (bExito == true)
                    {
                        Logger.AgregarLog("      ¡Renglon agregado con exito!");
                    }
                    else
                    {
                        Logger.AgregarLog("      Error al invocar el metodo 'Nuevo Renglon'");                        
                        bExitoRenglones = false;
                        //MessageBox.Show("Error al invocar el metodo 'Nuevo Renglon'"); 
                        break;
                    }
                }
                if (bExitoRenglones == true)
                {
                    Logger.AgregarLog("          Invocar al Metodo 'Aplicar Pedido'");
                    bExito = Microsip.AplicarPedido();
                    if (bExito == false)
                    {
                        Logger.AgregarLog("          Error al invocar el método 'Aplicar Pedido'");
                    }
                }                
            }
            else
            {
                //No se pudo crear el encabezado
                Logger.AgregarLog("Error al invocar el metodo 'Nuevo Pedido' ");
                //MessageBox.Show("Error al invocar el metodo 'Nuevo Pedido' "); 
            }
            Logger.AgregarLog("--------------------    TERMINA EL PEDIDO    --------------------");
        }
        private List<Articulo> getListaArticulosMicrosip()
        {
            List<Articulo> lstArticulos = new List<Articulo>();
            try
            {
                FBDAL fbdal = new FBDAL();
                var lstArticulosDePedido = (List<VistaPrevia>)gridDetallesSalidas.DataSource;

                lstArticulos = fbdal.getArticulos(lstArticulosDePedido);
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            return lstArticulos;
        }
        private DateTime getFechaServer()
        {
            DateTime Fecha = new DateTime();
            try
            {
                FBDAL fbdal = new FBDAL();
                Fecha = fbdal.getFechaServer();
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            return Fecha;
        }

        private void gvEscaneos_DoubleClick(object sender, EventArgs e)
        {
            AgregarSalida();
        }

        private void listSalidas_DoubleClick(object sender, EventArgs e)
        {
            QuitarSalida();
        }

        private void listSalidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sCodigo = Convert.ToString(listSalidas.SelectedItem);

            CargarGridDetalles(sCodigo);
        }
    }
}
