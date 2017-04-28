using System;
using System.Collections.Generic;
using System.Data;
using FacturarEscaneos.Modelos;
using FirebirdSql.Data.FirebirdClient;

namespace FacturarEscaneos.DAL
{
    public class FBDAL
    {
        private FbConnection FbConn;
        private FbCommand FbComm;
        private FbDataAdapter FbAdapter;

        public FBDAL()
        {
            FbConn = new FbConnection(getConnectionString());
            FbComm = new FbCommand();
            FbAdapter = new FbDataAdapter();
        }

        private string getConnectionString()
        {
            var FBCSB = new FbConnectionStringBuilder();

            FBCSB.DataSource = "ServidorX";
            FBCSB.Database = @"C:\Microsip datos\Abastecedora.fdb";
            FBCSB.UserID = "sysdba";
            FBCSB.Password = "PIARPE";
            FBCSB.Port = 3050;

            return FBCSB.ToString();
        }
        public List<Articulo> getArticulos(List<VistaPrevia> lstArticulosPedido)
        {
            List<Articulo> lstArticulos = new List<Articulo>();
            try
            {
                string clavesWhere = string.Empty;
                foreach (VistaPrevia articuloPedido in lstArticulosPedido)
                {
                    clavesWhere += string.Format("'{0}', ", articuloPedido.sClaveArticulo);
                }
                clavesWhere += "'Z'";

                FbConn.Open();
                FbComm.Connection = FbConn;
                FbComm.CommandText = 
                    string.Format(@"SELECT 
                                      A.ARTICULO_ID,
                                      CA.CLAVE_ARTICULO,
                                      A.NOMBRE
                                    FROM
                                      CLAVES_ARTICULOS CA
                                      INNER JOIN ARTICULOS A ON (CA.ARTICULO_ID = A.ARTICULO_ID)
                                    WHERE
                                      CA.CLAVE_ARTICULO IN ({0})", clavesWhere);

                DataTable dtResultado = new DataTable();
                FbAdapter.SelectCommand = FbComm;
                FbAdapter.Fill(dtResultado);

                Articulo arti;
                foreach (DataRow row in dtResultado.Rows)
                {
                    arti = new Articulo();
                    arti.iID = Convert.ToInt32(row["ARTICULO_ID"]);
                    arti.sClave = Convert.ToString(row["CLAVE_ARTICULO"]);
                    arti.sNombre = Convert.ToString(row["NOMBRE"]);

                    lstArticulos.Add(arti);
                }
            }
            catch (Exception ex)
            {
                if (FbConn.State != ConnectionState.Closed)
                {
                    FbConn.Close();
                }

                throw ex;
            }
            return lstArticulos;
        }
        public DateTime getFechaServer()
        {
            DateTime Fecha;
            try
            {               
                FbConn.Open();
                FbComm.Connection = FbConn;
                FbComm.CommandText = string.Format(@"SELECT CAST('Now' AS TIMESTAMP) FROM rdb$database");
                Fecha = Convert.ToDateTime(FbComm.ExecuteScalar());
            }
            catch (Exception ex)
            {
                if (FbConn.State != ConnectionState.Closed)
                {
                    FbConn.Close();
                }

                throw ex;
            }
            return Fecha;
        }
    }
}
