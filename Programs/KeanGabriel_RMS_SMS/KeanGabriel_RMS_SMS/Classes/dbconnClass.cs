using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KeanGabriel_RMS_SMS.Classes
{
    class dbconnClass
    {
        SqlConnection conn;
        SqlConnection connLogs;
        //Variable use in specifying conn strings for fast migration. You can change this variable.
        int ConnPC = 2;
        public SqlConnection getdbConnection()
        {
            if (ConnPC == 0)
            {
                conn = new SqlConnection("Data Source=JOHN-PC\\MSSSQLSERVER;Initial Catalog=keanGabrielDB;Integrated Security=True");
            }
            else if (ConnPC == 1)
            {
                conn = new SqlConnection("Data Source=MARC-MQ78R3B;Initial Catalog=keanGabrielDB;Integrated Security=True");
            }
            else if(ConnPC == 2){
                conn = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=keanGabrielDB;Integrated Security=True");
            }
            return conn;
        }
        public SqlConnection getdbConnectionOnLogs()
        {
            if (ConnPC == 0)
            {
                connLogs = new SqlConnection("Data Source=JOHN-PC\\MSSSQLSERVER;Initial Catalog=KGH_Logs;Integrated Security=True");
            }
            else if (ConnPC == 2)
            {
                connLogs = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=KGH_Logs;Integrated Security=True");
            }
            return connLogs;
        }
    }
}
