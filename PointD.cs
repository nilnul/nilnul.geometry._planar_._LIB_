using nilnul.geometry.planar.point;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{

	public class Point4dbl : IEquatable<Point4dbl>, Point4dblI
	{
		private double _x;

		public double x
		{
			get { return _x; }
			set { _x = value; }
		}

		private double _y;
		public static readonly Point4dbl Origin = new Point4dbl();

		public double y
		{
			get { return _y; }
			set { _y = value; }
		}

		public Point4dbl(double x, double y)
		{
			this._x = x;
			this._y = y;

		}

		public Point4dbl() : this(0, 0)
		{
		}

		public Point4dbl(Point4dblI begin):this(begin.x,begin.y)
		{
		}

		public Point4dbl(NonnegOfDoubleI radius1, NonnegOfDoubleI radius2)
			:
			this(
				radius1.realee
				,
				radius2.realee
			)
		{
		}

		public Point4dbl(double v, NonnegOfDoubleI radius):this(v,radius.realee)
		{
		}

		public Point4dbl((double, double) p):this(p.Item1,p.Item2)
		{
		}

		public Point4dbl(Point p1):this(p1.X,p1.Y)
		{
		}

		public double distanceFroOrigin() {
			return geometry.planar.point._DeviationX.Deviation(this);
		}

		public double[] toArray()
		{
			return new double[] { x, y };
		}
		static public double[] ToArray(Point4dblI a)
		{
			return new double[] { a.x, a.y };
		}

		public PointF toPointF()
		{
			return new PointF(
				(float)x, (float)y
				);
		}

		public Point toPointInt()
		{
			return new Point(
				(int)x, (int)y
				);
		}


		static public Point4dbl Of(Point4dblI point) {
			return point switch
			{
				 Point4dbl a =>a
				 ,
				 _=> new Point4dbl(point.x,point.y)
			}
			;
		}
		public override string ToString()
		{
			return string.Format("({0})", string.Join(",", x, y));
		}


		public string ToTxt_bare(string separator = ",")
		{
			return string.Format("{0}{1}{2}", x, separator, y);


		}



		static public bool operator ==(Point4dbl x, Point4dbl y)
		{

			return x.x == y.x && x.y == y.y;

		}

		public static Point4dbl Of(PointF f)
		{
			return new Point4dbl(f.X,f.Y);
			//throw new NotImplementedException();
		}

		static public bool operator !=(Point4dbl x, Point4dbl y)
		{
			return !(x == y);
		}

		static public Point4dbl operator +(Point4dbl a, Point4dblI b)
		{
			return new Point4dbl(a.x + b.x, a.y + b.y);
		}

		static public Point4dbl operator +(Point4dblI a, Point4dbl b)
		{
			return new Point4dbl(a.x + b.x, a.y + b.y);
		}

		static public Point4dbl operator +(Point4dbl a, point_.Polar4dbl b)
		{
			return new Point4dbl(a.x + b.x, a.y + b.y);
		}

	

		static public Point4dbl operator +(Point4dbl a, Point4dbl b)
		{
			return new Point4dbl(a.x + b.x, a.y + b.y);
		}

		static public Point4dbl operator +(Point4dbl a, Vector4dblI b)
		{
			return a + b.point;
		}
		static public Point4dbl operator +(Point4dbl a, Vect4dblI b)
		{
			return a + b.point;
		}
		static public Point4dbl operator +(Point4dbl a, planar.vect_.Polar4dbl b)
		{
			return a + b.point;
		}
		static public Point4dbl operator -(Point4dbl a, planar.vect_.Polar4dbl b)
		{
			return a - b.point;
		}
		


		static public Point4dbl operator -(Point4dbl a, Point4dblI b)
		{
			return new Point4dbl(a.x - b.x, a.y - b.y);
		}

		static public Point4dbl operator -(Point4dblI a, Point4dbl b)
		{
			return new Point4dbl(a.x - b.x, a.y - b.y);
		}

		static public Point4dbl operator -(Point4dbl a, Vect4dblI b)
		{
			return a - b.point;
		}
		static public Point4dbl operator -(Point4dbl a, Vector4dblI b)
		{
			return a - b.point;
		}


		static public Point4dbl operator -(Point4dbl a, Point4dbl b)
		{
			return new Point4dbl(a.x - b.x, a.y - b.y);
		}


		static public Point4dbl operator *(double scale, Point4dbl a)
		{
			return new Point4dbl(scale * a.x, scale * a.y);
		}
		static public Point4dbl operator *(Point4dbl a, double scale)
		{
			return new Point4dbl(scale * a.x, scale * a.y);
		}

		static public Point4dbl operator /(Point4dbl a, double scale)
		{
			return a * (1 / scale);
		}

		static public Point4dbl operator -(Point4dbl b)
		{
			return new Point4dbl(-b.x, -b.y);
		}

		static public Point4dbl CreateZero()
		{
			return new Point4dbl(0, 0);
		}



		// override object.Equals
		public override bool Equals(object obj)
		{
			//       
			// See the full list of guidelines at
			//   http://go.microsoft.com/fwlink/?LinkID=85237  
			// and also the guidance for operator== at
			//   http://go.microsoft.com/fwlink/?LinkId=85238
			//

			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			var objAsPoint = obj as Point4dbl;
			if (objAsPoint.x == this.x && objAsPoint.y == this.y)
			{
				return true;

			}
			return false;

			// TODO: write your implementation of Equals() here

		}

		// override object.GetHashCode
		public override int GetHashCode()
		{

			return x.GetHashCode() ^ y.GetHashCode();
			// TODO: write your implementation of GetHashCode() here

		}

		public bool Equals(Point4dbl other)
		{
			return point.EqDbl.Singleton.Equals(this, other);
		}

		static public PointF Coerce2float(Point4dblI point4Dbl) {
			return new PointF(
				(float)point4Dbl.x
				,
				(float)point4Dbl.y
			);
		}
		 public PointF coerce2float() {
			return Coerce2float(this);
		}
	}
}
