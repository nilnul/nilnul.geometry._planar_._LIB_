using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.duo.to_
{
	public static class _Raise
	{
		static public float Raise(this PointF start, PointF end)
		{
			return end.Y - start.Y;
		}


		static public nilnul.num.ieeeF.be_.NonNeg.En Abs(this PointF start, PointF end)
		{
			return num.ieeeF.be_.NonNeg.En.CreateByAbs(
					Raise(start, end)
			);
		}
	}
}
