namespace StickyNotes1
{
    partial class Form1
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
            this.add_button = new System.Windows.Forms.Button();
            this.todo_list = new System.Windows.Forms.ListView();
            this.progress_list = new System.Windows.Forms.ListView();
            this.done_list = new System.Windows.Forms.ListView();
            this.testing_list = new System.Windows.Forms.ListView();
            this.todo_label = new System.Windows.Forms.Label();
            this.progress_label = new System.Windows.Forms.Label();
            this.testing_label = new System.Windows.Forms.Label();
            this.done_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 614);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add Note";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // todo_list
            // 
            this.todo_list.Location = new System.Drawing.Point(23, 177);
            this.todo_list.Name = "todo_list";
            this.todo_list.Size = new System.Drawing.Size(201, 374);
            this.todo_list.TabIndex = 1;
            this.todo_list.UseCompatibleStateImageBehavior = false;
            // 
            // progress_list
            // 
            this.progress_list.Location = new System.Drawing.Point(257, 177);
            this.progress_list.Name = "progress_list";
            this.progress_list.Size = new System.Drawing.Size(201, 374);
            this.progress_list.TabIndex = 2;
            this.progress_list.UseCompatibleStateImageBehavior = false;
            // 
            // done_list
            // 
            this.done_list.Location = new System.Drawing.Point(734, 177);
            this.done_list.Name = "done_list";
            this.done_list.Size = new System.Drawing.Size(201, 374);
            this.done_list.TabIndex = 4;
            this.done_list.UseCompatibleStateImageBehavior = false;
            // 
            // testing_list
            // 
            this.testing_list.Location = new System.Drawing.Point(501, 177);
            this.testing_list.Name = "testing_list";
            this.testing_list.Size = new System.Drawing.Size(201, 374);
            this.testing_list.TabIndex = 3;
            this.testing_list.UseCompatibleStateImageBehavior = false;
            // 
            // todo_label
            // 
            this.todo_label.AutoSize = true;
            this.todo_label.Location = new System.Drawing.Point(20, 77);
            this.todo_label.Name = "todo_label";
            this.todo_label.Size = new System.Drawing.Size(34, 13);
            this.todo_label.TabIndex = 5;
            this.todo_label.Text = "ToDo";
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(257, 77);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(60, 13);
            this.progress_label.TabIndex = 6;
            this.progress_label.Text = "In Progress";
            // 
            // testing_label
            // 
            this.testing_label.AutoSize = true;
            this.testing_label.Location = new System.Drawing.Point(501, 77);
            this.testing_label.Name = "testing_label";
            this.testing_label.Size = new System.Drawing.Size(76, 13);
            this.testing_label.TabIndex = 7;
            this.testing_label.Text = "Needs Testing";
            // 
            // done_label
            // 
            this.done_label.AutoSize = true;
            this.done_label.Location = new System.Drawing.Point(734, 77);
            this.done_label.Name = "done_label";
            this.done_label.Size = new System.Drawing.Size(33, 13);
            this.done_label.TabIndex = 8;
            this.done_label.Text = "Done";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 649);
            this.Controls.Add(this.done_label);
            this.Controls.Add(this.testing_label);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.todo_label);
            this.Controls.Add(this.done_list);
            this.Controls.Add(this.testing_list);
            this.Controls.Add(this.progress_list);
            this.Controls.Add(this.todo_list);
            this.Controls.Add(this.add_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.OnDragOver);
            this.DragLeave += new System.EventHandler(this.OnDragLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListView todo_list;
        private System.Windows.Forms.ListView progress_list;
        private System.Windows.Forms.ListView done_list;
        private System.Windows.Forms.ListView testing_list;
        private System.Windows.Forms.Label todo_label;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Label testing_label;
        private System.Windows.Forms.Label done_label;
    }
}

