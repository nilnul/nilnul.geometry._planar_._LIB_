using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.vertical
{
	static public class TranslateX
	{
		static public PointF Lift(float x, PointF point) {
			return new PointF(
				point.X
				,
				point.Y+ x
			);
		}
	}
}
