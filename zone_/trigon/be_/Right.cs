using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle = nilnul.geometry.planar.zone_.TriangleDbl;

namespace nilnul.geometry.planar.zone_.trigon.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Right
		:

		trigon.BeA
	{

		//static public bool Be(TriangleI triangle)
		//{
		//	return nilnul.num.real.double_.Eq.Default.Equals(
		//		triangle
		//		.
		//		getMaxAngle()
		//		,
		//		planar.RotationOfDouble.QuarterTau
		//	);
		//}

		public override bool be(Triangle obj)
		{
			var lengths = obj.lengths;

			var positives = lengths.Select(
				length
				=>
				nilnul.num.real_.Positive.OvAssumePositive(length)
			);

			//try to select the max
			var maxUpperIndex = positives.Select(x => x.current.upper).Max().mark;
			var maxLowerOfAllMaxUppers = positives.Where(
				x => x.current.upper.mark == maxUpperIndex
			).Select(y => y.current.lower.mark).Max();
			var maxes = positives.Where(x=> x.current.lower>= maxLowerOfAllMaxUppers);


			//try part away the reals.

			//stop if :
			/// one unique max
			/// or  no pythagoream is met.
			///


			while (
				maxes.Count()
				//positives.Count(x=> x.current.lower>= maxLowerOfAllMaxUppers)
				> 1 // if max is not unique
			) { 
				///		if two or more max bounds,
				var lowerOrdered = positives.Select(x => x.current.lower.mark).OrderBy(y => y, nilnul.num.quotient.Comparer2.Singleton);
				var upperOrdered = positives.Select(x => x.current.upper.mark).OrderBy(y => y, nilnul.num.quotient.Comparer2.Singleton);


				if (
					nilnul.num.quotient.op_.unary_._SquareX.Square(
						lowerOrdered.First()
					) +
					nilnul.num.quotient.op_.unary_._SquareX.Square(
						lowerOrdered.Skip(1).First()
					)
					>
					nilnul.num.quotient.op_.unary_._SquareX.Square(
						upperOrdered.Last()
					)
					||
					nilnul.num.quotient.op_.unary_._SquareX.Square(
						upperOrdered.First()
					) +
					nilnul.num.quotient.op_.unary_._SquareX.Square(
						upperOrdered.Skip(1).First()
					)
					<
					nilnul.num.quotient.op_.unary_._SquareX.Square(
						lowerOrdered.Skip(1).First()
					)
				 )
				{
					return false;
				}

				///
				/// 
				///			we squeeze the bounds such that:
				///				//if two (a,b) are equal, then  a^2 cannot be b^2 + c^2, where c>0
				///					/// if 
				///				//if they are not equal, then we can have one unique max
				///

				positives.ForEach(x=>x.ClampHalf());

				maxUpperIndex = positives.Select(x => x.current.upper).Max().mark;

				maxLowerOfAllMaxUppers = positives.Where(
					x => x.current.upper.mark == maxUpperIndex
				).Select(y => y.current.lower.mark).Max();
				 maxes = positives.Where(x => x.current.lower >= maxLowerOfAllMaxUppers);

			}

			var theOtherLess = positives.Where(x => x.current.lower < maxLowerOfAllMaxUppers);
			return
					nilnul.num.real.op_.unary_._SquareX.Op(
						maxes.Single()
					)

					==
					nilnul.num.real.co.band_._SquareSumX.Real(
					theOtherLess.First()
					,
					theOtherLess.Skip(1).First()

					);



		}
	}
}