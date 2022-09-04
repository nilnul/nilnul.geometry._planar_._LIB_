using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.curve_.eg_
{
	/// <summary>
	/// r=a( 1-cos(theta) ), like apple or ass
	/// </summary>
	public class HeartDbl 
	{
		private double _x;

		public double x
		{
			get { return _x; }
			set { _x = value; }
		}

		private double _y;

		public double y
		{
			get { return _y; }
			set { _y = value; }
		}

		public HeartDbl(double x, double y) 
		{
			_x = x;
			_y = y;
		}

		
		
	}
}
