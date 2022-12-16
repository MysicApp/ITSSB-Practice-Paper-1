using Paper1.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper1
{
    public partial class NewResourceForm : Form
    {
        Backable Backable;

        public NewResourceForm(Form previous_form)
        {
            InitializeComponent();
            Backable = new Backable(this, previous_form);
        }

        private void NewResourceForm_Load(object sender, EventArgs e)
        {
            using var context = new Session1Context();
            ComboType.DataSource = context.ResourceTypes
                .Select(rt => rt.ResTypeName)
                .ToList();
            CheckListSkills.ClearSelected();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Backable.BackToParent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            // Reset boxes and checklist
            foreach (var box in Controls.OfType<TextBox>())
            {
                box.Text = "";
            }
            CheckListSkills.ClearSelected();
        }

        private bool ValidateData()
        {
            using var context = new Session1Context();


            return true;
        }
    }
}
