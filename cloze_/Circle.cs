using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_
{
	/// <summary>
	/// 
	/// </summary>
	internal class Circle
		: planar._troll_.Fn4dblI
	{

		C _center;

		public C center
		{
			get { return _center; }
			set { _center = value; }
		}



		nilnul.num.real_.NonnegOfDouble _radius;

		public nilnul.num.real_.NonnegOfDouble radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public Circle(C center,nilnul.num.real_.NonnegOfDouble radius)
		{
			_center = center;
			_radius = radius;
		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="time">
		/// [0,2Pi)
		/// </param>
		/// <returns></returns>
		public Complex locus(double time)
		{

			return new Complex(
				_radius * Math.Cos(time)
				,
				radius * Math.Sin(time)
			) 
			+ center
			;

		}


	}
}
