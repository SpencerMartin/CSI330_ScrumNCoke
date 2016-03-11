using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Domain {
	public class Note {
		public Guid id { get; set; }
		public string name { get; set; }
		public string content { get; set; }
		public int board { get; set; }
		public DateTime created { get; set; }
		public int status_code { get; set; }
		public int creator { get; set; }
		public int coord_x { get; set; }
		public int coord_y { get; set; }
		public int width { get; set; }
		public int height { get; set; }
	}
}
