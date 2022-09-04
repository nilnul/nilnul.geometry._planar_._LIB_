using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect
{
	public class Co
		: nilnul.obj.Co<linear.VectI>
	{
		public Co(Tuple<linear.VectI, linear.VectI> tuple) : base(tuple)
		{
		}
		public Co(VectI item1, VectI item2) : base(item1, item2)
		{
		}
		public Co(Vector item1, Vector item2) : base(item1, item2)
		{
		}

		public Co(Point item1, Point item2) : this((Vector)item1, (Vector)item2)
		{
		}

	}
}
