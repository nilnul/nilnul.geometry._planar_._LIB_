using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point;

namespace nilnul.geometry.planar
{
	public interface GradI:IGrad
	{
		nilnul.geometry.planar.point.Co points { get; }
	}

	public class Grad
		:
		nilnul.geometry.planar.point.Co
		,
		GradI
	{
		public Grad(point.Co duo) : base(duo)
		{
		}

		public Grad(Point1 point, Point1 end) : base(point, end)
		{
		}

		public Grad(PointI1 a, PointI1 b) : base(a, b)
		{
		}

		public Co points => this;


		
	}
}
