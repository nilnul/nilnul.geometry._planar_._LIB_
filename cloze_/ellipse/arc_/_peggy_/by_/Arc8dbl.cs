using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.elliptic_
{
	/// <summary>
	/// given two points, the formula for ellipsis can be solved.
	/// </summary>
	public class Arc8dbl
	{
		private num.real_.NonnegOfDoubleI _major;

		public num.real_.NonnegOfDoubleI major
		{
			get { return _major; }
			set { _major = value; }
		}

		public double majorAsDbl
		{
			set { _major = new num.real_.NonnegOfDouble( value );
			}
			get {
				return _major.realee.ee;
			}
		}


		private num.real_.NonnegOfDoubleI _minor;

		public num.real_.NonnegOfDoubleI minor
		{
			get { return _minor; }
			set { _minor = value; }
		}

		public double minorAsDbl
		{
			set { _minor = new num.real_.NonnegOfDouble( value ); }
			get => _minor.realee.ee;
		}



		private double _rotation;

		public double rotation
		{
			get { return _rotation; }
			set { _rotation = value; }
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
		public Complex end8complex {
			get {
				return planar.PointX.ToComplex(_end);
			}
		}

		private planar.Point4dblI _end;

		public Arc8dbl(
			Complex start
			, double radiusX, double radiusY
			, double rotation
			, bool large	/// 
			, bool sweep	/// from down below or from top lower?
			, Complex end
		)
		{
			this._start = (Point4dbl) start;

			this.majorAsDbl = radiusX;
			this.minorAsDbl = radiusY;

			this._rotation = rotation;

			this._large = large;
			this._sweep = sweep;

			this._end=  (Point4dbl) end;

		}
		public Arc8dbl( (double ,double) start
			, double radiusX, double radiusY
			, double rotation
			, bool large
			, bool sweep
			, (double,double) end
		):
			this(
				new Complex(start.Item1,start.Item2)
				,radiusX,radiusY
				,rotation
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