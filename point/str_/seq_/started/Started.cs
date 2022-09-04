
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.geometry.planar.points_
{
	/// <summary>
	/// at least one points
	/// </summary>
	public class Started
		:
		nilnul.obj.str_.Started<Point, PointsI>
	{
		public Started(Point head, PointsI tail) : base(head, tail)
		{
		}
	}
}
