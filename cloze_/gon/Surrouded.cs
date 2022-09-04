using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.grad;
using nilnul.geometry.planar.grad.trigonize.parlgrm.range.lateral;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
//using nilnul.geometry.planar.point.str_.started;
//using nilnul.geometry.planar.trail_.cloze_.polygon_.points;
using nilnul.num;

namespace nilnul.geometry.planar.cloze_.gon
{
	/// <summary>
	/// the internal is to right, not to the left as defined traditionaly.
	/// The clockwise is positive, contratray to tradition in which counterclockwise is positive.
	/// </summary>
	/// the positive area is called facade.
	/// the negative area is called flipside
	/// alias:
	///		stokes
	///		green's
	static public class _SurroundedX
	{

		static public double _Stokes_ofStarted(this IEnumerable<Point4dblI> points) {
			return (
				_Grads4dblX._Grads_ofStarted(  points).Select(x => x.Stokes()).Sum()
			);
		}
		static public double _Stokes_ofStarted(params Point4dblI[] points) {
			return _Stokes_ofStarted(
				(IEnumerable<Point4dblI>)points
			);
		}

		static public double _StokesDoubled_ofStarted(this IEnumerable<Point4dblI> points) {
			return (
				_Grads4dblX._Grads_ofStarted(  points).Select(x => x.StokesDoubled()).Sum()
			);
		}





		static public double _StokesDoubled_ofStarted(params Point4dblI[] points) {
			return _StokesDoubled_ofStarted(
				(IEnumerable<Point4dblI>)points
			);
		}

	

	}
}
