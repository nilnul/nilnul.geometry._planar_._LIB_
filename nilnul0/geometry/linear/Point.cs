using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear
{


	public struct Point:PointI
	{
		private nilnul.num.RealI _x;

		public nilnul.num.RealI x
		{
			get { return _x; }
			set { _x = value; }
		}


		[Obsolete()]
		public nilnul.num.RealI coord
		{
			get { return _x; }
		}




		public Point(nilnul.num.RealI x)
		{
			_x = x;

		}


		public Point(int i) : this( new nilnul.num.real_.Quotient(i))
		{
		}

		public Point(PointI point) : this( point.x)
		{
		}

		static public bool operator  == (Point x, int y){
			return x.x.ToReal() ==y;
		}

		static public bool operator  != (Point x, int y){
			return ! ( x ==y );
		}

		static public bool operator  == (int x, Point y){
			return y == x;
		}

		static public bool operator  != ( int y, Point x)
		{
			return ! ( y == x);
		}



		static public Point operator  - (Point x, Point y){
			return new Point(
				x.x.ToReal()- y.x.ToReal()
			);
		}
		static public Point operator  - (Point x, PointI y){
			return new Point(
				x.x.ToReal()- y.x.ToReal()
			);
		}

		static public Point operator  - (PointI x, Point y){
			return new Point(
				x.x.ToReal()- y.x.ToReal()
			);
		}


		static public bool operator  < (PointI x, Point y){
			return x.x.ToReal()<y.x;
		}
		static public bool operator  < (Point x, PointI y){
			return x.x<y.x.ToReal();
		}

		static public bool operator  > (PointI x, Point y){
			return x.x.ToReal()>y.x;
		}

		static public bool operator  > (Point x, PointI y){
			return x.x.ToReal()>y.x;
		}





	}
}
