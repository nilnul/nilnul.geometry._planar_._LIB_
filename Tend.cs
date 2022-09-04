using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;

namespace nilnul.geometry.planar
{
	public class Tend  : nilnul.geometry.planar.point.Twin
		,TendI
	{
		public Tend(Point1 point, Point1 end) : base(point, end)
		{
		}

		public Twin points => this;
	}

}
