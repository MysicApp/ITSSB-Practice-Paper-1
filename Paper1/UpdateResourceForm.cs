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
    public partial class UpdateResourceForm : Form
    {
        Backable Backable;
        
        public UpdateResourceForm(Form previousForm)
        {
            InitializeComponent();
            Backable = new Backable(this, previousForm);
        }

        
    }
}
