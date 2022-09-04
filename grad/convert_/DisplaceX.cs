using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.convert_
{
	static public class _DisplaceX
	{
		static public Grad4dbl Displace(this planar.Grad4dblI grad, planar.Vector4dblI vector) {
			return new Grad4dbl(
				grad.basis
				,

				planar.vect.op_.binary_._AddX.Op(grad.vect,vector)

				//point.convert_._ShiftX.Shift(grad.points.component1, vector)
			);
		}
	}
}
