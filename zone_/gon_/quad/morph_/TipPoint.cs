using nilnul.geometry.planar.grad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad.morph_
{
	/// <summary>
	/// establish a coord system (might be nonorthogonal) with:
	///		origin at the downleft corner
	///		two axis along the edge
	///	then stretch the point not on any axis.
	///	The stretch force will be synnergied by the axis, which is kept fixed such that there are two stretching forces : the point, and the axis.
	/// </summary>
	/// we need to decompose the stretch displace into two component along the two axis.
	/// given that the axises are not ortho,
	///		we might first convert this to ortho, and apply the morph and convert back
	///		or we can just decompose the force along the parallelogram axises.
	class TipPoint
		:
		nilnul.obj.Box1<zone_.gon_.Quod4dbl>
		,
		drawable._morph_.OfPoint4DblI
	{
		private Point4dblI _tipTgt;

		public Point4dblI tipTgt
		{
			get { return _tipTgt; }
			set { _tipTgt = value; }
		}

		public TipPoint(Quod4dbl val, Point4dblI tipTgt0) : base(val)
		{
			_tipTgt = tipTgt0;
		}

		public Point4dblI morph(Point4dblI original)
		{
			///treat each point as on the basis on the first and last edge.
			///
			/// when the tippoint as a vector stretches, 
			///	decompose the vector as the coords on the basises of the first and last edge. This is a sale.
			///	scale each point.
			///
			var vertexes = boxed.vertexes.ToArray();

			var origin2be = vertexes[0];

			var grads = boxed.grads.ToArray();

			var newAxisX = grads[0].Vect();

			var newAxisY = -grads[3].Vect();

			var changeAsVect = nilnul.geometry.planar.grad._DisplaceX.Vect(
				vertexes[2]
				,
				_tipTgt
			);

			var tipPointVect = planar.grad._DisplaceX.Vect(vertexes[0], vertexes[2]);



			// decompose the 




			//throw new NotImplementedException();
		}
	}
}

/*
 One possible strategy.

Parameterize each side of your (convex) quadrilateral ABCD using

A+t(B−A),   denoted as U

D+t(C−D),   denoted as V

		// given the innerPoint P , the three points are in line.
		// this is:
			 P.y - U.y   /    P.x - U.x  =  U.y-V.y  / U.x-V.x
			(P.y-U.y) * (U.x-V.x) = (U.y-V.y) * (P.x - U.x)

			
A+s(D−A),

B+s(C−B)

with P=(s,t) in the unit square. To map P to the quadrilateral, join the points determined by t on AB and DC, the points determined by s on the other two edges, and find the intersection of those two line segments.

answered Apr 17, 2019 at 14:02
Ethan Bolker

math.stackexchange.com/questions/3191066/transforming-an-arbitrary-quadrilateral-to-a-unit-square
 */
