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

namespace GMS.QLKH
{
    public partial class frmDM_KhachHang_Test : FormBase
    {
        #region Variables
        private int m_iID_KhachHang;
        #endregion

        #region Constructor
        public frmDM_KhachHang_Test(int id_KhachHang = 0)
        {
            InitializeComponent();
            m_iID_KhachHang = id_KhachHang;
        }

        #endregion

        #region Functions

        #endregion

        #region Events

        #endregion

        private void TenKhachHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucButton2_Click(object sender, EventArgs e)
        {

        }

        private void frmDM_KhachHang_Test__Load(object sender, EventArgs e)
        {
            LoadAllCombos();
            if (m_iID_KhachHang > 0) //Sửa
            {

            }else //Thêm mới
            {
                LockControl(false);
            }
        }

        private void LoadAllCombos()
        {
            cmbLoaiKhachHang.Tag = 0;
            var oLoaiKH = new clsDM_LoaiKhachHang();
            cmbLoaiKhachHang.Properties.DataSource = oLoaiKH.SelectAll();

            cmbLoaiKhachHang.Tag = 1;
        }

        private void LockControl(bool isLock)
        {
            btnCapNhat.Visible = isLock;
            btnXoa.Visible = isLock;
            btnXacNhan.Visible = isLock;
            btnHuyXacNhan.Visible = isLock;

            btnLuu.Visible = !isLock;
            btnHuy.Visible = !isLock;
        }
    }
}
