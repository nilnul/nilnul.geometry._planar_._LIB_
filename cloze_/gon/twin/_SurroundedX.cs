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

namespace nilnul.geometry.planar.cloze_.gon.twin
{
	/// <summary>
	/// the surrounded is hence doubled. that is 2* the original surrounded;
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _SurroundedX
	{
	

		public static double _Surround_0cloze(IEnumerable< ((double,double),(double,double))> a)
		{
			return (a).Select(
				x =>
				nilnul.geometry.planar.grad.shade.rect._SurroundX.Surround(x)
				
			).Sum();
		}


		public static double _Surround_0cloze(IEnumerable<(Point4dblI basis, Point4dblI finish)> enumerable)
		{
			return _Surround_0cloze(
				enumerable.Select(
					g=>(
						(g.basis.x,g.basis.y)
						,
						(g.finish.x,g.finish.y)
					)
				)
			);
		}

		public static double _Surround_0cloze(IEnumerable<Grad4dbl_byPointsI> c)
		{
			return _Surround_0cloze(
				c.Select( a=>(a.basis,a.finish))
			);

			return c.Select(
				x =>
				nilnul.geometry.planar.grad.shade.rect._SurroundX.Surround(x)
				
			).Sum();

		}
		public static double _Surround_0started(IEnumerable< (double,double)> a)
		{
			return _Surround_0cloze( _Grads4dblX._CoEs_0dwelt(a));
		}

		/// <summary>
		/// we need to compare. So the division by two is not needed.
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		static public double _Surround_0started(this IEnumerable<Point4dblI> points) {

			return _Surround_0started(
				points.Select(p=>(p.x,p.y))
			);

	
		}

		static public double _Surround_0started(this IEnumerable<Complex> points) {
			return _Surround_0started(
				points.Select(p=>(p.Real,p.Imaginary))
			);

	
		}
		public static double _Surround_0started(params Complex[] a)
		{
			return _Surround_0started(
				(IEnumerable<Complex>)a
			)			;

		}



		static public double _Surround_0started(params Point4dblI[] points) {
			return _Surround_0started(
				(IEnumerable<Point4dblI>)points
			);
		}

	}
}
