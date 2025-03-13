using nilnul.geometry.planar._polar_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse_.central._boundary_.by_
{
	internal class DirectiveCircle
	{
		///https://en.wikipedia.org/wiki/Director_circle
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ellipse"></param>
		/// <returns></returns>
		static public (double boundaryRadiusX, double boundaryRadiusY) Boundary(
			Centered8origin ellipse
		)
		{
			///math.stackexchange.com/questions/33520/the-locus-of-the-intersection-point-of-two-perpendicular-tangents-to-a-given-ell/33555#33555
			///
			/// Parameterizing the ellipse by P(acosθ,bsinθ)			and rotating about the center by angle ϕ gives an ellipse parameterized by
			/// (acosθcosϕ−bsinθsinϕ, acosθsinϕ + bsinθcosϕ)
			///
			/// The right side of the axis-aligned bounding rectangle is determined by the value of θ that maximizes the x coordinate; the top side is determined by the value that maximizes the y coordinate.
			///
			/// Note that both parameterized coordinates have the form Ucosθ+Vsinθ, which can be expressed as √ (U2+V2)sin(θ+ψ) for some ψ.
			/// As θ traverses all values from 0 to 2π, the coordinate formula must attain a maximum value of √(U2+V2) (and we needn't worry about the exact value of ψ).
			///
			/// Consequently, the rotated ellipse's maximal x-coordinate is x⋆:=√ ( (a cosϕ)^2+(b sinϕ) ^2 ) and its maximal y-coordinate is y⋆:=√( (a sinϕ )^2+ (b cosϕ )^2)
			///

			double cos = Math.Cos(ellipse.rotated);
			double sin = Math.Sin(ellipse.rotated);

			return (
				nilnul.num.real.str.to_.scalar_.Norm.Singleton.op(
					ellipse. radiusX * cos
					,
					ellipse.radiusY * sin
				)
					,
				nilnul.num.real.str.to_.scalar_.Norm.Singleton.op(
					ellipse.radiusX * sin
					,
					ellipse.radiusY * cos
				)
			);          ///
						/// , so that the rectangle's semi-diagonal, d, satisfies:
						///
						/// d^2 =a^2 + b^2
						///
						///Therefore, the corners of the axis-aligned bounding rectangles of the rotated ellipse lie on the circle of radius √(a^2 + b^2)

		}
	}
}
