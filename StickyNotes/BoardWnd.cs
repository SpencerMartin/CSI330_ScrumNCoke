/* Referenced:
 * http://stackoverflow.com/questions/556147/how-to-quickly-and-easily-embed-fonts-in-winforms-app-in-c-sharp
 * http://stackoverflow.com/questions/16384903/moving-a-control-by-dragging-it-with-the-mouse-in-c-sharp
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace StickyNotes {
	public partial class BoardWnd : Form {
		[System.Runtime.InteropServices.DllImport( "gdi32.dll" )]
		private static extern IntPtr AddFontMemResourceEx( IntPtr pbFont, uint cbFont,
			IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts );

		private PrivateFontCollection fonts = new PrivateFontCollection();

		Font Gloria;

		public BoardWnd() {
			InitializeComponent();

			// Load Gloria Hallelujah font
			byte[] fontData = Properties.Resources.GloriaHallelujah;
			IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem( fontData.Length );
			System.Runtime.InteropServices.Marshal.Copy( fontData, 0, fontPtr, fontData.Length );
			uint dummy = 0;
			fonts.AddMemoryFont( fontPtr, Properties.Resources.GloriaHallelujah.Length );
			AddFontMemResourceEx( fontPtr, (uint)Properties.Resources.GloriaHallelujah.Length, IntPtr.Zero, ref dummy );
			System.Runtime.InteropServices.Marshal.FreeCoTaskMem( fontPtr );

			Gloria = new Font( fonts.Families[0], 16.0F );

			// Test label2
			Label label2 = new System.Windows.Forms.Label();
			label2.BackColor = System.Drawing.Color.Transparent;
			label2.Font = Gloria;
			label2.Image = global::StickyNotes.Properties.Resources.note;
			label2.Location = new System.Drawing.Point( 137, 236 );
			label2.Name = "label2";
			label2.Padding = new System.Windows.Forms.Padding( 20, 40, 20, 40 );
			label2.Size = new System.Drawing.Size( 250, 250 );
			label2.TabIndex = 0;
			label2.Text = "This is a test sticky note 2";
			this.Controls.Add( label2 );
		}

		private void BoardWnd_Load( object sender, EventArgs e ) {
			label1.Font = Gloria;
		}

		private Point _Offset = Point.Empty;

		protected void StickyMouseDown( object sender, MouseEventArgs e ) {
			if( e.Button == MouseButtons.Left ) {
				_Offset = new Point( e.X, e.Y );
			}
		}

		protected void StickyMouseMove( object sender, MouseEventArgs e ) {
			if( _Offset != Point.Empty ) {
				Label thisSticky = (Label) sender;
				Point newlocation = thisSticky.Location;
				newlocation.X += e.X - _Offset.X;
				newlocation.Y += e.Y - _Offset.Y;
				thisSticky.Location = newlocation;
			}
		}

		protected void StickyMouseUp( object sender, MouseEventArgs e ) {
			_Offset = Point.Empty;
		}
	}
}
