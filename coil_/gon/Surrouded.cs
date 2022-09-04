using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.coil_.gon_;
using nilnul.geometry.planar.grad;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
using nilnul.geometry.planar.sub_.directed_.connected_.gon;
//using nilnul.geometry.planar.point.str_.started;
//using nilnul.geometry.planar.trail_.cloze_.polygon_.points;
using nilnul.num;

namespace nilnul.geometry.planar.coil_.gon
{
	/// <summary>
	/// the internal is to right, not to the left as defined traditionaly.
	/// The clockwise is positive, contratray to tradition in which counterclockwise is positive.
	/// </summary>
	/// the positive area is called facade.
	/// the negative area is called 
	static public class _SurroundedX
	{
		/// <summary>
		/// this might be negative
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		static public nilnul.num.RealI Stokes(this planar.point.str_.Seq points) {
			return nilnul.num.real.op_.binary.cumulator_.Sum.Singleton.accumulate(
				_GradsX.Grads_ifDwelt(  points).Select(x => x.Stokes())
			);
		}

	
		static public nilnul.num.RealI Stokes(this IEnumerable<PointI1> points) {
			return nilnul.num.real.op_.binary.cumulator_.Sum.Singleton.accumulate(
				_GradsX.Grads_ifDwelt(  points).Select(x => x.Stokes())
			);
		}

		static public nilnul.num.RealI Stokes(this IEnumerable<Point1> points) {
			return nilnul.num.real.op_.binary.cumulator_.Sum.Singleton.accumulate(
				_GradsX.Grads_ifDwelt(  points).Select(x => x.Stokes())
			);
		}

		static public nilnul.num.RealI Stokes( params PointI1[] headed) {
			return Stokes((IEnumerable<PointI1>) headed);
		}

		static public nilnul.num.RealI Stokes( params Point1[] headed) {
			return Stokes((IEnumerable<Point1>) headed);
		}
		

		static public double Stokes(IEnumerable<point.CoD> duos)
		{

			return  duos.Sum(

				x =>
				planar.grad._StokesX.Stokes(x)

				//x.integral()

			);
		}
		static public double Area(IEnumerable<point.CoD> duos)
		{

			return nilnul.num.real_.nonneg.coerce_._AbsX.Doub(  Stokes(duos) );
		}
		static public double Stokes(this IEnumerable<Point4dbl> points) {
			return (
				_GradsX.Grads(  points).Select(x => x.Stokes()).Sum()
			);
		}

		static public double Stokes(this IEnumerable<Point4dblI> points) {
			return (
				_GradsX.Grads(  points).Select(x => x.Stokes()).Sum()
			);
		}

		static public double Stokes(params Point4dbl[] points) {
			return (
				Stokes( (IEnumerable<Point4dbl>)points)
			);
		}
		static public double Stokes(params Point4dblI[] points) {
			return (
				Stokes( (IEnumerable<Point4dblI>)points)
			);
		}


		public static double Area(IEnumerable<Point4dbl> ee)
		{
			return nilnul.num.real_.nonneg.coerce_._AbsX.Doub(  Stokes(ee) );

		}

		public static double Area(TrioD ee)
		{
			return Area((IEnumerable<Point4dbl>)ee);

		}

		static public double Stokes(IEnumerable<planar.Grad4dbl> duos)
		{

			return duos.Sum(x =>
				planar.grad._StokesX.Stokes(x)

			);
		}

		static public double Area(IEnumerable<planar.Grad4dbl> duos)
		{

			return nilnul.num.real_.nonneg.coerce_._AbsX.Doub(  Stokes(duos) );
		}
		public static double Stokes(Gon4dblI ee)
		{
			return Stokes(ee.vertexes);
		}

		public static double Stokes(Poly4dbl ee)
		{
			return Stokes(ee.ee);
		}

	}
}
