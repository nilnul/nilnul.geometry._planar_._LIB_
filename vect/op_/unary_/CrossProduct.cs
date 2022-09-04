using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.op_.unary_
{
	/*
	  
	 
	 */
	public class _CrossProductX
	{
		static public Vect4dbl CrossProduct(Vect4dblI vect) {
			/// for vector3d,
			///		i,j,k
			///		a1,a2,a3
			///		b1,b2,b3
			///	the crossProduct is nominal determinant:
			///		i* determinantOf(
			///			a2,a3
			///			b2,b3
			///		)
			///		+
			///		j * -determinant (
			///			a1,a3
			///			b1,b3
			///		)
			///		+
			///		k * determinant(
			///			a1,a2
			///			b1,b2
			///		)
			///
			/// for vector2d, we only keep the above "k" part
			///		that is:
			///			determinant(
			///				a1,a2
			///				b1,b2
			///			)
			///		the original 3d matrix is:
			///			i，j, k
			///			a1,a2,0
			///			b1,b2,0
			///
			/// for vector 2d, in 2d space
			///		i,j
			///		a1,a2
			///	we can calculate the nominal determinant:
			///		i* a2 + j *(-a1)
			///		(a2,-a1)
			///
			/// for two vector, the cross product is the area.
			/// for one vector, the cross product keeps the length.
			///
			///  i, j
			///  a1,0
			///  the cross product of a1 is a1.
			///

			return new Vect4dbl(vect.point.y,-vect.point.x); /// <see cref="_RotateX.RotateQuarterRoundBack(Vect4dblI)"/>

		}
	}
}
