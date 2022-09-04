using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon
{
	public class Co4dbl
		:
		nilnul.obj.Co<
			cloze_.Polygon4dblI
		>

	{
		public Co4dbl(Tuple<Polygon4dblI, Polygon4dblI> tuple) : base(tuple)
		{
		}

		public Co4dbl((Polygon4dblI, Polygon4dblI) valTuple) : base(valTuple)
		{
		}

		public Co4dbl(Polygon4dblI item1, Polygon4dblI item2) : base(item1, item2)
		{
		}
	}
}
