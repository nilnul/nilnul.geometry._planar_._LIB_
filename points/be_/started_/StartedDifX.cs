using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.be_.started_
{
	public class DistinctHorizon
		:nilnul.obj.be_.FroAnd_defaultable<
			IEnumerable<Point4dbl>
			, StartedDbl
			,DistinctHorizonDbl
			>
	{


		static public DistinctHorizon Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<DistinctHorizon>.Instance;
			}
		}


	}
}
