
namespace GMS.QLKH
{
    partial class formLap_KeHoach_To_HoanThien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLap_KeHoach_To_HoanThien));
            this.lbKho = new VSCM.Base.Controls.ucLabel();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.btnCapNhat = new VSCM.Base.Controls.ucButton();
            this.cbNam = new VSCM.Base.Controls.ucComboBox();
            this.cbThang = new VSCM.Base.Controls.ucComboBox();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThang)).BeginInit();
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
            this.lbKho.Location = new System.Drawing.Point(1, 1);
            this.lbKho.Name = "lbKho";
            this.lbKho.Padding = new System.Windows.Forms.Padding(53, 5, 53, 5);
            this.lbKho.Size = new System.Drawing.Size(192, 31);
            this.lbKho.TabIndex = 1;
            this.lbKho.Text = "Chi nhánh";
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucLabel1.Appearance.Options.UseBackColor = true;
            this.ucLabel1.Appearance.Options.UseFont = true;
            this.ucLabel1.Appearance.Options.UseForeColor = true;
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(207, 1);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Padding = new System.Windows.Forms.Padding(67, 5, 67, 5);
            this.ucLabel1.Size = new System.Drawing.Size(173, 31);
            this.ucLabel1.TabIndex = 2;
            this.ucLabel1.Text = "Năm";
            // 
            // ucLabel2
            // 
            this.ucLabel2.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucLabel2.Appearance.Options.UseBackColor = true;
            this.ucLabel2.Appearance.Options.UseFont = true;
            this.ucLabel2.Appearance.Options.UseForeColor = true;
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(388, 1);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Padding = new System.Windows.Forms.Padding(53, 5, 53, 5);
            this.ucLabel2.Size = new System.Drawing.Size(159, 31);
            this.ucLabel2.TabIndex = 3;
            this.ucLabel2.Text = "Tháng";
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
            this.fg.Location = new System.Drawing.Point(1, 82);
            this.fg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 20;
            this.fg.Rows.MinSize = 20;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
            this.fg.ShowCellLabels = true;
            this.fg.Size = new System.Drawing.Size(1058, 461);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 4;
            this.fg.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fg_AfterEdit);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(1, 552);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(128, 33);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbNam
            // 
            this.cbNam.AddItemSeparator = ';';
            this.cbNam.AutoSize = false;
            this.cbNam.Caption = "";
            this.cbNam.CaptionHeight = 0;
            this.cbNam.CaptionVisible = false;
            this.cbNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbNam.ColumnHeaders = false;
            this.cbNam.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cbNam.ContentHeight = 28;
            this.cbNam.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cbNam.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cbNam.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cbNam.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cbNam.ExtendRightColumn = true;
            this.cbNam.FieldGroup = "";
            this.cbNam.FieldName = "";
            this.cbNam.Images.Add(((System.Drawing.Image)(resources.GetObject("cbNam.Images"))));
            this.cbNam.Location = new System.Drawing.Point(207, 41);
            this.cbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNam.MatchEntryTimeout = ((long)(2000));
            this.cbNam.MaxDropDownItems = ((short)(15));
            this.cbNam.MaxLength = 32767;
            this.cbNam.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cbNam.Name = "cbNam";
            this.cbNam.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cbNam.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cbNam.Size = new System.Drawing.Size(176, 34);
            this.cbNam.TabIndex = 6;
            this.cbNam.Text = "Năm";
            this.cbNam.SelectionChangeCommitted += new System.EventHandler(this.cbNam_SelectionChangeCommitted);
            this.cbNam.PropBag = resources.GetString("cbNam.PropBag");
            // 
            // cbThang
            // 
            this.cbThang.AddItemSeparator = ';';
            this.cbThang.AutoSize = false;
            this.cbThang.Caption = "";
            this.cbThang.CaptionHeight = 0;
            this.cbThang.CaptionVisible = false;
            this.cbThang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbThang.ColumnHeaders = false;
            this.cbThang.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cbThang.ContentHeight = 28;
            this.cbThang.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cbThang.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cbThang.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cbThang.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cbThang.ExtendRightColumn = true;
            this.cbThang.FieldGroup = "";
            this.cbThang.FieldName = "";
            this.cbThang.Images.Add(((System.Drawing.Image)(resources.GetObject("cbThang.Images"))));
            this.cbThang.Location = new System.Drawing.Point(388, 41);
            this.cbThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbThang.MatchEntryTimeout = ((long)(2000));
            this.cbThang.MaxDropDownItems = ((short)(15));
            this.cbThang.MaxLength = 32767;
            this.cbThang.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cbThang.Name = "cbThang";
            this.cbThang.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cbThang.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cbThang.Size = new System.Drawing.Size(165, 34);
            this.cbThang.TabIndex = 7;
            this.cbThang.Text = "Tháng";
            this.cbThang.SelectionChangeCommitted += new System.EventHandler(this.cbThang_SelectionChangeCommitted);
            this.cbThang.PropBag = resources.GetString("cbThang.PropBag");
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(137, 552);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(128, 33);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // formLap_KeHoach_To_HoanThien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.fg);
            this.Controls.Add(this.ucLabel2);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.lbKho);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formLap_KeHoach_To_HoanThien";
            this.Text = "Lập kế hoạch tổ hoàn thiện";
            this.Load += new System.EventHandler(this.formLap_KeHoach_To_HoanThien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucLabel lbKho;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucLabel ucLabel2;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucButton btnCapNhat;
        private VSCM.Base.Controls.ucComboBox cbNam;
        private VSCM.Base.Controls.ucComboBox cbThang;
        private VSCM.Base.Controls.ucButton btnHuy;
    }
}