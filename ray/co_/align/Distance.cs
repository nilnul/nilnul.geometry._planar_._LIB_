using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.ray.co_.align
{
	public class Distance
	{
		static public double Eval(Arrow dir, point.PointInDouble start, point.PointInDouble end) {

			return Eval(new Dir(dir),start,end);

			throw new NotImplementedException();
		}

		static public double _ofAlign(planar.RayI dir, planar.RayI end) {
			if (start==end)
			{
				return 0;
				
			}

			return (CoDirection.Eval_byCompareAngle(dir, start, end) ? 1 : -1) * point.pair.Distance.Eval(start, end);

		}
	}
}
