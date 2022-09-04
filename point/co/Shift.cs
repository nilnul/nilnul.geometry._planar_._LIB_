using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.duo.to_
{
	public static class _Shift
	{
		static public float Shift(this PointF start, PointF end) {
			return end.X - start.X;
		}

		static public nilnul.num.ieeeF.be_.NonNeg.En Abs(PointF start, PointF end) {
			return nilnul.num.ieeeF.be_.NonNeg.En.CreateByAbs(
				Shift(start,end)
				);
		}
	}
}
