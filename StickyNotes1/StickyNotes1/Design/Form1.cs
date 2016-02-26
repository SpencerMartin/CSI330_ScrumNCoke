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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            NewNote form = new NewNote();
            var res = form.ShowDialog();
            string newTaskLabel;

            if(res == DialogResult.OK)
            {
                newTaskLabel = form.taskString;
            }

        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {

        }

        private void OnDragLeave(object sender, EventArgs e)
        {

        }

        private void OnDragOver(object sender, DragEventArgs e)
        {

        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
