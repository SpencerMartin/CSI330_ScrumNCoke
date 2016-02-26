using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes1
{
    public partial class NewNote : Form
    {
        public string taskString{get;set;}

        public NewNote()
        {
            InitializeComponent();
            taskString = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void task_field_TextChanged(object sender, EventArgs e)
        {
            taskString = this.task_field.Text;
            
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
