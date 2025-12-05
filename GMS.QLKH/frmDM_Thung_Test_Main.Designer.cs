
namespace GMS.QLKH
{
    partial class frmDM_Thung_Test_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_Thung_Test_Main));
            this.lbKho = new VSCM.Base.Controls.ucLabel();
            this.cmbKho = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.btnThem = new VSCM.Base.Controls.ucButton();
            this.btnSua = new VSCM.Base.Controls.ucButton();
            this.btnXoa = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
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
            this.lbKho.Name = "lbKho";
            this.lbKho.Padding = new System.Windows.Forms.Padding(100, 5, 100, 5);
            this.lbKho.Size = new System.Drawing.Size(234, 31);
            this.lbKho.TabIndex = 0;
            this.lbKho.Text = "Kho";
            // 
            // cmbKho
            // 
            this.cmbKho.FieldGroup = "";
            this.cmbKho.FieldName = "";
            this.cmbKho.Location = new System.Drawing.Point(2, 39);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Properties.AutoHeight = false;
            this.cmbKho.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKho.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbKho.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbKho.Properties.NullText = "";
            this.cmbKho.Properties.PopupView = this.ucSearchLookupEdit1View;
            this.cmbKho.Size = new System.Drawing.Size(234, 28);
            this.cmbKho.TabIndex = 1;
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // fg
            // 
            this.fg.AllowFiltering = true;
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(2, 73);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 23;
            this.fg.Rows.MinSize = 20;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fg.ShowCellLabels = true;
            this.fg.Size = new System.Drawing.Size(1139, 592);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(2, 671);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "&Thêm mới";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Location = new System.Drawing.Point(108, 671);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 29);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "&Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(214, 671);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 29);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "&Xóa";
            // 
            // frmDM_Thung_Test_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 703);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.fg);
            this.Controls.Add(this.cmbKho);
            this.Controls.Add(this.lbKho);
            this.Name = "frmDM_Thung_Test_Main";
            this.Text = "Danh mục thùng";
            this.Load += new System.EventHandler(this.frmDM_Thung_Test_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucLabel lbKho;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbKho;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucButton btnThem;
        private VSCM.Base.Controls.ucButton btnSua;
        private VSCM.Base.Controls.ucButton btnXoa;
    }
}