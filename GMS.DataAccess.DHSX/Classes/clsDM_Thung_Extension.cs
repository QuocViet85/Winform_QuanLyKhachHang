using GMS_Test;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSCM.Base.Classes;

namespace GMS_Test
{
    public partial class clsDM_Thung : clsDBInteractionBase
    {
		public DataTable SelectAll_Thung()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_Thung_SelectAll_Extension]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_Thung");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

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
				throw new Exception("clsDM_Thung::SelectAll::Error occured.", ex);
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

		public bool Insert_Thung()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_Thung_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Thung", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Thung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@MaThung", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaThung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TenThung", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenThung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Kho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@IsSuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bIsSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@IsTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bIsTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NgayNhap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NgaySuaCuoi", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgaySuaCuoi));

				if (clsConnectSql.Closing())
				{
					// Open connection.
					m_scoMainConnection.Open();
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_Thung = (SqlInt32)scmCmdToExecute.Parameters["@ID_Thung"].Value;
				return true;
			}
			catch (Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_Thung::Insert::Error occured.", ex);
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

		public bool Update_Thung()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_Thung_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Thung", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Thung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@MaThung", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaThung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TenThung", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenThung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Kho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@IsSuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bIsSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@IsTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bIsTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NgayNhap", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NgaySuaCuoi", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgaySuaCuoi));

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
				throw new Exception("clsDM_Thung::Update::Error occured.", ex);
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
