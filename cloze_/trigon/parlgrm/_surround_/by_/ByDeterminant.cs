using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.trigon.parlgrm._surround_
{
	static public class _ByDeterminantX
	{

		static public double Surround(
			C a
			,
			C b
			,
			C c
		)
		{

			return nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
				new double[,]{
					{ a.Real,a.Imaginary,1}  /// 1 * BC's <see cref="geometry.planar.grad.shade.rect._SurroundX"/>
					,
					{ b.Real,b.Imaginary,1}	/// -1 * AC's <see cref="grad.shade.rect._SurroundX"/>, which is CA's <see cref="grad.shade.rect._SurroundX"/>
					,
					{ c.Real, c.Imaginary,1}	/// 1* AB's <see cref="grad.shade.rect._SurroundX"/>
				}
			);
		}

		static public double Surround(
			planar.Point4dblI a
			,
			planar.Point4dblI b
			,
			planar.Point4dblI c
		)
		{
			return Surround(
				planar.PointX.ToComplex(a)
				,
				planar.PointX.ToComplex(b)
				,
				planar.PointX.ToComplex(c)
			);

			return nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(
				new double[,]{
					{ a.x,a.y,1}  /// 1 * BC's <see cref="geometry.planar.grad.shade.rect._SurroundX"/>
					,
					{ b.x,b.y,1}	/// -1 * AC's <see cref="grad.shade.rect._SurroundX"/>, which is CA's <see cref="grad.shade.rect._SurroundX"/>
					,
					{ c.x,c.y,1}	/// 1* AB's <see cref="grad.shade.rect._SurroundX"/>
				}
			);
		}

	}
}
