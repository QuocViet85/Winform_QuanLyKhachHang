
namespace GMS.QLKH
{
    partial class frmDM_KhachHang_Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_KhachHang_Test));
            this.TenKhachHang = new VSCM.Base.Controls.ucTextBox();
            this.cmbLoaiKhachHang = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.btnCapNhat = new VSCM.Base.Controls.ucButton();
            this.btnXoa = new VSCM.Base.Controls.ucButton();
            this.btnXacNhan = new VSCM.Base.Controls.ucButton();
            this.btnHuyXacNhan = new VSCM.Base.Controls.ucButton();
            this.lbLoaiKhachHang = new VSCM.Base.Controls.ucLabel();
            this.lbTenKhachHang = new VSCM.Base.Controls.ucLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.SuspendLayout();
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.FieldGroup = "";
            this.TenKhachHang.FieldName = "TenKhachHang";
            this.TenKhachHang.Location = new System.Drawing.Point(2, 34);
            this.TenKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.TenKhachHang.Properties.Appearance.Options.UseBackColor = true;
            this.TenKhachHang.Properties.AutoHeight = false;
            this.TenKhachHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.TenKhachHang.Properties.EditValueChangedDelay = 500;
            this.TenKhachHang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.TenKhachHang.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.TenKhachHang.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TenKhachHang.Properties.Name = "fProperties";
            this.TenKhachHang.Properties.Tag = "TenKhachHang";
            this.TenKhachHang.Size = new System.Drawing.Size(186, 29);
            this.TenKhachHang.TabIndex = 9;
            this.TenKhachHang.EditValueChanged += new System.EventHandler(this.TenKhachHang_EditValueChanged);
            // 
            // cmbLoaiKhachHang
            // 
            this.cmbLoaiKhachHang.FieldGroup = "";
            this.cmbLoaiKhachHang.FieldName = "";
            this.cmbLoaiKhachHang.Location = new System.Drawing.Point(192, 34);
            this.cmbLoaiKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLoaiKhachHang.Name = "cmbLoaiKhachHang";
            this.cmbLoaiKhachHang.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLoaiKhachHang.Properties.Appearance.Options.UseBackColor = true;
            this.cmbLoaiKhachHang.Properties.AutoHeight = false;
            this.cmbLoaiKhachHang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbLoaiKhachHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cmbLoaiKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoaiKhachHang.Properties.DisplayMember = "TenLoaiKhachHang";
            this.cmbLoaiKhachHang.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbLoaiKhachHang.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbLoaiKhachHang.Properties.NullText = "";
            this.cmbLoaiKhachHang.Properties.PopupView = this.ucSearchLookupEdit1View;
            this.cmbLoaiKhachHang.Properties.ValueMember = "ID_LoaiKhachHang";
            this.cmbLoaiKhachHang.Size = new System.Drawing.Size(188, 28);
            this.cmbLoaiKhachHang.TabIndex = 7;
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ucSearchLookupEdit1View.DetailHeight = 418;
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_LoaiKhachHang";
            this.gridColumn1.FieldName = "ID_LoaiKhachHang";
            this.gridColumn1.MinWidth = 15;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 56;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.CustomizationCaption = "Tên";
            this.gridColumn2.FieldName = "TenLoaiKhachHang";
            this.gridColumn2.MinWidth = 15;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 56;
            // 
            // fg
            // 
            this.fg.AllowFiltering = true;
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = "1,0,0,0,0,115,Columns:0{ShowSparkline:False;}\t";
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(2, 67);
            this.fg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 23;
            this.fg.Rows.MinSize = 20;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fg.ShowCellLabels = true;
            this.fg.Size = new System.Drawing.Size(690, 350);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(2, 422);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 25);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "&Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(97, 422);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 25);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "&Hủy";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 422);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(88, 25);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.ucButton2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(97, 422);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 25);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "&Xóa";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Appearance.Options.UseFont = true;
            this.btnXacNhan.Location = new System.Drawing.Point(191, 422);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(88, 25);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "&Xác nhận";
            // 
            // btnHuyXacNhan
            // 
            this.btnHuyXacNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyXacNhan.Appearance.Options.UseFont = true;
            this.btnHuyXacNhan.Location = new System.Drawing.Point(286, 422);
            this.btnHuyXacNhan.Name = "btnHuyXacNhan";
            this.btnHuyXacNhan.Size = new System.Drawing.Size(88, 25);
            this.btnHuyXacNhan.TabIndex = 16;
            this.btnHuyXacNhan.Text = "&Hủy XN";
            // 
            // lbLoaiKhachHang
            // 
            this.lbLoaiKhachHang.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbLoaiKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKhachHang.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLoaiKhachHang.Appearance.Options.UseBackColor = true;
            this.lbLoaiKhachHang.Appearance.Options.UseFont = true;
            this.lbLoaiKhachHang.Appearance.Options.UseForeColor = true;
            this.lbLoaiKhachHang.FieldGroup = "";
            this.lbLoaiKhachHang.FieldName = "";
            this.lbLoaiKhachHang.Location = new System.Drawing.Point(192, 5);
            this.lbLoaiKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbLoaiKhachHang.Name = "lbLoaiKhachHang";
            this.lbLoaiKhachHang.Padding = new System.Windows.Forms.Padding(38, 4, 38, 4);
            this.lbLoaiKhachHang.Size = new System.Drawing.Size(188, 25);
            this.lbLoaiKhachHang.TabIndex = 20;
            this.lbLoaiKhachHang.Text = "Loại khách hàng";
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbTenKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHang.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTenKhachHang.Appearance.Options.UseBackColor = true;
            this.lbTenKhachHang.Appearance.Options.UseFont = true;
            this.lbTenKhachHang.Appearance.Options.UseForeColor = true;
            this.lbTenKhachHang.FieldGroup = "";
            this.lbTenKhachHang.FieldName = "";
            this.lbTenKhachHang.Location = new System.Drawing.Point(2, 5);
            this.lbTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Padding = new System.Windows.Forms.Padding(38, 4, 38, 4);
            this.lbTenKhachHang.Size = new System.Drawing.Size(186, 25);
            this.lbTenKhachHang.TabIndex = 19;
            this.lbTenKhachHang.Text = "Tên khách hàng";
            // 
            // frmDM_KhachHang_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.lbLoaiKhachHang);
            this.Controls.Add(this.lbTenKhachHang);
            this.Controls.Add(this.btnHuyXacNhan);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.fg);
            this.Controls.Add(this.TenKhachHang);
            this.Controls.Add(this.cmbLoaiKhachHang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDM_KhachHang_Test";
            this.Text = "Khách hàng chi tiết";
            this.Load += new System.EventHandler(this.frmDM_KhachHang_Test__Load);
            ((System.ComponentModel.ISupportInitialize)(this.TenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucTextBox TenKhachHang;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbLoaiKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnHuy;
        private VSCM.Base.Controls.ucButton btnCapNhat;
        private VSCM.Base.Controls.ucButton btnXoa;
        private VSCM.Base.Controls.ucButton btnXacNhan;
        private VSCM.Base.Controls.ucButton btnHuyXacNhan;
        private VSCM.Base.Controls.ucLabel lbLoaiKhachHang;
        private VSCM.Base.Controls.ucLabel lbTenKhachHang;
    }
}