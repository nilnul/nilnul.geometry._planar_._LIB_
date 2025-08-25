using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.Real;

using Q1 = nilnul.num.Quotient1;


namespace nilnul.geometry.planar
{
	 public  class Point : planar.PointI1
	{
		private R _x;

		public R x
		{
			get { return _x; }
			set { _x = value; }
		}

		private R _y;

		public R y
		{
			get { return _y; }
			set { _y = value; }
		}


		public Point(
			R x,R y
			
			)
		{
			_x = x;
			_y = y;

		}
		public Point(nilnul.num.real_.Quotient x, nilnul.num.real_.Quotient y)
			:this(
				new nilnul.num.Real(x) 
				 ,
				new nilnul.num.Real(y) 
			)
		{

		}

		public Point(Q1 x, Q1 y)
			:this(
				new nilnul.num.real_.Quotient(x) 
				 ,
				new nilnul.num.real_.Quotient(y) 
			)
		{

		}

		public Point(planar.PointI1 point)
			:this(point.x,point.y)
		{
		}

	


	}
}
