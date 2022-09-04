using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.Real;
using RI = nilnul.num.RealI;

using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.geometry.planar
{
	 public  class Point1 : PointI1
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


		public Point1(
			R x,R y
			
			)
		{
			_x = x;
			_y = y;

		}
		public Point1(long a,long b):this( new nilnul.num.real_.Quotient(a),  new nilnul.num.real_.Quotient(b) )
		{

		}
		public Point1(int a,int b):this( new nilnul.num.real_.Quotient(a),  new nilnul.num.real_.Quotient(b) )
		{

		}
		public Point1(nilnul.num.real_.Quotient x, nilnul.num.real_.Quotient y)
			:this(
				new nilnul.num.Real(x) 
				 ,
				new nilnul.num.Real(y)
			)
		{

		}

		public Point1(Q1 x, Q1 y)
			:this(
				new nilnul.num.real_.Quotient(x) 
				 ,
				new nilnul.num.real_.Quotient(y)
			)
		{

		}

		[Obsolete(nameof(Of))]
		public Point1(PointI1 point)
			:this(point.x,point.y)
		{
		}
		static public Point1 Of(PointI1 point) {
			return point switch {
				Point1 a=>a
				, _=> new Point1(point.x,point.y)
			};
		}

		public Point1(RI realI1, RI realI2):this(new R(realI1),new R(realI2))
		{
		}

		static public Point1 operator -(Point1 a, Point1 b)
		{
			return nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine(a, b);
		}
		static public Point1 operator -(Point1 a, PointI1 b)
		{
			return nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine(a, b);
		}


		static public PointI1 operator -(PointI1 a, Point1 b)
		{
			return nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine(a, b);
		}

		static public Point1 operator +(Point1 a, PointI1 b)
		{
			return nilnul.geometry.planar.point.co.band_.Add.Singleton.combine(a, b);
		}

		static public PointI1 operator +(PointI1 a, Point1 b)
		{
			return nilnul.geometry.planar.point.co.band_.Add.Singleton.combine(a, b);
		}

		static public bool operator ==(Point1 a, Point1 b)
		{
			return nilnul.geometry.planar.point.Eq2.Singleton.Equals(a, b);
		}

		static public bool operator !=(Point1 a, Point1 b)
		{
			return !(a== b);
		}

		static public bool operator ==(Point1 a, PointI1 b)
		{
			return nilnul.geometry.planar.point.Eq2.Singleton.Equals(a, b);
		}

		static public bool operator !=(Point1 a, PointI1 b)
		{
			return !(a== b);
		}


	}
}
