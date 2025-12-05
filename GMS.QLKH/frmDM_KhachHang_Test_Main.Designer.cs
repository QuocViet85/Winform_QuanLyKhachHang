
namespace GMS.QLKH
{
    partial class frmDM_KhachHang_Test_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_KhachHang_Test_Main));
            this.lbTenKhachHang = new VSCM.Base.Controls.ucTextBox();
            this.cmbLoaiKhachHang = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.ctxMenu_fg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsThemDong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXoaDong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.lbLoaiKhachHang = new VSCM.Base.Controls.ucTextBox();
            this.TenKhachHang = new VSCM.Base.Controls.ucTextBox();
            this.btnSua = new VSCM.Base.Controls.ucButton();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.btnTrinhDuyet = new VSCM.Base.Controls.ucButton();
            this.btnHuyDuyet = new VSCM.Base.Controls.ucButton();
            this.btnPheDuyet = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.lbTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.ctxMenu_fg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbLoaiKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTenKhachHang.EditValue = "Tên khách hàng";
            this.lbTenKhachHang.FieldGroup = "";
            this.lbTenKhachHang.FieldName = "";
            this.lbTenKhachHang.Location = new System.Drawing.Point(8, -1);
            this.lbTenKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Properties.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbTenKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbTenKhachHang.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lbTenKhachHang.Properties.Appearance.Options.UseBackColor = true;
            this.lbTenKhachHang.Properties.Appearance.Options.UseFont = true;
            this.lbTenKhachHang.Properties.Appearance.Options.UseForeColor = true;
            this.lbTenKhachHang.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.lbTenKhachHang.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbTenKhachHang.Properties.AutoHeight = false;
            this.lbTenKhachHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lbTenKhachHang.Properties.EditValueChangedDelay = 500;
            this.lbTenKhachHang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lbTenKhachHang.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.lbTenKhachHang.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbTenKhachHang.Properties.Name = "fProperties";
            this.lbTenKhachHang.Properties.ReadOnly = true;
            this.lbTenKhachHang.Size = new System.Drawing.Size(188, 44);
            this.lbTenKhachHang.TabIndex = 0;
            this.lbTenKhachHang.EditValueChanged += new System.EventHandler(this.ucTextBox1_EditValueChanged_1);
            // 
            // cmbLoaiKhachHang
            // 
            this.cmbLoaiKhachHang.FieldGroup = "";
            this.cmbLoaiKhachHang.FieldName = "";
            this.cmbLoaiKhachHang.Location = new System.Drawing.Point(196, 44);
            this.cmbLoaiKhachHang.Margin = new System.Windows.Forms.Padding(5);
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
            this.cmbLoaiKhachHang.Size = new System.Drawing.Size(188, 37);
            this.cmbLoaiKhachHang.TabIndex = 1;
            this.cmbLoaiKhachHang.EditValueChanged += new System.EventHandler(this.cmbLoaiKhachHang_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ucSearchLookupEdit1View.DetailHeight = 547;
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_LoaiKhachHang";
            this.gridColumn1.FieldName = "ID_LoaiKhachHang";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.CustomizationCaption = "Tên";
            this.gridColumn2.FieldName = "TenLoaiKhachHang";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // fg
            // 
            this.fg.AllowFiltering = true;
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.ContextMenuStrip = this.ctxMenu_fg;
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(8, 93);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 23;
            this.fg.Rows.MinSize = 20;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fg.ShowCellLabels = true;
            this.fg.Size = new System.Drawing.Size(1248, 527);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 2;
            this.fg.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fg_AfterEdit);
            this.fg.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fg_StartEdit);
            this.fg.Click += new System.EventHandler(this.fg_Click);
            this.fg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fg_KeyDown);
            // 
            // ctxMenu_fg
            // 
            this.ctxMenu_fg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu_fg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThemDong,
            this.tsXoaDong,
            this.menuRefresh});
            this.ctxMenu_fg.Name = "ctxMenu_fg";
            this.ctxMenu_fg.Size = new System.Drawing.Size(275, 256);
            this.ctxMenu_fg.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenu_fg_Opening);
            // 
            // tsThemDong
            // 
            this.tsThemDong.Name = "tsThemDong";
            this.tsThemDong.Size = new System.Drawing.Size(274, 24);
            this.tsThemDong.Text = "Thêm dòng";
            this.tsThemDong.Click += new System.EventHandler(this.themDongToolStripMenuItem_Click);
            // 
            // tsXoaDong
            // 
            this.tsXoaDong.Name = "tsXoaDong";
            this.tsXoaDong.Size = new System.Drawing.Size(274, 24);
            this.tsXoaDong.Text = "Xóa dòng";
            this.tsXoaDong.Click += new System.EventHandler(this.xoaDongToolStripMenuItem_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(274, 24);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // lbLoaiKhachHang
            // 
            this.lbLoaiKhachHang.EditValue = "Loại khách hàng";
            this.lbLoaiKhachHang.FieldGroup = "";
            this.lbLoaiKhachHang.FieldName = "";
            this.lbLoaiKhachHang.Location = new System.Drawing.Point(196, 0);
            this.lbLoaiKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.lbLoaiKhachHang.Name = "lbLoaiKhachHang";
            this.lbLoaiKhachHang.Properties.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbLoaiKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbLoaiKhachHang.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.lbLoaiKhachHang.Properties.Appearance.Options.UseBackColor = true;
            this.lbLoaiKhachHang.Properties.Appearance.Options.UseFont = true;
            this.lbLoaiKhachHang.Properties.Appearance.Options.UseForeColor = true;
            this.lbLoaiKhachHang.Properties.Appearance.Options.UseTextOptions = true;
            this.lbLoaiKhachHang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbLoaiKhachHang.Properties.AutoHeight = false;
            this.lbLoaiKhachHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lbLoaiKhachHang.Properties.EditValueChangedDelay = 500;
            this.lbLoaiKhachHang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lbLoaiKhachHang.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.lbLoaiKhachHang.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lbLoaiKhachHang.Properties.Name = "fProperties";
            this.lbLoaiKhachHang.Properties.ReadOnly = true;
            this.lbLoaiKhachHang.Size = new System.Drawing.Size(188, 43);
            this.lbLoaiKhachHang.TabIndex = 4;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.FieldGroup = "";
            this.TenKhachHang.FieldName = "TenKhachHang";
            this.TenKhachHang.Location = new System.Drawing.Point(8, 43);
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
            this.TenKhachHang.Size = new System.Drawing.Size(188, 37);
            this.TenKhachHang.TabIndex = 5;
            this.TenKhachHang.EditValueChanged += new System.EventHandler(this.ucTextBox1_EditValueChanged_2);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Location = new System.Drawing.Point(11, 626);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "&Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(12, 626);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(117, 626);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTrinhDuyet
            // 
            this.btnTrinhDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrinhDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrinhDuyet.Appearance.Options.UseFont = true;
            this.btnTrinhDuyet.Location = new System.Drawing.Point(299, 626);
            this.btnTrinhDuyet.Name = "btnTrinhDuyet";
            this.btnTrinhDuyet.Size = new System.Drawing.Size(111, 35);
            this.btnTrinhDuyet.TabIndex = 10;
            this.btnTrinhDuyet.Text = "&Trình phê duyệt";
            this.btnTrinhDuyet.Click += new System.EventHandler(this.btnTrinhDuyet_Click);
            // 
            // btnHuyDuyet
            // 
            this.btnHuyDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDuyet.Appearance.Options.UseFont = true;
            this.btnHuyDuyet.Location = new System.Drawing.Point(522, 626);
            this.btnHuyDuyet.Name = "btnHuyDuyet";
            this.btnHuyDuyet.Size = new System.Drawing.Size(109, 35);
            this.btnHuyDuyet.TabIndex = 11;
            this.btnHuyDuyet.Text = "&Hủy phê duyệt";
            this.btnHuyDuyet.Click += new System.EventHandler(this.btnHuyDuyet_Click);
            // 
            // btnPheDuyet
            // 
            this.btnPheDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPheDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPheDuyet.Appearance.Options.UseFont = true;
            this.btnPheDuyet.Location = new System.Drawing.Point(416, 626);
            this.btnPheDuyet.Name = "btnPheDuyet";
            this.btnPheDuyet.Size = new System.Drawing.Size(100, 35);
            this.btnPheDuyet.TabIndex = 12;
            this.btnPheDuyet.Text = "&Phê duyệt";
            this.btnPheDuyet.Click += new System.EventHandler(this.btnPheDuyet_Click);
            // 
            // frmDM_KhachHang_Test_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 676);
            this.Controls.Add(this.btnPheDuyet);
            this.Controls.Add(this.btnHuyDuyet);
            this.Controls.Add(this.btnTrinhDuyet);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.TenKhachHang);
            this.Controls.Add(this.lbLoaiKhachHang);
            this.Controls.Add(this.fg);
            this.Controls.Add(this.cmbLoaiKhachHang);
            this.Controls.Add(this.lbTenKhachHang);
            this.Name = "frmDM_KhachHang_Test_Main";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.frmDM_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ctxMenu_fg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbLoaiKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucTextBox lbTenKhachHang;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbLoaiKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucTextBox lbLoaiKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private VSCM.Base.Controls.ucTextBox TenKhachHang;
        private VSCM.Base.Controls.ucButton btnSua;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnHuy;
        private System.Windows.Forms.ContextMenuStrip ctxMenu_fg;
        private System.Windows.Forms.ToolStripMenuItem tsThemDong;
        private System.Windows.Forms.ToolStripMenuItem tsXoaDong;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private VSCM.Base.Controls.ucButton btnTrinhDuyet;
        private VSCM.Base.Controls.ucButton btnHuyDuyet;
        private VSCM.Base.Controls.ucButton btnPheDuyet;
    }
}