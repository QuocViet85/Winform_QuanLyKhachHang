using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS_Test
{
    public static class clsConnectSql
    {
        private static SqlConnection m_scoMainConnection;

        public static SqlConnection getSqlConnection()
        {
            if (m_scoMainConnection == null)
            {
                string sqlconnectStr = "Data Source=DESKTOP-HCT4A7L\\SQLEXPRESS; Initial Catalog=GMS_Test; TrustServerCertificate=true; Integrated Security=true";
                m_scoMainConnection = new SqlConnection(sqlconnectStr);
            }
            return m_scoMainConnection;
        }

        public static bool Opening()
        {
            if (m_scoMainConnection == null)
            {
                throw new Exception("");
            }

            return m_scoMainConnection.State == System.Data.ConnectionState.Open;
        }

        public static bool Closing()
        {
            if (m_scoMainConnection == null)
            {
                throw new Exception("");
            }

            return m_scoMainConnection.State == System.Data.ConnectionState.Closed;
        }
    }
}
