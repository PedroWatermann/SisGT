using SisGT.Controllers;
using SisGT.Models;
using SisGT.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SisGT.Views
{
    public partial class MainForm : Form
    {
        private readonly List<string> filterOptions = new List<string>() { "Título", "Descrição", "Status" };
        private int? LastFilter = null;
        private string LastTextFilter = "";
        private bool? LastStatus = null;

        internal TableLayoutPanel GenerateCard(TaskModel task)
        {
            TableLayoutPanel tlpExternal = new TableLayoutPanel()
            {
                ColumnCount = 1,
                RowCount = 1,
                Size = new Size(300, 150)
            };

            GroupBox gbxCard = new GroupBox()
            {
                Text = task.Title,
                ForeColor = Color.Black,
                Font = new Font(this.Font, FontStyle.Bold),
                Dock = DockStyle.Fill
            };

            TableLayoutPanel tlpInternal = new TableLayoutPanel()
            {
                ColumnCount = 2,
                RowCount = 4,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            TextBox txtCard = new TextBox()
            {
                BackColor = Color.FloralWhite,
                BorderStyle = BorderStyle.None,
                Font = new Font(this.Font, FontStyle.Regular),
                ForeColor = Color.FromArgb(75, 54, 33),
                Text = task.Description,
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill
            };

            CheckBox ckbCard = new CheckBox()
            {
                CheckAlign = ContentAlignment.MiddleCenter,
                Checked = task.Status,
                Text = string.Empty,
                Tag = task.Id,
                Dock = DockStyle.Fill
            };

            Button btnEdit = new Button()
            {
                Image = Resources.edit,
                Text = string.Empty,
                Tag = task.Id,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };
            
            Button btnDelete = new Button()
            {
                Image = Resources.delete,
                Text = string.Empty,
                Tag = task.Id,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            ckbCard.CheckedChanged += EditStatus;

            btnEdit.Click += EditTask;
            btnDelete.Click += DeleteTask;

            tlpInternal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInternal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
            tlpInternal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tlpInternal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tlpInternal.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            tlpInternal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInternal.Controls.AddRange(new Control[] {txtCard, ckbCard, btnEdit, btnDelete});
            tlpInternal.SetRowSpan(txtCard, 4);

            gbxCard.Controls.Add(tlpInternal);

            tlpExternal.Controls.Add(gbxCard);

            return tlpExternal;
        }

        private void FilterByString(object sender, EventArgs e)
        {
            TextBox txtFilter = (TextBox)sender;
            string text = txtFilter != null ? txtFilter.Text.Normalize().ToLower() : string.Empty;
            
            LastFilter = Convert.ToInt32(txtFilter.Tag);
            LastTextFilter = text;

            LoadTasks(null, Convert.ToInt32(txtFilter.Tag), text);
        }

        private void FilterByStatus(object sender, EventArgs e)
        {
            CheckBox ckbFilter = (CheckBox)sender;
            bool status = ckbFilter != null && ckbFilter.Checked;

            LastStatus = status;

            LoadTasks(status);
        }

        private void EditTask(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            new TaskForm(false, Convert.ToInt32(btnEdit.Tag)).ShowDialog();
            LoadTasks(null);
        }

        private void EditStatus(object sender, EventArgs e)
        {
            CheckBox ckbStatus = (CheckBox)sender;
            TaskModel task = new TaskController().ReadId(Convert.ToInt32(ckbStatus.Tag));
            task.Status = ckbStatus.Checked;
            new TaskController().Update(task, task.Id);
            LoadTasks(null);
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;
            if (Convert.ToInt32(btnDelete.Tag) > 0 && MessageBox.Show("Confirmar exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new TaskController().Delete(Convert.ToInt32(btnDelete.Tag));
                if (cbxFilter.SelectedIndex != 2) LoadTasks(null);
                else LoadTasks(LastStatus);
            }
        }

        internal void LoadTasks(bool? status, int? filter = null, string text = "")
        {
            flpBody.Controls.Clear();
            List<TaskModel> tasks = new TaskController().Read();
            List<TaskModel> result = new List<TaskModel>();

            if (cbxFilter.SelectedIndex != 2)
            {
                if (filter != LastFilter) filter = LastFilter;
                if (text != LastTextFilter) text = LastTextFilter;
            }

            if (status == null && cbxFilter.SelectedIndex == 2)
            {
                status = LastStatus;
                result = tasks.Where(task => task.Status == status).ToList();
            }
            else if (status == null && text == "" && cbxFilter.SelectedIndex == -1)
            {
                result = tasks.Where(task => task.Status == false).ToList();
                result.AddRange(tasks.Where(task => task.Status == true).ToList());
            }
            else
            {
                if (status != null)
                    result = tasks.Where(task => task.Status == status).ToList();
                else if (filter != null)
                    result = filter == 0 ?
                        tasks.Where(task => task.Title.ToLower().Contains(text)).ToList() :
                        tasks.Where(task => task.Description.ToLower().Contains(text)).ToList();
            }

            if (result.Count > 0) foreach (TaskModel task in result) flpBody.Controls.Add(GenerateCard(task));

            LastFilter = filter;
            LastTextFilter = text;
            LastStatus = status;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbxFilter.Items.Clear();
            cbxFilter.Items.AddRange(filterOptions.ToArray());
            cbxFilter.SelectedIndex = -1;

            LoadTasks(null);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            cbxFilter.SelectedIndex = -1;
            LoadTasks(null);
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFilter.Enabled = this.cbxFilter.SelectedIndex != -1;

            if (tlpHeader.Controls.Count > 4) tlpHeader.Controls.RemoveAt(tlpHeader.Controls.Count - 1);

            TextBox txtFilter = new TextBox()
            {
                BackColor = Color.FloralWhite,
                Font = new Font(this.Font, FontStyle.Regular),
                ForeColor = Color.FromArgb(75, 54, 33),
                Text = string.Empty,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(3, 6, 3, 3),
                Size = new Size(250, 30),
            };
            txtFilter.TextChanged += FilterByString;

            CheckBox ckbFilter = new CheckBox()
            {
                Checked = false,
                Dock = DockStyle.Left
            };
            ckbFilter.CheckedChanged += FilterByStatus;

            switch (cbxFilter.SelectedIndex)
            {
                case 0:
                    txtFilter.Tag = 0;
                    tlpHeader.Controls.Add(txtFilter, 2, 0);
                    LastFilter = Convert.ToInt32(txtFilter.Tag);
                    LastTextFilter = txtFilter.Text.Normalize().ToLower();
                    LoadTasks(null, LastFilter, LastTextFilter);
                    break;
                case 1:
                    txtFilter.Tag = 1;
                    tlpHeader.Controls.Add(txtFilter, 2, 0);
                    LastFilter = Convert.ToInt32(txtFilter.Tag);
                    LastTextFilter = txtFilter.Text.Normalize().ToLower();
                    LoadTasks(null, LastFilter, LastTextFilter);
                    break;
                case 2:
                    tlpHeader.Controls.Add(ckbFilter, 2, 0);
                    LastStatus = ckbFilter.Checked;
                    LoadTasks(LastStatus);
                    break;
                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new TaskForm(true).ShowDialog();
            LoadTasks(null);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
