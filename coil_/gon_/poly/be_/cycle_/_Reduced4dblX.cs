using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;

namespace nilnul.geometry.planar.coil_.gon_.poly.be_.cycle_
{
	/// <summary>
	/// if two adjacent edges goes to the same direction, reduce the middle point.
	/// 
	/// no edges crossing each other; crossing means the intersected point is in the middle of some edge, that means, adjacency (share same endpoint), is not crossing.
	///
	/// </summary>
	static public class _Reduced4dblX
	{
		



			static public bool _Simple_ofPolyDif(
				IEnumerable<grad_.Skid4dblI> _arrows_froPolyDifPoints
				,
				double allowance = 0.001
			)
			{
				var foldBe = new curve_.polystep_.di.be_.Nonline4dbl(allowance);

				var prevGrad = _arrows_froPolyDifPoints.Last();

				var grownList = new List<grad_.Skid4dblI>();

				int i = 0;
				for (; i < _arrows_froPolyDifPoints.Count() - 1; i++)
				{
					//make sure it's not in the same line as previous Step
					var current = _arrows_froPolyDifPoints.ElementAt(i);

					if (foldBe.be(
						prevGrad.basis
						,
						current.basis
						,
						current.finish
					))
					{
						return false;
					}

					if (
					planar.grad_.skid.str.be_._JointOne4DblX. _JointAny(
						nilnul.obj.str.op_.unary_._MainX.Main(grownList)
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

				if (
				planar.grad_.skid.str.be_._JointOne4DblX._JointAny(
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


			public static bool Be_ofPolyDistinct(IEnumerable<Point4dblI> points)
			{
				return Be(new point.str_.poly_.Distinct4dbl(points));

			}
		}
	}
