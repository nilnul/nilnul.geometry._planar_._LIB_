using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
using nilnul.obj.str.be_;

namespace nilnul.geometry.planar.coil_.gon_.poly.be_
{
	/// <summary>
	/// </summary>
	static public class _Cycle4dblX
	{



		/// <summary>
		/// adjacent grads are not folded back (one grad goes back to be incident with the other). note: adjacent grads can be angulated 180deg, that is they can goes in the same ray direction.
		/// nonadjacent grads cannot be joint.
		/// </summary>
		/// <param name="_arrows_froPolyDifPoints"></param>
		/// <param name="allowance"></param>
		/// <returns></returns>
		static public bool _Simple_ofPolyDif(
			IEnumerable<grad_.Skid4dblI> _arrows_froPolyDifPoints
			,
			double allowance = 0.001
		)
		{
			var foldBe = new curve_.polystep_.di.be_.Foldback4dbl(allowance);

			var prevGrad = _arrows_froPolyDifPoints.Last();

			var grownList = new List<grad_.Skid4dblI>();

			int i = 0;

			for (; i < _arrows_froPolyDifPoints.Count() - 1; i++)
			{
				//make sure it's not in the same line as previous Step
				var current = _arrows_froPolyDifPoints.ElementAt(i);

				if (
					foldBe.be(
					prevGrad.basis
					,
					current.basis
					,
					current.finish
				))
				{
					return false;
				}

#if DEBUG1

				if (
					nilnul.num.real.re_.approx_.ByInjected.Singleton.re(
						current.basis.x, 1.875
					)
				)
				{
					Debugger.Break();
				}
#endif

				if (grad_.skid.str.be_._JointOne4DblX._JointAny(
					nilnul.obj.str.op_.unary_._DetoeX.Detoe(grownList)

					,
					current
				))
				{
					return false;
				}

				grownList.Add(current);

				prevGrad = current;
			}

			var last = _arrows_froPolyDifPoints.ElementAt(i);

			if (foldBe.be(
				prevGrad.basis
				,
				last.basis
				,
				last.finish
			))
			{
				return false;
			}

			if (grad_.skid.str.be_._JointOne4DblX._JointAny(
				//nilnul.obj.str.op_.unary_.
				nilnul.obj.str.op_.unary_._MainX.Main(
					grownList.Skip(1)
				)
				, last
			))
			{
				return false;
			}
			return true;



		}

		static public //num.real_.NonnegOfDouble
			double ErrRadius = 0.001;// nilnul.num.real.be_.AboutNil4Dbl.Injected.radius.ee*1000000;

		static public bool _Simple_ofPolyDif(
			IEnumerable<grad_.Skid4dblI> _arrows_froPolyDifPoints
	
		)
		{
			return _Simple_ofPolyDif(
				_arrows_froPolyDifPoints, ErrRadius
			);



		}

		static public bool _Simple_ofPolyDif(IEnumerable<Point4dblI> _points_polyDif)
		{




			return _Simple_ofPolyDif(
				_GradsX.Grads(_points_polyDif).Select(x => new grad_.Skid4dbl(x))
			);
		}


		public static bool Be(point.str_.poly_.Distinct4dbl points)
		{
			return _Simple_ofPolyDif(points.ee);
		}


		public static bool _Be_assumePoly(IEnumerable<Point4dblI> points)
		{
			if (point.str.be_.Distinct.Singleton.be(points))
			{
				return _Simple_ofPolyDif((points));
			}
			return false;

		}
	}
}
