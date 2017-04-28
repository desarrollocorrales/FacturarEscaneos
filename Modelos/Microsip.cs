using System;
using System.Windows.Forms;
using ApiBas = ApisMicrosip.ApiMspBasicaExt;
using ApiVe = ApisMicrosip.ApiMspVentasExt;

namespace FacturarEscaneos.Modelos
{
    public static class Microsip
    {
        public static int iHandlerDB = -99;
        public static int iHandlerMetadatos = -99;
        public static string sPathBD = string.Empty;
        public static string sPathMetadatos = string.Empty;
        public static string sUser = string.Empty;
        public static string sPass = string.Empty;

        public static bool ComprobarCompatibilidad(Label lblAccion)
        {
            try
            {
                if (iHandlerMetadatos == -99)
                {
                    iHandlerDB = ApiBas.NewDB();
                    Logger.AgregarLog("iHandlerDB: " + iHandlerDB);
                    lblAccion.Text = "Asignando Handler a la base de datos....";
                    Application.DoEvents();
                }
                if (iHandlerMetadatos == -99)
                {
                    iHandlerMetadatos = ApiBas.NewDB();
                    Logger.AgregarLog("iHandlerMetadatos: " + iHandlerMetadatos);
                    lblAccion.Text = "Asignando Handler a al Metadatos....";
                    Application.DoEvents();
                }

                ApiBas.SetErrorHandling(0, 0);
                Logger.AgregarLog("Asignar manejo de errores para ApiBasica veSetErrorHandling(0, 0)");
                lblAccion.Text = "Asignar manejo de errores para ApiBasica veSetErrorHandling(0, 0)";
                Application.DoEvents();

                ApiBas.NewTrn(iHandlerDB, 3);
                Logger.AgregarLog("Inicia transacción de Empresa...");
                lblAccion.Text = "Inicia transacción de Empresa...";
                Application.DoEvents();

                int Error = ApiBas.DBConnect(iHandlerDB, sPathBD, sUser, sPass);
                if (Error == 0)
                {
                    //No hay error
                    Logger.AgregarLog("No hay error al conectar a la empresa");
                    lblAccion.Text = "No hay error al conectar a la empresa";
                    Application.DoEvents();

                    ApiVe.SetDBVentas(iHandlerDB);
                    Logger.AgregarLog("Se asigna la conexion al modulo de ventas");
                    lblAccion.Text = "Se asigna la conexion al modulo de ventas";
                    Application.DoEvents();

                    ApiVe.SetReglasPedidos(1, 1, 1);
                    Logger.AgregarLog("Asignar manejo de reglas para ApiVentas SetReglasPedidos(1, 1, 1). Comprometer Unidades");
                    lblAccion.Text = "Asignar manejo de reglas para ApiVentas SetReglasPedidos(1, 1, 1). Comprometer Unidades";
                    Application.DoEvents();

                    ApiVe.veSetErrorHandling(0, 0);
                    Logger.AgregarLog("Asignar manejo de errores para ApiVentas veSetErrorHandling(0, 0)");
                    lblAccion.Text = "Asignar manejo de errores para ApiVentas veSetErrorHandling(0, 0)";
                    Application.DoEvents();

                    ApiBas.NewTrn(iHandlerMetadatos, 3);
                    Logger.AgregarLog("Inicia transacción de Metadatos...");
                    lblAccion.Text = "Inicia transacción de Metadatos...";
                    Application.DoEvents();

                    Error = ApiBas.DBConnect(iHandlerMetadatos, sPathMetadatos, sUser, sPass);
                    if (Error == 0)
                    {
                        //No hay Error
                        Logger.AgregarLog("No hay error al conectar al metadatos");
                        lblAccion.Text = "No hay error al conectar al metadatos";
                        Application.DoEvents();

                        Error = ApiVe.ChecaCompatibilidadVentas(iHandlerMetadatos);
                        if (Error == 0)
                        {
                            //no hay error
                            Logger.AgregarLog("La Api y el modulo de ventas es compatible!");
                            lblAccion.Text = "La Api y el modulo de ventas es compatible!";

                            ApiBas.DBDisconnect(iHandlerMetadatos);
                            Logger.AgregarLog("Desconexión Metadatos iHandlerMetadatos: " + iHandlerMetadatos);
                            lblAccion.Text = "Desconexión Metadatos iHandlerMetadatos...";
                            Application.DoEvents();

                            return true;
                        }
                        else
                        {
                            CaptarErrorApiVe(MetodoApiVe.ChecaCompatibilidadVentas, Error);
                            MessageBox.Show("Error de compatibilidad entre la API y Microsip. Revise el log....");
                            Application.Exit();
                        }
                    }
                    else
                    {
                        CaptarErrorApiBas(MetodoApiBas.DBConnect, Error);
                        MessageBox.Show("Error en el Metadatos. Revise el log....");
                        Application.Exit();
                    }
                }
                else
                {
                    CaptarErrorApiBas(MetodoApiBas.DBConnect, Error);
                    MessageBox.Show("Error al conectar a Microsip. Revise el log....");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Logger.AgregarLog(ex.Message);
                return false;
            }

            return false;
        }
        public static void DesconectarTodo()
        {
            ApiBas.DBDisconnect(-1);
        }

        public static bool NuevoPedido(string fecha, string folio, int cliente_ID, string descripcion)
        {
            int iError = ApiVe.NuevoPedido(fecha, folio, cliente_ID, 0, 0, "", "P", 0, "", descripcion, 0, 0, 0, 0);

            if (iError != 0)
            {
                Logger.AgregarLog("Ocurrió un error de ventas. Código:" + iError);
                CaptarErrorApiVe(MetodoApiVe.NuevoPedido, iError);
                return false;
            }
            
            return true;
        }
        public static bool NuevoRenglon(int articulo_ID, double cantidad, string nota)
        {
            int iError = ApiVe.RenglonPedido(articulo_ID, cantidad, -1, -1, nota);

            if (iError != 0)
            {
                Logger.AgregarLog("Ocurrió un error de ventas. Código:" + iError);
                CaptarErrorApiVe(MetodoApiVe.RenglonPedido, iError);
                return false;
            }

            return true;
        }
        public static bool AplicarPedido()
        {
            int iError = ApiVe.AplicaPedido();

            if (iError != 0)
            {
                Logger.AgregarLog("Ocurrió un error de ventas. Código:" + iError);
                CaptarErrorApiVe(MetodoApiVe.AplicaPedido, iError);
                return false;
            }

            return true;
        }

        public static void CaptarErrorApiBas(MetodoApiBas metodo, int iError)
        {
            String sbErrorMessage = String.Empty;

            switch (metodo)
            {
                case MetodoApiBas.DBConnect:
                    {
                        switch (iError)
                        {
                            case 1: sbErrorMessage = "Handle inexistente..."; break;
                            case 2: sbErrorMessage = "Transacción aun no asignada..."; break;
                            case 3: sbErrorMessage = "Base de datos inexistente..."; break;
                            case 4: sbErrorMessage = "Usuario o password incorrectos..."; break;
                            case 5: sbErrorMessage = "Base de datos actualmente conectada..."; break;
                            case 6: sbErrorMessage = "Error al checar la licencia de la Api Microsip..."; break;
                        }
                        break;
                    }
            }

            var Mensaje = string.Format("ApiBasica... Codigo de error: {0} | Mensaje del error: {1}", iError, sbErrorMessage);
            Logger.AgregarLog(Mensaje);

        }
        public static string CaptarErrorApiVe(MetodoApiVe metodo, int iError)
        {
            String sbErrorMessage = String.Empty;

            switch (metodo)
            {
                case MetodoApiVe.ChecaCompatibilidadVentas:
                    switch (iError)
                    {
                        case 1: sbErrorMessage = "Base de datos de la empresa aun no establecida..."; break;
                        case 2: sbErrorMessage = "Conexión a la base de datos de la empresa aun no establecida..."; break;
                        case 3: sbErrorMessage = "Handle de la base de datos de Metadatos inexistente..."; break;
                        case 4: sbErrorMessage = "Conexión a la base de datos de Metadatos aun no establecida..."; break;
                        case 5: sbErrorMessage = "se puede determinar la compatibilidad debido a que la base de datos de la empresa tiene una conversión incompleta..."; break;
                        case 6: sbErrorMessage = "No existe compatibilidad, se debe actualizar la Api..."; break;
                        case 7: sbErrorMessage = "No existe compatibilidad, se debe actualizar la base de datos de la empresa..."; break;
                        case 8: sbErrorMessage = "No existe compatibilidad, la versión de esta Api no es reconocida por el servidor Microsip, instale el nuevo Metadatos..."; break;
                        case 99: sbErrorMessage = "Error de Api Básica..."; break;
                    }
                    break;

                case MetodoApiVe.NuevoPedido:
                    switch (iError)
                    {
                        case 1: sbErrorMessage = "Base de datos aun no establecida"; break;
                        case 2: sbErrorMessage = "Conexión a la base de datos aun no establecida"; break;
                        case 3: sbErrorMessage = "Documento en proceso"; break;
                        case 4: sbErrorMessage = "Fecha del pedido incorrecta"; break;
                        case 5: sbErrorMessage = "Formato de folio incorrecto"; break;
                        case 6: sbErrorMessage = "Formato de serie de folio incorrecto"; break;
                        case 7: sbErrorMessage = "Serie de folio inexistente"; break;
                        case 8: sbErrorMessage = "No se maneja consecutivo de folio sin serie"; break;
                        case 9: sbErrorMessage = "Cliente inexistente"; break;
                        case 10: sbErrorMessage = "Consignatario inexistente"; break;
                        case 11: sbErrorMessage = "Almacén inexistente"; break;
                        case 12: sbErrorMessage = "Fecha de entrega incorrecta"; break;
                        case 13: sbErrorMessage = "Fecha de entrega anterior a la fecha del pedido"; break;
                        case 14: sbErrorMessage = "Tipo de descuento incorrecto"; break;
                        case 15: sbErrorMessage = "Descuento incorrecto"; break;
                        case 16: sbErrorMessage = "Vendedor inexistente"; break;
                        case 17: sbErrorMessage = "Impuesto sustituido debe ser diferente al sustituto"; break;
                        case 18: sbErrorMessage = "Impuesto sustituido no especificado"; break;
                        case 19: sbErrorMessage = "Impuesto sustituto no especificado"; break;
                        case 20: sbErrorMessage = "Impuesto sustituido inexistente"; break;
                        case 21: sbErrorMessage = "Impuesto sustituto inexistente"; break;
                        case 22: sbErrorMessage = "Impuesto sustituido es una retención"; break;
                        case 23: sbErrorMessage = "Impuesto sustituto es una retención"; break;
                        case 24: sbErrorMessage = "Pedido ya existe"; break;
                        case 25: sbErrorMessage = "La orden de compra excede el valor máximo de caracteres permitido"; break;
                        case 26: sbErrorMessage = "Fecha del pedido es menor a la fecha de última eliminación"; break;
                        case 27: sbErrorMessage = "Moneda inexistente"; break;
                        case 98: sbErrorMessage = "Alguno de los datos foráneos del pedido está siendo modificado por otro usuario"; break;
                        case 99: sbErrorMessage = "Error de Api Básica"; break;
                    }
                    break;

                case MetodoApiVe.RenglonPedido:
                    switch (iError)
                    {
                        case 1: sbErrorMessage = "No hay factura en proceso."; break;
                        case 2: sbErrorMessage = "Artículo inexistente."; break;
                        case 3: sbErrorMessage = "Valor de Unidades fuera de rango."; break;
                        case 4: sbErrorMessage = "Valor de Precio unitario fuera de rango."; break;
                        case 5: sbErrorMessage = "Valor de Porcentaje de descuento fuera de rango."; break;
                        case 6: sbErrorMessage = "Unidades fraccionarias en artículo de series."; break;
                        case 7: sbErrorMessage = "El descuento excede al máximo autorizado."; break;
                        case 8: sbErrorMessage = "El precio es menor al mínimo permitido"; break;
                        case 98: sbErrorMessage = "Alguno de los datos foráneos del pedido está siendo modificado por otro usuario"; break;
                        case 99: sbErrorMessage = "Error de Api Básica"; break;
                    }
                    break;
            }

            var Mensaje = string.Format("ApiVentas... Codigo de error: {0} | Mensaje del error: {1}", iError, sbErrorMessage);
            Logger.AgregarLog(Mensaje);

            MessageBox.Show(Mensaje);
            return sbErrorMessage;
        }
    }
}
