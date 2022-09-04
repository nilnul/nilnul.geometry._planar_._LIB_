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
	public class Twin
		:
		nilnul.geometry.planar.point.Co	//we use duo, but the pair.Eq is different from duo.Eq. And the order is not guranteed
	{

		public Twin(Co duo):base(duo)
		{
		}

		public Twin(PointI1 point, PointI1 end) : base(point, end)
		{
		}


	}
}
