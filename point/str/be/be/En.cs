using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.be
{
	public class En<T> : nilnul.obj.be.En2<PointsI1, T>
		where T : BeI, new()
	{
		public En(PointsI1 val) : base(val)
		{
		}
	}
}
