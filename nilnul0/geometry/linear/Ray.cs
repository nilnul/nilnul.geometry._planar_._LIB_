using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear
{

	public class Ray : RayI
	{
		private RealI _start;
		public RealI start => _start;

		private bool _direction;
		public bool direction => _direction;

		public Ray(RealI start, bool direction)
		{
			_start = start;
			_direction = direction;
		}

		public Ray(RayI ray):this(ray.start,ray.direction)
		{
		}

		public Ray(int v, bool direction1):this(
			new nilnul.num.real_.Quotient(v)
			,
			direction1
		)
		{
		}
	}
}
