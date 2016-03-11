using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Domain {
	public class Note {
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual string content { get; set; }
		public virtual int board { get; set; }
		public virtual DateTime created { get; set; }
		public virtual int status_code { get; set; }
		public virtual int creator { get; set; }
		public virtual int coord_x { get; set; }
		public virtual int coord_y { get; set; }
		public virtual int width { get; set; }
		public virtual int height { get; set; }
	}
}
