using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points_.started
{
	static public class _CenterX
	{
		static public Point4dbl _Center_assumeStarted(this IEnumerable<Point4dbl> _points_started) {
			return new Point4dbl(
				_points_started.Select(p=>p.x).Average()
				,
				_points_started.Select(p=>p.y).Average()

			);
		}
	}
}
