using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.elliptic_
{
	/// <summary>
	/// given two points, the formula for ellipsis can be solved.
	/// </summary>
	public class Arc
	{
		private num.real_.NonnegOfDoubleI _major;

		public num.real_.NonnegOfDoubleI major
		{
			get { return _major; }
			set { _major = value; }
		}

		public double majorAsDbl
		{
			set { _major = new num.real_.NonnegOfDouble( value ); }
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
		}



		private double _rotation;

		public double rotation
		{
			get { return _rotation; }
			set { _rotation = value; }
		}


		private bool _clockwise;

		public bool clockwise
		{
			get { return _clockwise; }
			set { _clockwise = value; }
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

		private planar.Point4dblI _end;

		public planar.Point4dblI end
		{
			get { return _end; }
			set { _end = value; }
		}




	}
}
