using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin_
{
	public class Dif : nilnul.geometry.planar.point.twin.be_.dif.En
	{

		public Dif(Twin duo) : base(duo)
		{
		}

		public Dif(planar.point.Co duo):this(new Twin(duo))
		{
		}
		public Dif(planar.PointI1 a, planar.PointI1 b):this(new Twin(a,b))
		{

		}
	}
}
