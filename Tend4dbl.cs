using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;

namespace nilnul.geometry.planar
{
	public class Tend4dbl : nilnul.geometry.planar.point.TwinD
		,Tend4dblI
	{
		public Tend4dbl(Point4dbl point, Point4dbl end) : base(point, end)
		{
		}

		public Tend4dbl(Point4dblI point, Point4dblI end) : base(point, end)
		{
		}

		public TwinD points => this;
	}

}
