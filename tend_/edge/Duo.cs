using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.edge
{
	public class Duo : nilnul.obj.Duo<EdgeI>
	{
		public Duo(Tuple<EdgeI, EdgeI> tuple) : base(tuple)
		{
		}

		public Duo(EdgeI item1, EdgeI item2) : base(item1, item2)
		{
		}
	}
}
