using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Domain {
	public interface INoteRepository {
		void Add( Note note );
		void Update( Note note );
		void Remove( Note note );
		Note GetById( Guid productId );
		Note GetByName( string name );
	}
}
