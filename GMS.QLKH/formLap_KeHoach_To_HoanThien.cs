using C1.Win.C1FlexGrid;
using GMS_Test;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSCM.Base.Forms;
using VSCM.Base.Utils;

namespace GMS.QLKH
{
    public partial class formLap_KeHoach_To_HoanThien : FormBase
    {
        private int m_Thang;
        private int m_Nam;
        public formLap_KeHoach_To_HoanThien()
        {
            InitializeComponent();
            LoadFilterThoiGian();
            btnHuy.Visible = false;
        }

        private void LoadFilterThoiGian()
        {
            DateTime now = DateTime.Now;
            m_Thang = now.Month;
            m_Nam = now.Year;

            cbNam.AddItem(now.Year.ToString());
            cbNam.AddItem((now.Year - 1).ToString());
            cbNam.AddItem((now.Year - 2).ToString());
            cbNam.AddItem((now.Year - 3).ToString());
            cbNam.SelectedIndex = 0;
            for (int i = 1; i <= 12; i++)
            {
                cbThang.AddItem(i.ToString());
            }
            cbThang.SelectedIndex = now.Month - 1;
        }

        private void formLap_KeHoach_To_HoanThien_Load(object sender, EventArgs e)
        {
            LoadFg();
        }

        private void LoadFg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();

            fg.AllowMerging = AllowMergingEnum.Free;
            fg.Cols["ToSX"].AllowMerging = true;
            fg.Cols["MaHang"].AllowMerging = true;
            fg.Cols["PO_No"].AllowMerging = true;
            fg.Cols["NgayGiaoHang"].AllowMerging = true;

            clsMaHang cls = new clsMaHang();
            string tuNgay = "";
            string denNgay = "";
            tuNgay = $"{m_Nam}-{m_Thang}-1";
            if (m_Thang == 12)
            {
                denNgay = $"{m_Nam + 1}-1-1";
            }
            else
            {
                denNgay = $"{m_Nam}-{m_Thang + 1}-1";
            }
            DataTable dt = cls.SelectAll_MaHangWithKHHT(tuNgay, denNgay);
            HandleDataTable(dt);
            fg.SetDataSource(dt);
            
            fg.Row = -1; //trỏ đến hàng trong lưới
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.SetSTT();
            fg.Tag = 1;
        }

        private void HandleDataTable(DataTable dt)
        {
            for (int i = 1; i <= 31; i++)
            {
                DataColumn col = dt.Columns.Add();
                col.ColumnName = "Ngay" + i;
            }

            DataColumn colTong = dt.Columns.Add();
            colTong.ColumnName = "Tong";

            foreach (DataRow row in dt.Rows)
            {
                string khTH = row["KHTH"].ToString();
                string jsonKeHoach = row["ListKeHoach"].ToString();
                int tong = 0;

                if (!string.IsNullOrEmpty(jsonKeHoach))
                {
                    if (khTH == "KH")
                    {
                        KeHoachHoanThienModel[] keHoachArr = JsonConvert.DeserializeObject<KeHoachHoanThienModel[]>(jsonKeHoach);
                        foreach (KeHoachHoanThienModel keHoach in keHoachArr)
                        {
                            int ngay = keHoach.Ngay.Day;
                            row["Ngay" + ngay] = keHoach.SoLuongKH;
                            tong += keHoach.SoLuongKH;
                        }
                    }
                    else
                    {
                        KeHoachHoanThienModel[] keHoachArr = JsonConvert.DeserializeObject<KeHoachHoanThienModel[]>(jsonKeHoach);

                        foreach (KeHoachHoanThienModel keHoach in keHoachArr)
                        {
                            int ngay = keHoach.Ngay.Day;
                            row["Ngay" + ngay] = keHoach.SoLuongTH;
                            tong += keHoach.SoLuongTH;
                        }
                    }
                    row["Tong"] = tong;
                }  
            }
        }

        private void cbNam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedValue = int.Parse(cbNam.Text);
            m_Nam = selectedValue;
            LoadFg();
        }

        private void cbThang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedValue = int.Parse(cbThang.Text);
            m_Thang = selectedValue;
            LoadFg();
        }

        private void fg_AfterEdit(object sender, RowColEventArgs e)
        {
            string tenCotThang = fg.Cols[e.Col].Name;
            fg[e.Row, "DayEdit"] = int.Parse(tenCotThang.Substring(4));
            btnHuy.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowQuestionMessage("Bạn có chắc hủy các thay đổi không ?") == DialogResult.Yes)
            {
                LoadFg();
                btnHuy.Visible = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataRow[] editRows = fg.ToDataTable(false, VSCM.Base.Controls.ucFlexGrid.ToDatatableValue.Value).Select("DayEdit > 0");

            foreach (DataRow editRow in editRows)
            {
                int ngayThayDoi = int.Parse(editRow["DayEdit"].ToString());
                string khTh = editRow["KHTH"].ToString();

                clsKeHoachHoanThien cls = new clsKeHoachHoanThien();
                cls.ID_MaHang = int.Parse(editRow["ID_MaHang"].ToString());

                if (khTh == "KH")
                {
                    cls.SoLuongKH = int.Parse(editRow[$"Ngay{ngayThayDoi}"].ToString());
                    cls.SoLuongTH = -1;
                }else
                {
                    cls.SoLuongTH = int.Parse(editRow[$"Ngay{ngayThayDoi}"].ToString());
                    cls.SoLuongKH = -1;
                }
            }

            if (editRows.Count() > 0)
            {
                LoadFg();
            }
        }
    }

    public class KeHoachHoanThienModel
    {
        public int ID_BoPhan { set; get; }
        public DateTime Ngay { set; get; }
        public int SoLuongKH { set; get; }
        public int SoLuongTH { set; get; }
    }
}
