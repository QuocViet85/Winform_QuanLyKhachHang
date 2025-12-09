
namespace GMS.QLKH
{
    partial class frmDM_Thung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_Thung));
            this.lbKho = new VSCM.Base.Controls.ucLabel();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.ctxMenuFg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmThemDong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXoaDong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCapNhat = new VSCM.Base.Controls.ucButton();
            this.cmbKho = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.ctxMenuFg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKho
            // 
            this.lbKho.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbKho.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKho.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbKho.Appearance.Options.UseBackColor = true;
            this.lbKho.Appearance.Options.UseFont = true;
            this.lbKho.Appearance.Options.UseForeColor = true;
            this.lbKho.FieldGroup = "";
            this.lbKho.FieldName = "";
            this.lbKho.Location = new System.Drawing.Point(2, 2);
            this.lbKho.Margin = new System.Windows.Forms.Padding(2);
            this.lbKho.Name = "lbKho";
            this.lbKho.Padding = new System.Windows.Forms.Padding(75, 4, 75, 4);
            this.lbKho.Size = new System.Drawing.Size(178, 25);
            this.lbKho.TabIndex = 0;
            this.lbKho.Text = "Kho";
            // 
            // fg
            // 
            this.fg.AllowFiltering = true;
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.ContextMenuStrip = this.ctxMenuFg;
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(2, 61);
            this.fg.Margin = new System.Windows.Forms.Padding(2);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 23;
            this.fg.Rows.MinSize = 20;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fg.ShowCellLabels = true;
            this.fg.Size = new System.Drawing.Size(852, 450);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 2;
            this.fg.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fg_AfterEdit);
            // 
            // ctxMenuFg
            // 
            this.ctxMenuFg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThemDong,
            this.tsmXoaDong});
            this.ctxMenuFg.Name = "ctxMenuFg";
            this.ctxMenuFg.Size = new System.Drawing.Size(233, 214);
            // 
            // tsmThemDong
            // 
            this.tsmThemDong.Name = "tsmThemDong";
            this.tsmThemDong.Size = new System.Drawing.Size(232, 22);
            this.tsmThemDong.Text = "Thêm dòng";
            this.tsmThemDong.Click += new System.EventHandler(this.tsmThemDong_Click);
            // 
            // tsmXoaDong
            // 
            this.tsmXoaDong.Name = "tsmXoaDong";
            this.tsmXoaDong.Size = new System.Drawing.Size(232, 22);
            this.tsmXoaDong.Text = "Xóa dòng";
            this.tsmXoaDong.Click += new System.EventHandler(this.tsmXoaDong_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 515);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 22);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmbKho
            // 
            this.cmbKho.FieldGroup = "";
            this.cmbKho.FieldName = "";
            this.cmbKho.Location = new System.Drawing.Point(2, 33);
            this.cmbKho.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKho.Properties.Appearance.Options.UseBackColor = true;
            this.cmbKho.Properties.Appearance.Options.UseTextOptions = true;
            this.cmbKho.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbKho.Properties.AutoHeight = false;
            this.cmbKho.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbKho.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cmbKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKho.Properties.DisplayMember = "TenKho";
            this.cmbKho.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbKho.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbKho.Properties.NullText = "";
            this.cmbKho.Properties.PopupView = this.ucSearchLookupEdit1View;
            this.cmbKho.Properties.ValueMember = "ID_Kho";
            this.cmbKho.Size = new System.Drawing.Size(178, 22);
            this.cmbKho.TabIndex = 6;
            this.cmbKho.EditValueChanged += new System.EventHandler(this.cmbKho_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_Kho,
            this.TenKho});
            this.ucSearchLookupEdit1View.DetailHeight = 418;
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ID_Kho
            // 
            this.ID_Kho.Caption = "ID_Kho";
            this.ID_Kho.FieldName = "ID_Kho";
            this.ID_Kho.MinWidth = 15;
            this.ID_Kho.Name = "ID_Kho";
            this.ID_Kho.Width = 56;
            // 
            // TenKho
            // 
            this.TenKho.Caption = "TenKho";
            this.TenKho.FieldName = "TenKho";
            this.TenKho.MinWidth = 15;
            this.TenKho.Name = "TenKho";
            this.TenKho.Visible = true;
            this.TenKho.VisibleIndex = 0;
            this.TenKho.Width = 56;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Location = new System.Drawing.Point(2, 515);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 22);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(81, 515);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 22);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmDM_Thung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 538);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cmbKho);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.fg);
            this.Controls.Add(this.lbKho);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDM_Thung";
            this.Text = "Danh mục thùng";
            this.Load += new System.EventHandler(this.frmDM_Thung_Test_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ctxMenuFg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucLabel lbKho;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucButton btnCapNhat;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbKho;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ID_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn TenKho;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnHuy;
        private System.Windows.Forms.ContextMenuStrip ctxMenuFg;
        private System.Windows.Forms.ToolStripMenuItem tsmThemDong;
        private System.Windows.Forms.ToolStripMenuItem tsmXoaDong;
    }
}