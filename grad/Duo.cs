using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad
{
	public class Co : nilnul.obj.Co<GradI>
	{
		public Co(Tuple<GradI, GradI> tuple) : base(tuple)
		{
		}

		public Co(GradI item1, GradI item2) : base(item1, item2)
		{
		}
	}
}
