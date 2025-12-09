using C1.Win.C1FlexGrid;
using GMS.QLKH.Helpers;
using GMS_Test;
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
    public partial class frmDM_Thung : FormBase
    {
        private FlexGridFilterManager m_oFilter;
        public frmDM_Thung()
        {
            InitializeComponent();

            m_oFilter = new FlexGridFilterManager(fg);
            m_oFilter.AddFilterControl(cmbKho);

            LockControl();
        }

        private void LockControl()
        {
            fg.AllowEditing = false;
            fg.AllowDelete = false;
            btnCapNhat.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            tsmThemDong.Enabled = false;
            tsmXoaDong.Enabled = false;
        }

        private void frmDM_Thung_Test_Main_Load(object sender, EventArgs e)
        {
            LoadDataMap();
            LoadFg();
        }

        private void LoadDataMap()
        {
            clsDM_Kho cls = new clsDM_Kho();
            DataTable dt = cls.SelectAll_Kho();
            ComboLoaderHelper.LoadDataMap(fg, dt, "ID_Kho", "TenKho", "Tên kho", TextAlignEnum.LeftCenter);
        }

        private void LoadFg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();

            clsDM_Thung cls = new clsDM_Thung();
            DataTable dt = cls.SelectAll_Thung();
            dt = dt.DefaultView.ToTable();
            fg.SetDataSource(dt);

            m_oFilter.SetDataSource(dt);
            m_oFilter.Load_AllCombo();
            m_oFilter.FilterGrid();
            

            fg.Row = -1; //trỏ đến hàng trong lưới
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.SetSTT();
            fg.Tag = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fg.AllowEditing = true;
            fg.AllowDelete = true;
            btnCapNhat.Visible = false;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            tsmThemDong.Enabled = true;
            tsmXoaDong.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowQuestionMessage("Bạn có chắc chắn hủy các thay đổi?") == DialogResult.Yes)
            {
                DataTable dt = fg.ToDataTable(false, VSCM.Base.Controls.ucFlexGrid.ToDatatableValue.Value);

                DataRow[] editRows = dt.Select("IsEdit = 1");
                DataRow[] deleteRows = dt.Select("IsEdit = 2");

                if (editRows.Count() + deleteRows.Count() > 0)
                {
                    AfterLuuHoacHuy(true);
                }
                else
                {
                    AfterLuuHoacHuy(false);
                }
            }
        }
        
        private void AfterLuuHoacHuy(bool reloadFg = true)
        {
            LockControl();

            if (reloadFg)
            {
                LoadFg();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable dt = fg.ToDataTable(false, VSCM.Base.Controls.ucFlexGrid.ToDatatableValue.Value);

            DataRow[] editRows = dt.Select("IsEdit = 1");

            if (editRows.Count() > 0)
            {
                if (!Validate())
                {
                    return;
                }
            }

            DataRow[] deleteRows = dt.Select("IsEdit = 2");

            List<DataRow> editOrDeleteRows = new List<DataRow>();
            editOrDeleteRows.AddRange(editRows);
            editOrDeleteRows.AddRange(deleteRows);

            bool reloadFg = false;

            if (editOrDeleteRows.Count > 0) reloadFg = true;

            foreach (DataRow row in editOrDeleteRows)
            {
                int id_Thung = int.Parse(row["ID_Thung"].ToString());
                string tenThung = row["TenThung"].ToString();
                int id_Kho = 0;
                string strIdKho = row["ID_Kho"].ToString();
                if (!string.IsNullOrEmpty(strIdKho)) 
                {
                    id_Kho = int.Parse(strIdKho);
                }
                bool isSuDung = Boolean.Parse(row["IsSuDung"].ToString());
                int isEdit = int.Parse(row["IsEdit"].ToString());
                string maThung = row["MaThung"]?.ToString();
                DateTime ngayNhap = DateTime.Now;
                string strNgayNhap = row["NgayNhap"].ToString();
                if (!string.IsNullOrEmpty(strNgayNhap))
                {
                    ngayNhap = DateTime.Parse(strNgayNhap);
                }

                clsDM_Thung cls = new clsDM_Thung();
                cls.TenThung = tenThung;
                cls.MaThung = maThung;
                cls.ID_Kho = id_Kho;
                cls.IsSuDung = isSuDung;
                cls.NgayNhap = ngayNhap;

                if (isEdit == 1)
                {
                    cls.IsTonTai = true;
                    if (id_Thung == 0)
                    {
                        cls.Insert_Thung();
                    }
                    else
                    {
                        cls.ID_Thung = id_Thung;
                        cls.NgaySuaCuoi = DateTime.Now;
                        cls.Update_Thung();
                    }
                }else if (isEdit == 2)
                {
                    cls.ID_Thung = id_Thung;
                    cls.NgaySuaCuoi = DateTime.Now;
                    cls.IsTonTai = false;
                    cls.Update_Thung();
                }
            }
            AfterLuuHoacHuy(reloadFg);
        }

        private bool Validate()
        {
            foreach (Row row in fg.Rows)
            {
                if (row["IsEdit"] == null) continue;

                string tenThung = row["TenThung"]?.ToString().Trim();
                string strId_Kho = row["ID_Kho"]?.ToString().Trim();

                if (string.IsNullOrEmpty(tenThung))
                {
                    BaseMessages.ShowWarningMessage($"Dòng thứ {row.Index + 1} chưa nhập tên");
                    return false;
                }

                if (string.IsNullOrEmpty(strId_Kho))
                {
                    BaseMessages.ShowWarningMessage($"Dòng thứ {row.Index + 1} chưa nhập kho");
                    return false;
                }
            }
            return true;
        }

        private void fg_AfterEdit(object sender, RowColEventArgs e)
        {
            fg[e.Row, "IsEdit"] = 1;
        }

        private void tsmThemDong_Click(object sender, EventArgs e)
        {
            Row newRow = fg.Rows.Add();
            newRow["IsEdit"] = 1;
            newRow["ID_Thung"] = 0;
            newRow["IsSuDung"] = true;
            fg.SetSTT();
        }

        private void tsmXoaDong_Click(object sender, EventArgs e)
        {
            CellRange cellRangeSelected = fg.Selection;

            List<Row> removeRows = new List<Row>();

            for (int i = cellRangeSelected.TopRow; i <= cellRangeSelected.BottomRow; i++)
            {
                Row rowSelected = fg.Rows[i];
                if (rowSelected.IsNode) continue;

                int id_Thung = (int)rowSelected["ID_Thung"];

                if (id_Thung == 0)
                {
                    removeRows.Add(rowSelected);
                }
                else
                {
                    rowSelected.Visible = false;
                    rowSelected["IsEdit"] = 2;
                }
            }

            foreach (Row removeRow in removeRows)
            {
                fg.Rows.Remove(removeRow);
            }
        }

        private void cmbKho_EditValueChanged(object sender, EventArgs e)
        {
        }
    }
}
