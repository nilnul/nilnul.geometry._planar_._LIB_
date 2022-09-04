using nilnul.geometry.planar.tope_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co_
{
	public class Nondecrease : point.co.be_.nondecrease.vow.EeDbl
	{
		public Nondecrease(CoD val) : base(val)
		{
		}

		static public BlocDbl _Bounding_assumeNondecrease(
			Point4dbl lower
			,
			Point4dbl upper
		) {
			return new BlocDbl(
				lower
				,
				new _area.SizeDbl(
					upper.x-lower.x
					,
					upper.y-lower.y
				)
			);
		}
	}
}
