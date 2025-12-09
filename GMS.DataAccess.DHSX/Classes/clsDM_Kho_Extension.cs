using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS_Test
{
    public partial class clsDM_Kho
    {
		public DataTable SelectAll_Kho()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_Kho_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_Kho");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{

				if (clsConnectSql.Closing())
				{
					// Open connection.
					m_scoMainConnection.Open();
				}

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				return dtToReturn;
			}
			catch (Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_Kho::SelectAll::Error occured.", ex);
			}
			finally
			{
				if (clsConnectSql.Opening())
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}
	}
}
