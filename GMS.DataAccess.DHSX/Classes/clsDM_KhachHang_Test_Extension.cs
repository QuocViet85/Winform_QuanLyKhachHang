using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using GMS.ConnectionProviders;

namespace GMS_Test
{
    public partial class clsDM_KhachHang_Test : clsDBInteractionQLDH
    {
        public DataTable SelectDanhSachKhachHang()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "pr_DM_KhachHang_Test_DanhSachKhachHang";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("DM_KhachHang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter();
			sdaAdapter.SelectCommand = scmCmdToExecute;

			var m_scoMainConnection = clsConnectSql.getSqlConnection();

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
				throw new Exception("clsDM_KhachHang_Test::SelectDanhSachKhachHang::Error occured.", ex);
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

		public bool InsertKhachHang()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_KhachHang_Test_Insert_Extension]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiKhachHang", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_LoaiKhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenKhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@IsSuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bIsSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_KhachHang", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_KhachHang));

				if (clsConnectSql.Closing())
				{
					// Open connection.
					m_scoMainConnection.Open();
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_KhachHang = (SqlInt32)scmCmdToExecute.Parameters["@ID_KhachHang"].Value;
				return true;
			}
			catch (Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_KhachHang_Test::Insert::Error occured.", ex);
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

		public bool UpdateKhachHang()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_KhachHang_Test_Update_Extension]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_KhachHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_KhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_LoaiKhachHang", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byID_LoaiKhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TenKhachHang", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenKhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@IsSuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bIsSuDung));

				if (clsConnectSql.Closing())
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				string sql = scmCmdToExecute.CommandText;
				return true;
			}
			catch (Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_KhachHang_Test::Update::Error occured.", ex);
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

		public bool SoftDelete()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_KhachHang_Test_Delete_Soft]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_KhachHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_KhachHang));

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
				throw new Exception("clsDM_KhachHang_Test::Delete::Error occured.", ex);
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

		public bool SetTrangThaiKhachHang()
		{
			SqlCommand scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_KhachHang_Test_SetTrangThai]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			SqlConnection m_scoMainConnection = clsConnectSql.getSqlConnection();
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_KhachHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_KhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byTrangThai));

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
				throw new Exception("clsDM_KhachHang_Test::Delete::Error occured.", ex);
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
