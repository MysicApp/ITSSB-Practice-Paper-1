using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper1
{
    public class Backable
    {   
        protected Form CurrentForm { private get; set; }
        protected Form PreviousForm { private get; set; }
        
        public Backable(Form currentForm, Form previousForm)
        {
            CurrentForm = currentForm;
            PreviousForm = previousForm;
        }

        public void BackToParent()
        {
            CurrentForm.Hide();
            ResetTextBoxes();
            PreviousForm.Show();
        }

        protected void ResetTextBoxes()
        {
            foreach (var box in CurrentForm.Controls.OfType<TextBox>())
            {
                box.Text = "";
            }
        }
    }
}
