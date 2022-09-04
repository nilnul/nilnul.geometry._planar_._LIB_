using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.point.convert_
{
	static public class NegX
	{
		static public PointF Neg(this PointF pivot) {
			return new PointF(-pivot.X, -pivot.Y);
		}
		
	}
}
