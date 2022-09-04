using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point
{
	public class BagDbl : nilnul.obj.bag_.EqDefault<nilnul.geometry.planar.Point4dbl, nilnul.geometry.planar.point.EqDbl>
	{
		public BagDbl()
		{
		}

		public BagDbl(IEnumerable<Point4dbl> keysInMultiples) : base(keysInMultiples)
		{
		}

		public BagDbl(IEnumerable<KeyValuePair<Point4dbl, NumI1>> keyValuePairs) : base(keyValuePairs)
		{
		}

		public BagDbl(IEnumerable<KeyValuePair<Point4dbl, Num1>> keyValuePairs) : base(keyValuePairs)
		{
		}
	}
}
