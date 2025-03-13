using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = nilnul.geometry.planar._point.PointD;
using Point1 = nilnul.geometry.planar._point.PointD;
using PointD = nilnul.geometry.planar._point.PointD;


namespace nilnul.geometry.planar.point.b.nonZero.asserted
{
	public class Angle
	{
		static public double _Eval_nonZeroPoint(double x, double y) {
			return NonZero.Asserted._Angle_nonZeroPoint(x, y);
		}
		static public double _Eval_nonZeroPoint(PointD p) {
			return NonZero.Asserted._Angle_nonZeroPoint(p.x, p.y);
		}


		static public double Eval(point.b.NonZero.Asserted p) {
			return NonZero.Asserted._Angle_nonZeroPoint(p.val.x, p.val.y);
		}


	}
}
