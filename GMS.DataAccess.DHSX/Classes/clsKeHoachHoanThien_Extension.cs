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
    public partial class clsKeHoachHoanThien : clsDBInteractionBase
    {
		public bool InsertOrUpdate_KHHT(string ngay)
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_KeHoachHoanThien_InsertOrUpdate]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_MaHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_MaHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuongKH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuongKH));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuongTH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuongTH));

				if (clsConnectSql.Closing())
				{
					// Open connection.
					m_scoMainConnection.Open();
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsKeHoachHoanThien::Update::Error occured.", ex);
			}
			finally
			{
				if (clsConnectSql.Opening())
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
			}
		}
	}
}
