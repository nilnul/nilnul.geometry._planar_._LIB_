using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.cloze_.circ


{

	
	/// <summary>
	/// given two points, the formula for ellipsis can be solved.
	/// This caters to the SVG use.
	/// </summary>
	public class Arc:IArc
	{

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


		private num.real_.NonnegOfDoubleI _radius;

		public num.real_.NonnegOfDoubleI radius
		{
			get { return _radius; }
			set { _radius = value; }
		}

		public double radiusAsDbl
		{
			set { _radius = new num.real_.NonnegOfDouble( value ); }
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





	}
}
