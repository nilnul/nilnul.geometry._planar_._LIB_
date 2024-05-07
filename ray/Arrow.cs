using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.ray
{
	static public class _ArrowX
	{
		static public planar.grad_.Arrow Arrow(planar.RayI ray) {
			return  new planar.grad_.Arrow(
				ray.src
				,
				vect.co.band_._AddX.Point(
					ray.src
					,
					planar.ray._VectorX.Vector(ray)
				)
			);
		}
		static public planar.grad_.skid_.ByPoints4Dbl Arrow(planar.IRayDbl ray) {
			return new planar.grad_.skid_.ByPoints4Dbl(
				ray.src
				,
				vect.co.band_._AddX.PointDbl(
					ray.src
					,
					planar.ray._VectorX.Vector(ray)
				)
				
			);
		}




	}
}
