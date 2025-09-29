using SisGT.Controllers;
using SisGT.Models;
using System;
using System.Windows.Forms;

namespace SisGT.Views
{
    public partial class TaskForm : Form
    {
        private bool IsNew { get; set; }
        private TaskModel Task { get; set; }

        internal TaskForm(bool isNew, int idTask = 0)
        {
            InitializeComponent();
            IsNew = isNew;
            
            Task = new TaskController().ReadId(idTask);
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            if (!IsNew)
            {
                txtTitle.Text = Task.Title;
                txtDescription.Text = Task.Description;
                ckbStatus.Checked = Task.Status;
                
                btnConfirm.Enabled = true;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = txtTitle.Text.Length > 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Task.Title = txtTitle.Text.Normalize();
            Task.Description = txtDescription.Text.Normalize();
            Task.Status = ckbStatus.Checked;

            if (IsNew)
                new TaskController().Create(Task);
            else
                if (MessageBox.Show("Confirmar edição?", "Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    new TaskController().Update(Task, Task.Id);
            this.Close();
        }
    }
}
