using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend
{
	public class Duo : nilnul.obj.Duo<TendI>
	{
		public Duo(Tuple<TendI, TendI> tuple) : base(tuple)
		{
		}

		public Duo(TendI item1, TendI item2) : base(item1, item2)
		{
		}
	}
}
