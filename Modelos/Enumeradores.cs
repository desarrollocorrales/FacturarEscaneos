
namespace FacturarEscaneos.Modelos
{
    public enum MetodoApiBas
    {
        NewDB = 0,
        DBConnect = 1
    }

    public enum MetodoApiVe
    {
        NuevoPedido = 0,
        RenglonPedido = 1,
        AplicaPedido = 2,
        ChecaCompatibilidadVentas = 3
    }
}
