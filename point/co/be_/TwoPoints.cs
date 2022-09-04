using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.dir
{
	public partial class TwoPoints
	{
		private point.PointInDouble _point;

		public point.PointInDouble point
		{
			get { return _point; }
			set { _point = value; }
		}
		private point.PointInDouble _point1;

		public point.PointInDouble point1
		{
			get { return _point1; }
			set { _point1 = value; }
		}

		public TwoPoints(
			point.PointInDouble p,
			point.PointInDouble p1
		)
		{
			this.point = p;
			this.point1 = p1;

		}

		static public bool TwoPointsSame(point.PointInDouble x, point.PointInDouble y) {
			return nilnul.geometry._2d.point.PointInDouble.Eq.Eval(x, y);
		}

		static public bool TwoPointsSame(TwoPoints twoPoints) {
			return TwoPointsSame(twoPoints.point, twoPoints.point1);
		}
		
	}
}
