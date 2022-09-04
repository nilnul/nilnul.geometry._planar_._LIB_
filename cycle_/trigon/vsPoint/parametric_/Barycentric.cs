using nilnul.obj.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mou=nilnul.num.real.matrix_.square_.rankful.op_.unary_;


namespace nilnul.geometry.planar.cycle_.trigon.vsPoint
{
	/// <summary>
	/// 
	/// </summary>
	/// this can be extended to n-d simplex.
	public class Barycentric
		:
		nilnul.obj.Box1<
			cycle_.Triangle4dblI
		>

	{
		public Barycentric(Triangle4dblI val) : base(val)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="point"></param>
		/// <returns>
		///  some component might be out of the bound [0,1], say lt0 or gt1, even the sum of the vec is one. In this case, it means the point is outside the triangle.
		///  when two component is zero, the point is at the vetex.
		///  when one component is nil, the point is at the edge.
		///  
		///
		/// </returns>
		public nilnul.num.real.vec_.Tro4dbl barycentric(
			nilnul.geometry.planar.Point4dblI point
		) {
			///solve the matrix equation:
			///	
			///
			var cols = Enumerable.Range(
				0,3
			).Select(
				i=> planar.vect.to_._HomogeneousX.ToHomogeneous (boxed.vertexes.ElementAt(i).x, boxed.vertexes.ElementAt(i).y)
			);
			var pointCol = planar.vect.to_._HomogeneousX.ToHomogeneous(
					 point.x, point.y
					);
			var f = nilnul.num.real.matrix.co_.sociable._MultiX._Multiply_assumeSociable(
				mou.Invert._Matrix_assumeSquare1invertible(
					nilnul.num.real.matrix_.square_.Tertiary4dbl.OfCols(
						cols.ElementAt(0)
						,
						cols.ElementAt(1)
						,
						cols.ElementAt(2)
					)
				)
				,
				nilnul.num.real.matrix_._ColX.Matrix4dbl(
					pointCol.Item1,pointCol.Item2,pointCol.Item3
				)
			).Rows().First();
			return new num.real.vec_.Tro4dbl(
				f.ElementAt(0)
				,
				f.ElementAt(1)
				,
				f.ElementAt(2)
			);

			/// note: per crammer's rule, we can substitute one col of the matrix with the righthand side of the matrix equation, in other words, the homogenouse coords of the point, as the upper numerator over the leftside matrix to get the component of the coord in quest.
			/// the substituted matrix's determinant is the parallelogram signed area of the point with the edge.
		}
	}
}
