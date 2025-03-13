using nilnul.num.complex.of_.binary_;
using nilnul.num.complex.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_
{
	/// <summary>
	/// defined by radiuses, and center, and rotation.
	/// </summary>
	public class Ellipse
		: planar._troll_.Fn4dblI
	{


		private nilnul.num.real_.NonnegOfDouble _radiusX;

		public nilnul.num.real_.NonnegOfDouble radiusX
		{
			get { return _radiusX; }
			set { _radiusX = value; }
		}

		private nilnul.num.real_.NonnegOfDouble _radiusY;

		public nilnul.num.real_.NonnegOfDouble radiusY
		{
			get { return _radiusY; }
			set { _radiusY = value; }
		}

		private C _center;

		public C center
		{
			get { return _center; }
			set { _center = value; }
		}

		private double _rotated;

		public double rotated
		{
			get { return _rotated; }
			set { _rotated = value; }
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="time">
		/// If one thinks of an ellipse as a circle that has been stretched and then rotated,referred to as center parameterization, the this is the the angle of the point prior to the stretch and rotate operations, not on the ellipse itself.
		/// </param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Complex locus(double time)
		{

			return new Complex(
				 Math.Cos(time)*radiusX 
				,
				Math.Sin(time)* radiusY 
			).Rotate( rotated)
			+ new Complex(center.Real , center.Imaginary)
			;

			return  Complex.FromPolarCoordinates(1,time) .Scale(
				 radiusX 
				,
				 radiusY 
			).Rotate( rotated)
			+ new Complex(center.Real , center.Imaginary)
			;


		}


	}
}
