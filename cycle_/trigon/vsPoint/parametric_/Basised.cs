using nilnul.obj.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mou=nilnul.num.real.matrix_.square_.rankful.op_.unary_;


namespace nilnul.geometry.planar.cycle_.trigon.vsPoint.parametric_
{
	/// <summary>
	/// take two edge as the new basis for a shear/scaled coord system.
	/// 
	/// </summary>
	public class Basised
		:
		nilnul.obj.Box1<
			cycle_.Triangle4dblI
		>

	{
		public Basised(Triangle4dblI val) : base(val)
		{
		}

		/// <summary>
		/// imagin a point in the trigon. we draw two guids from the point to the basises, getting the foot for the new coords. The two ratio would sum to one, as you can see the foot partitioned the edge in two proportions that are complement to each other.
		/// the two ratios have to be nonneg and summed no more than one.
		///
		/// x=x1+t1*(x2-x1)   + t2* (x3-x1)
		/// y=y1 + t1 *(y2-y1) + t2 *(y3-y1)
		///
		/// now find t1, t2
		/// 
		/// </summary>
		/// <param name="point"></param>
		/// <returns>new coords, or coefficients</returns>
		public (double,double) coef(
			nilnul.geometry.planar.Point4dblI point
		) {
			var newBasis0 = planar.grad._DisplaceX.Vect1(
				boxed.vertexes.ElementAt(0)
				,
				boxed.vertexes.ElementAt(1)
			);
			var newBasis1 = planar.grad._DisplaceX.Vect1(
				boxed.vertexes.ElementAt(0)
				,
				boxed.vertexes.ElementAt(2)
			);

			///solve the matrix equation:
			///	
			///
			return nilnul.obj.vec_._CoX._ValTup_assumeCo(
				nilnul.num.real.matrix.co_.sociable._MultiX._Multiply_assumeSociable(
					mou.Invert._Matrix_assumeSquare1invertible(
						nilnul.num.real.matrix_.square_._DimTwoX.OfCols4Dbl(
							newBasis0.point.x
							,
							newBasis0.point.y
							,
							newBasis1.point.x
							,
							newBasis1.point.y
						)
					)
					,
					nilnul.num.real.matrix_._ColX.Matrix4dbl(
						 point.x, point.y
					)
				).Rows().First()
			);
		}
	}
}
