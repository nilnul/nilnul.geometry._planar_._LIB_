using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear
{
	/// <summary>
	/// from origin to point
	/// </summary>
	public class Vector : nilnul.obj.Box<Point>,
		IEquatable<Vector>
		,
		VectI

	{

		public Vector(Point val) : base(val)
		{
		}

		public Vector(nilnul.num.RealI x):this( new Point(x))
		{

		}

		public Vector(int i):this(new Point(i) )
		{
		}

		public Vector(PointI point):this(new Point(point))
		{
		}

		static public Vector operator -(Vector x,Vector y) {
			return new Vector(x.x.ToReal()-y.x.ToReal());
		}



		public nilnul.num.RealI x
		{
			get { return boxed.x; }
		}

		public nilnul.num.RealI coord { get { return x; } }

		public PointI end => boxed;

		static public bool operator <(Vector v, int i) {

			return v.x.ToReal() < i;;
		}

		static public bool operator >(Vector v, int i) {

			return v.x.ToReal() > i;;
		}



		static public implicit operator Vector(Point p) {
			return new Vector(p);
		}

		static public implicit operator Point(Vector v) {
			return v.boxed;
		}

		static public bool operator ==(Vector v, Vector i) {
			return v.x.ToReal() == i.x.ToReal();
		}

		static public bool operator !=(Vector v, Vector i) {
			return !(v==i);
		}



		static public bool operator ==(Vector v, int i) {
			return v == new Vector(i);
		}

		static public bool operator !=(Vector v, int i) {
			return ! (v == new Vector(i) );
		}
		static public implicit operator Vector(nilnul.num.Real x) {
			return new Vector(x);
		}

		static public Vector operator *(Vector x, Vector y) {
			return x.x.ToReal() * y.x.ToReal();
		}

		static public Vector operator -(Vector x) {
			return new Vector(-x.x.ToReal());
		}


		public override bool Equals(object obj)
		{
			return Equals(obj as Vector);
		}

		public bool Equals(Vector other)
		{
			return other != null &&
				   nilnul.num.real.Eq.Singleton.Equals(x, other.x);
		}

		public override int GetHashCode()
		{
			return -1469483106 + nilnul.num.real.Eq.Singleton.GetHashCode(x);
		}
	}
}
