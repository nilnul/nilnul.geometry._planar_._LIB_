using System;
using System.Collections.Generic;
using System.Linq;
using nilnul.geometry.planar.point.str_;
//using nilnul.geometry.planar.point.str_.started;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
namespace nilnul.geometry.planar.sub_.directed_.connected_.polygon.be_
{
	/// <summary>
	/// no edges crossing each other; crossing means the intersected point is in the middle of some edge, that means, adjacency (share same endpoint), is not crossing.
	/// </summary>
	static public class _SimpleX
	{
		static public bool _CrossAny(IEnumerable<grad_.IArrow> arrows, grad_.IArrow arrow) {
			return arrows.Any(
				x =>
				nilnul.geometry.planar.grad_.skid.re_.Joint.Singleton.re(x,arrow)
				
			);
		}

		static public bool _CrossNone(IEnumerable<grad_.IArrow> arrows, grad_.IArrow arrow) {
			return nilnul.obj.str.be_._NoneX.None(
				arrows,
				
				x=>nilnul.geometry.planar.grad_.skid.re_.Joint.Singleton.re(x,arrow)
				
			);
		}



		static public bool _Simple_ofPolyDif(IEnumerable<grad_.IArrow> _arrows_froPolyDifPoints) {
			var grownList = new List<grad_.IArrow>();

			for (int i = 2; i < _arrows_froPolyDifPoints.Count()-1; i++)
			{
				var current = _arrows_froPolyDifPoints.ElementAt(i);

				if (_CrossAny(grownList, _arrows_froPolyDifPoints.ElementAt(i) ))
				{
					return false;
				}
				grownList.Add(_arrows_froPolyDifPoints.ElementAt(i));
			}
			return !_CrossAny(
				nilnul.obj.str_.started.to_.str_._TailX._Tail(grownList)
				, 
				_arrows_froPolyDifPoints.Last()
			);



		}

		static public bool _Simple_ofPolyDif(IEnumerable<Point1> _points_polyDif) {


			return _Simple_ofPolyDif(

				_GradsX.PointCoS(_points_polyDif).Select(x=>new grad_.Arrow(x))
			);
		}

		static public bool _Simple_ofPolyDif(IEnumerable<PointI1> _points_polyDif) {


			return _Simple_ofPolyDif(
				_GradsX.Grads(_points_polyDif).Select(x=>new grad_.Arrow(x))
			);
		}


		public static bool Be(point.str_.seq_.poly_.Dif points)
		{
			return _Simple_ofPolyDif(points.ee);
		}

		[Obsolete()]
		public static bool Be(Seq points)
		{
			return _Simple_ofPolyDif(points);

		}
	}
}
