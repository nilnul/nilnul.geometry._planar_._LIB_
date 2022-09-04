using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point
{

	/// <summary>
	/// un ordered pair.
	/// </summary>
	public class TwinD
		:
		nilnul.geometry.planar.point.CoD	//we use duo, but the pair.Eq is different from duo.Eq. And the order is not guranteed
		,
		nilnul.obj.TwinI<Point4dblI>
	{

		public TwinD(CoD duo):base(duo.component,duo.component1)
		{
		}

		public TwinD(Point4dblI point, Point4dblI end) : base(point, end)
		{
		}


	}
}
