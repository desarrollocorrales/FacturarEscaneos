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
            FBCSB.Database = @"C:\Microsip datos\Libertad.fdb";
            FBCSB.UserID = "sysdba";
            FBCSB.Password = "PIARPE";
            FBCSB.Port = 3050;

            return FBCSB.ToString();
        }

    }
}
