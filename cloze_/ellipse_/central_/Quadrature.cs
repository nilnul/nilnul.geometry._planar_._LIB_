using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.ellipse_.centered_
{
	/// <summary>
	/// 
	/// </summary>
	internal class Quadrature
		: planar._troll_.Fn4dblI
	{
		double radiusX;
		double radiusY;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="time">
		/// the angle of the point
		/// </param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Complex locus(double time)
		{
			return new Complex(
				radiusX* Math.Cos(time)
				,
				radiusY * Math.Sin(time)
			);
		}
	}
}
