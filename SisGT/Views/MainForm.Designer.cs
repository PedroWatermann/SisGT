namespace SisGT.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.flpBody = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpBorder = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tlpGeneral.SuspendLayout();
            this.tlpBorder.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.ColumnCount = 1;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.Controls.Add(this.tlpBorder, 0, 0);
            this.tlpGeneral.Controls.Add(this.flpBody, 0, 1);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tlpGeneral.RowCount = 2;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.Size = new System.Drawing.Size(1181, 476);
            this.tlpGeneral.TabIndex = 7;
            // 
            // flpBody
            // 
            this.flpBody.AutoScroll = true;
            this.flpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBody.Location = new System.Drawing.Point(3, 43);
            this.flpBody.Margin = new System.Windows.Forms.Padding(0);
            this.flpBody.Name = "flpBody";
            this.flpBody.Padding = new System.Windows.Forms.Padding(6);
            this.flpBody.Size = new System.Drawing.Size(1175, 430);
            this.flpBody.TabIndex = 1;
            // 
            // tlpBorder
            // 
            this.tlpBorder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBorder.ColumnCount = 1;
            this.tlpBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBorder.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBorder.Location = new System.Drawing.Point(3, 3);
            this.tlpBorder.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBorder.Name = "tlpBorder";
            this.tlpBorder.RowCount = 1;
            this.tlpBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBorder.Size = new System.Drawing.Size(1175, 40);
            this.tlpBorder.TabIndex = 2;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 6;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHeader.Controls.Add(this.cbxFilter, 1, 0);
            this.tlpHeader.Controls.Add(this.btnFilter, 0, 0);
            this.tlpHeader.Controls.Add(this.btnAdd, 4, 0);
            this.tlpHeader.Controls.Add(this.btnLogout, 5, 0);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(1, 1);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(1173, 38);
            this.tlpHeader.TabIndex = 5;
            // 
            // cbxFilter
            // 
            this.cbxFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFilter.BackColor = System.Drawing.Color.White;
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Location = new System.Drawing.Point(43, 6);
            this.cbxFilter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(109, 28);
            this.cbxFilter.TabIndex = 10;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Enabled = false;
            this.btnFilter.Image = global::SisGT.Properties.Resources.filter_clear;
            this.btnFilter.Location = new System.Drawing.Point(0, 0);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFilter.Size = new System.Drawing.Size(40, 38);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Image = global::SisGT.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(961, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(124, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.Image = global::SisGT.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1091, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(79, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Sair";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1181, 476);
            this.Controls.Add(this.tlpGeneral);
            this.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpGeneral.ResumeLayout(false);
            this.tlpBorder.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeneral;
        private System.Windows.Forms.FlowLayoutPanel flpBody;
        private System.Windows.Forms.TableLayoutPanel tlpBorder;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLogout;
    }
}