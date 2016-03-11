namespace StickyNotes {
	partial class BoardWnd {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.scrollV = new System.Windows.Forms.VScrollBar();
			this.scrollH = new System.Windows.Forms.HScrollBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Image = global::StickyNotes.Properties.Resources.note_nontransparent;
			this.label1.Location = new System.Drawing.Point(263, 122);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(20, 40, 20, 40);
			this.label1.Size = new System.Drawing.Size(195, 194);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a test sticky note";
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StickyMouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StickyMouseMove);
			this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StickyMouseUp);
			// 
			// scrollV
			// 
			this.scrollV.Location = new System.Drawing.Point(1220, -2);
			this.scrollV.Name = "scrollV";
			this.scrollV.Size = new System.Drawing.Size(17, 653);
			this.scrollV.TabIndex = 1;
			// 
			// scrollH
			// 
			this.scrollH.Location = new System.Drawing.Point(0, 634);
			this.scrollH.Name = "scrollH";
			this.scrollH.Size = new System.Drawing.Size(1220, 17);
			this.scrollH.TabIndex = 2;
			// 
			// BoardWnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::StickyNotes.Properties.Resources.cork;
			this.ClientSize = new System.Drawing.Size(1237, 651);
			this.Controls.Add(this.scrollH);
			this.Controls.Add(this.scrollV);
			this.Controls.Add(this.label1);
			this.Name = "BoardWnd";
			this.Text = "Scrum Board";
			this.Load += new System.EventHandler(this.BoardWnd_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.VScrollBar scrollV;
		private System.Windows.Forms.HScrollBar scrollH;
	}
}

