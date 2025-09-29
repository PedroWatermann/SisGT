namespace SisGT.Views
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.tlpBorder = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.gbxTitle = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tlpBorder.SuspendLayout();
            this.tlpGeneral.SuspendLayout();
            this.gbxTitle.SuspendLayout();
            this.gbxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBorder
            // 
            this.tlpBorder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpBorder.ColumnCount = 1;
            this.tlpBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBorder.Controls.Add(this.tlpGeneral, 0, 0);
            this.tlpBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBorder.Location = new System.Drawing.Point(0, 0);
            this.tlpBorder.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBorder.Name = "tlpBorder";
            this.tlpBorder.RowCount = 1;
            this.tlpBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBorder.Size = new System.Drawing.Size(500, 300);
            this.tlpBorder.TabIndex = 0;
            // 
            // tlpGeneral
            // 
            this.tlpGeneral.ColumnCount = 3;
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpGeneral.Controls.Add(this.btnConfirm, 2, 2);
            this.tlpGeneral.Controls.Add(this.btnCancel, 1, 2);
            this.tlpGeneral.Controls.Add(this.gbxDescription, 0, 1);
            this.tlpGeneral.Controls.Add(this.gbxTitle, 0, 0);
            this.tlpGeneral.Controls.Add(this.ckbStatus, 0, 2);
            this.tlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneral.Location = new System.Drawing.Point(4, 4);
            this.tlpGeneral.Name = "tlpGeneral";
            this.tlpGeneral.RowCount = 3;
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpGeneral.Size = new System.Drawing.Size(492, 292);
            this.tlpGeneral.TabIndex = 0;
            // 
            // gbxTitle
            // 
            this.tlpGeneral.SetColumnSpan(this.gbxTitle, 3);
            this.gbxTitle.Controls.Add(this.txtTitle);
            this.gbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxTitle.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTitle.ForeColor = System.Drawing.Color.Black;
            this.gbxTitle.Location = new System.Drawing.Point(3, 3);
            this.gbxTitle.Name = "gbxTitle";
            this.gbxTitle.Size = new System.Drawing.Size(486, 49);
            this.gbxTitle.TabIndex = 0;
            this.gbxTitle.TabStop = false;
            this.gbxTitle.Text = "Título";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FloralWhite;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.txtTitle.Location = new System.Drawing.Point(3, 21);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(480, 18);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckbStatus.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStatus.ForeColor = System.Drawing.Color.Black;
            this.ckbStatus.Location = new System.Drawing.Point(3, 255);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(82, 34);
            this.ckbStatus.TabIndex = 3;
            this.ckbStatus.Text = "Status";
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Image = global::SisGT.Properties.Resources.confirm;
            this.btnConfirm.Location = new System.Drawing.Point(452, 252);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirm.Size = new System.Drawing.Size(40, 40);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Image = global::SisGT.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(412, 252);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(40, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxDescription
            // 
            this.tlpGeneral.SetColumnSpan(this.gbxDescription, 3);
            this.gbxDescription.Controls.Add(this.txtDescription);
            this.gbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDescription.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDescription.ForeColor = System.Drawing.Color.Black;
            this.gbxDescription.Location = new System.Drawing.Point(3, 58);
            this.gbxDescription.Name = "gbxDescription";
            this.gbxDescription.Size = new System.Drawing.Size(486, 191);
            this.gbxDescription.TabIndex = 2;
            this.gbxDescription.TabStop = false;
            this.gbxDescription.Text = "Descrição";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FloralWhite;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.txtDescription.Location = new System.Drawing.Point(3, 21);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(480, 167);
            this.txtDescription.TabIndex = 1;
            // 
            // TaskForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.tlpBorder);
            this.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.tlpBorder.ResumeLayout(false);
            this.tlpGeneral.ResumeLayout(false);
            this.tlpGeneral.PerformLayout();
            this.gbxTitle.ResumeLayout(false);
            this.gbxTitle.PerformLayout();
            this.gbxDescription.ResumeLayout(false);
            this.gbxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBorder;
        private System.Windows.Forms.TableLayoutPanel tlpGeneral;
        private System.Windows.Forms.GroupBox gbxTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}