using GMS_Test;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSCM.Base.Classes;

namespace GMS_Test
{
    public partial class clsMaHang : clsDBInteractionBase
    {
		public DataTable SelectAll_MaHangWithKHHT(string tuNgay, string denNgay)
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_MaHang_KeHoachHoanThien_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("MaHang");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TuNgay", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, tuNgay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DenNgay", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, denNgay));

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
				throw new Exception("clsMaHang::SelectAll::Error occured.", ex);
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
