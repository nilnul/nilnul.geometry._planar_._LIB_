using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil
{
	public class Co4dbl : nilnul.obj.Co<vect_.NonnilDblI>
	{
		public Co4dbl(Tuple<NonnilDblI, NonnilDblI> tuple) : base(tuple)
		{
		}

		public Co4dbl((NonnilDblI, NonnilDblI) valTuple) : base(valTuple)
		{
		}

		public Co4dbl(NonnilDblI item1, NonnilDblI item2) : base(item1, item2)
		{
		}
	}
}
