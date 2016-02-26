namespace StickyNotes1
{
    partial class NewNote
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
            this.task_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task_field
            // 
            this.task_field.Location = new System.Drawing.Point(12, 98);
            this.task_field.Name = "task_field";
            this.task_field.Size = new System.Drawing.Size(205, 20);
            this.task_field.TabIndex = 0;
            this.task_field.TextChanged += new System.EventHandler(this.task_field_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(141, 227);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_button.TabIndex = 2;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(12, 227);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 262);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_field);
            this.Name = "NewNote";
            this.Text = "NewNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox task_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button cancel_button;
    }
}