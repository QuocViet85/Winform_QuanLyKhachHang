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
using GMS.SystemModule.Forms;
using GMS_Test;
using C1.Win.C1FlexGrid;
using GMS.SystemModule.HeThong;
using GMS.QLKH.Helpers;

namespace GMS.QLKH
{
    public partial class frmDM_KhachHang_Test_Main : FormBase
    {
        private FlexGridFilterManager m_oFilter;
        private CellStyle csDangLap, csTrinhDuyet, csHuyDuyet, csPheDuyet;
        private DataTable m_dt;

        private bool m_modeUpdate = true;
        public frmDM_KhachHang_Test_Main()
        {
            InitializeComponent();

            /*
                FlexGridFilterManager để tạo Search
            */
            m_oFilter = new FlexGridFilterManager(fg);
            m_oFilter.AddFilterControl(TenKhachHang);
            m_oFilter.AddFilterControl(cmbLoaiKhachHang);

            SetButtonDefault();
        }

        private void SetButtonDefault ()
        {
            fg.AllowEditing = false;
            fg.AllowDelete = false;
            tsThemDong.Enabled = false;
            tsXoaDong.Enabled = false;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnSua.Visible = true;
            btnTrinhDuyet.Enabled = false;
            btnHuyDuyet.Enabled = false;
            btnPheDuyet.Enabled = false;
            btnTrinhDuyet.Visible = true;
            btnPheDuyet.Visible = true;
            btnHuyDuyet.Visible = true;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucTextBox1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucTextBox1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void frmDM_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataMap();
            InitCellStyle();
            LoadFg();
        }
        private void LoadDataMap()
        {
            /*
                - ComboLoaderHelper.LoadDataMap để tạo ComboBox đổ xuống cho cột của ucGridView.
                - ComboLoaderHelper.LoadDataMap dựa vào DataTable để tạo ComboBox.
             */

            DataTable dtTrangThai = new DataTable();

            // Tạo 2 cột
            dtTrangThai.Columns.Add("TrangThai", typeof(int));
            dtTrangThai.Columns.Add("TenTrangThai", typeof(string));

            // Thêm 5 dòng dữ liệu
            dtTrangThai.Rows.Add(DM_KhachHang_Test_TrangThai.DangLap, "Đang lập");
            dtTrangThai.Rows.Add(DM_KhachHang_Test_TrangThai.TrinhDuyet, "Trình duyệt");
            dtTrangThai.Rows.Add(DM_KhachHang_Test_TrangThai.PheDuyet, "Phê duyệt");
            dtTrangThai.Rows.Add(DM_KhachHang_Test_TrangThai.HuyDuyet, "Hủy duyệt");

            ComboLoaderHelper.LoadDataMap(fg, dtTrangThai, "TrangThai", "TenTrangThai", "Trạng thái", TextAlignEnum.LeftCenter);

            var clsLoaiKH = new clsDM_LoaiKhachHang();
            DataTable dtLoaiKH = clsLoaiKH.SelectAll();

            ComboLoaderHelper.LoadDataMap(fg, dtLoaiKH, "ID_LoaiKhachHang", "TenLoaiKhachHang", "Loại khách hàng", TextAlignEnum.LeftCenter);
        }
        private void InitCellStyle()
        {
            csDangLap = fg.Styles.Add("DangLap");
            csTrinhDuyet = fg.Styles.Add("TrinhDuyet");
            csHuyDuyet = fg.Styles.Add("HuyDuyet");
            csPheDuyet = fg.Styles.Add("PheDuyet");

            csDangLap.ForeColor = GlobalVariables.Mau_DangLap_ForeColor;
            csDangLap.BackColor = GlobalVariables.Mau_DangLap_BackColor;

            csTrinhDuyet.ForeColor = GlobalVariables.Mau_TrinhDuyet_ForeColor;
            csTrinhDuyet.BackColor = GlobalVariables.Mau_TrinhDuyet_BackColor;

            csHuyDuyet.ForeColor = GlobalVariables.Mau_HuyPheDuyet1_ForeColor;
            csHuyDuyet.BackColor = GlobalVariables.Mau_HuyPheDuyet1_BackColor;

            csPheDuyet.ForeColor = GlobalVariables.Mau_PheDuyet1_ForeColor;
            csPheDuyet.BackColor = GlobalVariables.Mau_PheDuyet1_BackColor;
        }

        private void LoadFg()
        {
            fg.Tag = 0; //Đánh dấu grid load hết dữ liệu
            fg.BeginUpdate(); //Khởi động giao diện phù hợp update dữ liệu

            var oKH = new clsDM_KhachHang_Test();
            DataTable dt = oKH.SelectDanhSachKhachHang();

            //Thiết lập show ra/ ẩn lại nhóm dòng
            fg.Tree.Column = fg.Cols["ID_LoaiKhachHang"].Index;

            //dt.DefaultView.RowFilter = "IsTonTai = 'True' AND IsSuDung = 'True'";
            //dt.DefaultView.Sort = "ID_LoaiKhachHang ASC";

            dt = dt.DefaultView.ToTable();//Dữ liệu cần hiển thị

            fg.SetDataSource(dt);

            /*
            - Subtotal để tạo row IsNode = true.
            - Row IsNode là row để nhóm các row có cùng giá trị của 1 thuộc tính nào đó.
            - Subtotal hoạt động hợp lý khi đã nhóm sẵn trước đó các row có cùng giá trị của thuộc tính chỉ định
             */
            fg.Subtotal(AggregateEnum.None, 0, fg.Cols["ID_LoaiKhachHang"].Index, 0);

            m_oFilter.SetDataSource(dt);
            m_oFilter.Load_AllCombo();
            m_oFilter.FilterGrid();

            FormatFg();

            /*
             - Hàm AddSummaryRow để tính tổng giá trị của cột nào đó
             */

            fg.AddSummaryRow(VSCM.Base.Controls.ucFlexGrid.FgRowSummaryPosition.Top, "ID_LoaiKhachHang",new List<string>());

            fg.Row = -1; //trỏ đến hàng trong lưới
            fg.AutoSizeRows();
            fg.EndUpdate(); //kết thúc giao diện phù hợp update dữ liệu
            fg.SetSTT(true);
            fg.Tag = 1;
        }

        private void FormatFg()
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.Rows[i].IsNode) continue;

                try
                {
                    DM_KhachHang_Test_TrangThai oTrangThai = (DM_KhachHang_Test_TrangThai)byte.Parse(fg[i, "TrangThai"].ToString());

                    switch (oTrangThai)
                    {
                        case DM_KhachHang_Test_TrangThai.DangLap:
                            fg.Rows[i].Style = csDangLap;
                            break;
                        case DM_KhachHang_Test_TrangThai.TrinhDuyet:
                            fg.Rows[i].Style = csTrinhDuyet;
                            break;
                        case DM_KhachHang_Test_TrangThai.HuyDuyet:
                            fg.Rows[i].Style = csHuyDuyet;
                            break;
                        case DM_KhachHang_Test_TrangThai.PheDuyet:
                            fg.Rows[i].Style = csPheDuyet;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {}
            }
        }

        private void ucLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fg.AllowEditing = true;
            fg.AllowDelete = true;
            tsThemDong.Enabled = true;
            tsXoaDong.Enabled = true;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnSua.Visible = false;
            btnTrinhDuyet.Visible = false;
            btnPheDuyet.Visible = false;
            btnHuyDuyet.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowQuestionMessage("Bạn có chắc chắn muốn hủy không?") == DialogResult.Yes)
            {
                HandleHoanThanhHoacHuyUpdate();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dt = fg.ToDataTable(false, VSCM.Base.Controls.ucFlexGrid.ToDatatableValue.Value);

            DataRow[] editRows = dt.Select("IsEdit = 1");
            if (editRows.Count() > 0)
            {
                dt = editRows.CopyToDataTable();

                if (!Validate())
                {
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    int id_KhachHang = int.Parse(row["ID_KhachHang"].ToString());
                    byte id_LoaiKhachHang = Byte.Parse(row["ID_LoaiKhachHang"].ToString());
                    string tenKhachHang = row["TenKhachHang"].ToString();
                    byte trangThai = Byte.Parse(row["TrangThai"].ToString());
                    bool isSuDung = Boolean.Parse(row["IsSuDung"].ToString());

                    if (id_KhachHang == 0)
                    {
                        clsDM_KhachHang_Test cls = new clsDM_KhachHang_Test();
                        cls.ID_LoaiKhachHang = id_LoaiKhachHang;
                        cls.TenKhachHang = tenKhachHang;
                        cls.TrangThai = (byte)DM_KhachHang_Test_TrangThai.DangLap;
                        cls.IsSuDung = isSuDung;
                        cls.InsertKhachHang();
                    }
                    else
                    {
                        clsDM_KhachHang_Test cls = new clsDM_KhachHang_Test();
                        cls.ID_KhachHang = id_KhachHang;
                        cls.ID_LoaiKhachHang = id_LoaiKhachHang;
                        cls.TenKhachHang = tenKhachHang;
                        cls.IsSuDung = isSuDung;
                        cls.IsTonTai = true;
                        cls.UpdateKhachHang();
                    }
                }
            }


            DataRow[] deleteRows = dt.Select("IsEdit = 2");
            if (deleteRows.Count() > 0)
            {
                dt = deleteRows.CopyToDataTable();

                foreach (DataRow row in dt.Rows)
                {
                    int id_KhachHang = int.Parse(row["ID_KhachHang"].ToString());

                    if (id_KhachHang > 0)
                    {
                        clsDM_KhachHang_Test cls = new clsDM_KhachHang_Test();
                        cls.ID_KhachHang = id_KhachHang;
                        cls.SoftDelete();
                    }
                }
            }

            HandleHoanThanhHoacHuyUpdate();
        }

        private bool Validate()
        {
            List<string> listTenKhachHangs = new List<string>();

            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                Row currentRow = fg.Rows[i];
                if (currentRow.IsNode) continue;

                //string tenKhachHang = fg[i, "TenKhachHang"]?.ToString().Trim();
                string tenKhachHang = currentRow["TenKhachHang"]?.ToString().Trim();
                string id_LoaiKhachHang = currentRow["ID_LoaiKhachHang"]?.ToString().Trim();

                if (string.IsNullOrEmpty(id_LoaiKhachHang))
                {
                    MessageBox.Show($"Loại khách hàng ở dòng {currentRow["STT"].ToString()} chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                if (string.IsNullOrEmpty(tenKhachHang))
                {
                    MessageBox.Show($"Tên khách hàng ở dòng {currentRow["STT"].ToString()} chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (listTenKhachHangs.Any((tkh) => tkh == tenKhachHang))
                {
                    MessageBox.Show($"Tên khách hàng ở dòng {currentRow["STT"].ToString()} bị trùng với dòng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                listTenKhachHangs.Add(tenKhachHang);
            }
            return true;
        }

        private void SetTrangThaiKhachHang(DM_KhachHang_Test_TrangThai trangThai)
        {
            CellRange cellRangeSelected = fg.Selection;

            if (cellRangeSelected.TopRow != -1 && cellRangeSelected.TopRow == cellRangeSelected.BottomRow)
            {
                if (!string.IsNullOrEmpty(fg.GetDataDisplay(cellRangeSelected.TopRow, "ID_KhachHang")) && fg.GetIntValue(cellRangeSelected.TopRow, "ID_KhachHang") > 0)
                {
                    clsDM_KhachHang_Test cls = new clsDM_KhachHang_Test();
                    cls.ID_KhachHang = fg.GetIntValue(cellRangeSelected.TopRow, "ID_KhachHang");
                    cls.TrangThai = (Byte)trangThai;
                    cls.SetTrangThaiKhachHang();
                    LoadFg();
                    fg.Select(cellRangeSelected.TopRow, fg.Cols["TrangThai"].Index);
                    SetButtonTrangThai();
                } 
            }
        }

        private void HandleDeleteKhachHang(DataTable dt)
        {

        }

        private void HandleHoanThanhHoacHuyUpdate()
        {
            SetButtonDefault();
            LoadFg();
        }


        private void fg_AfterEdit(object sender, RowColEventArgs e)
        {
            fg[e.Row, "IsEdit"] = 1;
        }

        private void fg_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void ctxMenu_fg_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void themDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_modeUpdate)
            {
                Row newRow = fg.Rows.Add();
                fg.Row = fg.Rows.Count - 1;
                fg.Col = 1;
                fg[newRow.Index, "IsSuDung"] = true;
                fg[newRow.Index, "IsEdit"] = 1;
                fg[newRow.Index, "ID_KhachHang"] = 0;
                fg[newRow.Index, "TrangThai"] = (byte) DM_KhachHang_Test_TrangThai.DangLap;
                fg.SetSTT();
            }
        }

        private void xoaDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_modeUpdate)
            {
                CellRange cellRangeSelected = fg.Selection;

                if (cellRangeSelected.TopRow == -1)
                {
                    fg.Rows.Remove(fg.Rows.Count - 1);
                }else
                {
                    for (int i = cellRangeSelected.TopRow; i <= cellRangeSelected.BottomRow; i ++)
                    {
                        Row rowRemove = fg.Rows[i];
                        if (rowRemove.IsNode) continue;

                        if (string.IsNullOrEmpty(fg.GetDataDisplay(i, "ID_KhachHang")) || fg.GetIntValue(i, "ID_KhachHang") == 0)
                        {
                            fg.Rows.Remove(i);
                        }else
                        {
                            if (fg.GetIntValue(i, "ID_KhachHang") > 0)
                            {
                                fg.Rows[i].Visible = false;
                                fg[i, "IsEdit"] = 2;
                            }
                        }
                    }
                }
            }
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            LoadFg();
        }

        private void fg_StartEdit(object sender, RowColEventArgs e)
        {
            if(fg.GetIntValue(e.Row,"ID_KhachHang") == 1)
            {
                //MessageBox.Show("Không được nhập!");
                //e.Cancel = true;
            }
        }


        private void tsmChiTiet_Click(object sender, EventArgs e)
        {
            var frm = new frmDM_KhachHang_Test();
            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnTrinhDuyet_Click(object sender, EventArgs e)
        {
            SetTrangThaiKhachHang(DM_KhachHang_Test_TrangThai.TrinhDuyet);
        }

        private void btnHuyDuyet_Click(object sender, EventArgs e)
        {
            SetTrangThaiKhachHang(DM_KhachHang_Test_TrangThai.HuyDuyet);
        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            SetTrangThaiKhachHang(DM_KhachHang_Test_TrangThai.PheDuyet);
        }

        private void cmbLoaiKhachHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fg_Click(object sender, EventArgs e)
        {
            SetButtonTrangThai();
        }

        private void SetButtonTrangThai()
        {
            Action disabledButtonTrangThai = () =>
            {
                btnTrinhDuyet.Enabled = false;
                btnPheDuyet.Enabled = false;
                btnHuyDuyet.Enabled = false;
            };
            CellRange cellRangeSelected = fg.Selection;

            if (cellRangeSelected.TopRow != -1 && cellRangeSelected.TopRow == cellRangeSelected.BottomRow)
            {
                Row rowSelected = fg.Rows[cellRangeSelected.TopRow];
                if (rowSelected.IsNode)
                {
                    disabledButtonTrangThai();
                    return;
                }

                try
                {
                    DM_KhachHang_Test_TrangThai trangThai = (DM_KhachHang_Test_TrangThai)byte.Parse(fg[cellRangeSelected.TopRow, "TrangThai"].ToString());

                    switch (trangThai)
                    {
                        case DM_KhachHang_Test_TrangThai.DangLap:
                        case DM_KhachHang_Test_TrangThai.HuyDuyet:
                            btnTrinhDuyet.Enabled = true;
                            btnPheDuyet.Enabled = false;
                            btnHuyDuyet.Enabled = false;
                            break;
                        case DM_KhachHang_Test_TrangThai.TrinhDuyet:
                            btnTrinhDuyet.Enabled = false;
                            btnPheDuyet.Enabled = true;
                            btnHuyDuyet.Enabled = false;
                            break;
                        case DM_KhachHang_Test_TrangThai.PheDuyet:
                            btnTrinhDuyet.Enabled = false;
                            btnPheDuyet.Enabled = false;
                            btnHuyDuyet.Enabled = true;
                            break;
                    }
                }
                catch
                {
                    return;
                }

            }
            else
            {
                disabledButtonTrangThai();
            }
        }

        private void ucTextBox1_EditValueChanged_2(object sender, EventArgs e)
        {

        }
    }

    public enum DM_KhachHang_Test_TrangThai : byte
    {
        DangLap = 1,
        TrinhDuyet = 2,
        HuyDuyet = 3,
        PheDuyet = 4,
    }
}
