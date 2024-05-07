using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry._2d
{
	public class LineSegmentInDouble
	{
		private double _length;
		public double length
		{
			get {
				return _length;
			
			}
			set
			{

				if (length < 0)
				{
					throw new Exception("Lenght cannot be negative.");

				}
				_length = value;
			}
		}
		public LineSegmentInDouble(double length)
		{
			this.length = length;

		}


	}
}
