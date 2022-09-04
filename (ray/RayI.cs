using nilnul.geometry.planar._ray_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{

	public class Ray : RayI
	{
		private PointI1 _src;
		public PointI1 src => _src;

		private planar.RotationI1 _rotation;

		public planar.RotationI1 rotation => _rotation;

		public Ray(PointI1 src, planar.RotationI1 rotation )
		{
			_src = src;
			_rotation = rotation;
		}

		public void cannonize() {
			_rotation = planar.rotation_.Direction.Create_byCannonize(_rotation) ;
		}
	}
}
