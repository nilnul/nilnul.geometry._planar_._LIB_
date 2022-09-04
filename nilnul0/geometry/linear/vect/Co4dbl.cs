using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect
{
	public class Co4dbl
		: nilnul.obj.Co<linear.Vect4dblI>
	{
		
		public Co4dbl(Tuple<Vect4dblI, Vect4dblI> tuple) : base(tuple)
		{
		}

		public Co4dbl((Vect4dblI, Vect4dblI) valTuple) : base(valTuple)
		{
		}

	

		public Co4dbl(Vect4dblI item1, Vect4dblI item2) : base(item1, item2)
		{
		}
	}
}
