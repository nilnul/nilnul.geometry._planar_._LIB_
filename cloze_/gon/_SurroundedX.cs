using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.grad;
using nilnul.geometry.planar.grad.trigonize.parlgrm.diag_.originated.drag.bunch_;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
//using nilnul.geometry.planar.point.str_.started;
//using nilnul.geometry.planar.trail_.cloze_.polygon_.points;
//using nilnul.num;

namespace nilnul.geometry.planar.cloze_.gon
{
	/// <summary>
	/// the internal is to right, not to the left as defined traditionaly.
	/// The clockwise is positive, contratray to tradition in which counterclockwise is positive.
	/// </summary>
	/// <remarks>
	/// for each point or an area enclosed but no edges passing thru, if it's winded n times, and antiwinded m times, then the sign is n-m, which can be -2,-3,0,1, or 5, and is called winding number.
	/// Here this is the winding number * the absolute area.
	/// </remarks>
	/// the positive area is called facade. <see cref="cycle_.gon_.Facade4dbl"/>
	/// the negative area is called flipside. <see cref="cycle_.gon_.Antiwise4dbl"/>
	/// alias:
	///		stokes
	///			,ending s might be mistaken as a plural;
	///		green's
	static public class _SurroundedX
	{
		public static double _Surround_0started(IEnumerable< (double,double)> a)
		{
			return _SurroundDoubled_0started(a) / 2;
			//return _GradsX._Grads_0started(a).Select(
			//	x =>
			//	nilnul.geometry.planar.grad.shade.rect._SurroundX.Surround(x)
				
			//).Sum() /2;
		}
		public  static double _Surround_0cloze(IEnumerable<Grad4dbl_byPointsI> c)
		{
			return _SurroundDoubled_0cloze(c) / 2;
		}


		static public double _Stokes_ofStarted(this IEnumerable<Point4dblI> points) {

			return _Surround_0started(
				points.Select(p=>(p.x,p.y))
			);
			//return (
			//	_Grads4dblX._Grads_ofStarted(  points).Select(x => x.Stokes()).Sum()
			//);
		}
		static public double _Surround_0started(this IEnumerable<Point4dblI> points) {

			return _Surround_0started(
				points.Select(p=>(p.x,p.y))
			);
			//return (
			//	_Grads4dblX._Grads_ofStarted(  points).Select(x => x.Stokes()).Sum()
			//);
		}

		static public double _Stokes_ofStarted(params Point4dblI[] points) {
			return _Stokes_ofStarted(
				(IEnumerable<Point4dblI>)points
			);
		}


		public static double _Surround_0started(IEnumerable< Complex> a)
		{
			return _Surround_0started(
				a.Select(p=>(p.Real,p.Imaginary))
			);

			//return _GradsX._Grads_0started(a).Select(
			//	x =>
			//	nilnul.geometry.planar.grad.shade.rect._SurroundX.Surround(x)
				
			//).Sum() /2;
		}

		public static double _Surround_0started(params Complex[] a)
		{
			return _Surround_0started( (IEnumerable< Complex>) a);
		}

		public static double _SurroundDoubled_0cloze(IEnumerable< ((double,double),(double,double))> a)
		{
			return (a).Select(
				x =>
				nilnul.geometry.planar.grad.shade.rect._SurroundX.Surround(x)
				
			).Sum();
		}


		public static double _SurroundDoubled_0cloze(IEnumerable<(Point4dblI basis, Point4dblI finish)> enumerable)
		{
			return _SurroundDoubled_0cloze(
				enumerable.Select(
					g=>(
						(g.basis.x,g.basis.y)
						,
						(g.finish.x,g.finish.y)
					)
				)
			);
		}

		public static double _SurroundDoubled_0cloze(IEnumerable<Grad4dbl_byPointsI> c)
		{
			return _SurroundDoubled_0cloze(
				c.Select( a=>(a.basis,a.finish))
			);

			return c.Select(
				x =>
				nilnul.geometry.planar.grad.shade.rect._SurroundX.Surround(x)
				
			).Sum();

		}
		public static double _SurroundDoubled_0started(IEnumerable< (double,double)> a)
		{
			return _SurroundDoubled_0cloze( _Grads4dblX._CoEs_0dwelt(a));
		}

		/// <summary>
		/// we need to compare. So the division by two is not needed.
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		static public double _StokesDoubled_ofStarted(this IEnumerable<Point4dblI> points) {

			return _SurroundDoubled_0started(
				points.Select(p=>(p.x,p.y))
			);

	
		}

		static public double _SurroundDoubled_0started(this IEnumerable<Complex> points) {
			return _SurroundDoubled_0started(
				points.Select(p=>(p.Real,p.Imaginary))
			);

	
		}
		public static double _SurroundDoubled_0started(params Complex[] a)
		{
			return _SurroundDoubled_0started(
				(IEnumerable<Complex>)a
			)			;

		}




		static public double _StokesDoubled_ofStarted(params Point4dblI[] points) {
			return _StokesDoubled_ofStarted(
				(IEnumerable<Point4dblI>)points
			);
		}

	}
}
