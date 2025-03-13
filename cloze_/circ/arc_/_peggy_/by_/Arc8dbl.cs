using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.circ.arc_._peggy_.by_
{
	/// <summary>
	/// given two points, the formula for circ can be solved.
	/// </summary>
	public class Arc8dbl
	{
		/// <summary>
		/// </summary>
		private num.real_.NonnegOfDoubleI _radius;

		public num.real_.NonnegOfDoubleI radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public double radiusAsDbl
		{
			set { _radius = new num.real_.NonnegOfDouble( value );
			}
			get {
				return _radius.realee.ee;
			}
		}



		private bool _sweep;

		public bool sweep
		{
			get { return _sweep; }
			set { _sweep = value; }
		}


		private bool _large;

		public bool large
		{
			get { return _large; }
			set { _large = value; }
		}

		private planar.Point4dblI _start;

		public planar.Point4dblI start
		{
			get { return _start; }
			set { _start = value; }
		}

		public Complex start8complex {
			get {
				return planar.PointX.ToComplex(_start);
			}
		}

		/// <summary>
		/// when the end is the same as the start, and when the radius is not nil, and when the <see cref="_large"/> is true, then that means we need a full circle. To fix that circle, we need another parameter: tilt, to pin the angle between the chord and the center.
		/// </summary>
		private planar.Point4dblI _end;
		public Complex end8complex {
			get {
				return planar.PointX.ToComplex(_end);
			}
		}


		public double tilt { get; set; }


		public Arc8dbl(
			Complex start
			, double radiusX
			, bool large	/// 
			, bool sweep	/// from down below or from top lower?
			, Complex end
		)
		{
			this._start = (Point4dbl) start;

			this.radiusAsDbl = radiusX;


			this._large = large;
			this._sweep = sweep;

			this._end=  (Point4dbl) end;

		}
		public Arc8dbl( (double ,double) start
			, double radiusX, double radiusY
			, bool large
			, bool sweep
			, (double,double) end
		):
			this(
				new Complex(start.Item1,start.Item2)
				,radiusX
				,large
				,sweep
				,new Complex(end.Item1,end.Item2)

			)
		{
		}

		public planar.Point4dblI end
		{
			get { return _end; }
			set { _end = value; }
		}

		public planar.Tend4dbl chord {
			get {
				return new Tend4dbl(
					start,end
				);
			}
		}

	}
}