using nilnul.geometry.planar.cloze_._ellipse_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse_
{
	///
	/// <summary>
	/// 
	/// </summary>
	public class Centered8origin
		:
		_ellipse_.Radiuses4dbl
		,
		_ellipse_.Rotated4dbl
		,
		_troll_.Fn4dblI
	{
		double _radiusX;
		double _radiusY;
		double _rotated;

		public double radiusX => _radiusX;

		public double radiusY => _radiusY;

		public double rotated => _rotated;

		public Centered8origin(
			double _radiusX
			,
			double radiusY
			,
			double rotated

		)
		{
			this._radiusX = _radiusX;
			this._radiusY = radiusY;
			this._rotated = rotated;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public Complex locus(double time)
		{
			///math.stackexchange.com/questions/1889450/extrema-of-ellipse-from-parametric-form
			return new Complex(
				radiusX * Math.Cos(time)

				,
				radiusY * Math.Sin(time)
			) * Complex.FromPolarCoordinates(1, _rotated);
		}
	}
}
