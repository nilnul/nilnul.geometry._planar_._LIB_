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
	public class VectorDbl : nilnul.obj.Box<PointDblI>,
		IEquatable<VectorDbl>
		,
		Vect4dblI

	{

		public VectorDbl(PointDblI val) : base(val)
		{
		}

		public VectorDbl(double x):this( new PointDbl(x))
		{

		}

		public VectorDbl(int i):this(new PointDbl(i) )
		{
		}

		public VectorDbl(PointDbl point):base((point))
		{
		}

		static public VectorDbl operator -(VectorDbl x,VectorDbl y) {
			return new VectorDbl(
				x.end.ToClass()
				-
				y.end
			);
		}




		public PointDblI end => boxed;

		static public bool operator <(VectorDbl v, int i) {

			return v.end.coord < i;;
		}

		static public bool operator >(VectorDbl v, int i) {

			return v.end.coord> i;;
		}



		static public implicit operator VectorDbl(PointDbl p) {
			return new VectorDbl(p);
		}

		static public implicit operator PointDbl(VectorDbl v) {
			return v.end.ToClass();
		}

		static public bool operator ==(VectorDbl v, VectorDbl i) {
			return v.end == i.end;
		}

		static public bool operator !=(VectorDbl v, VectorDbl i) {
			return !(v==i);
		}



		static public bool operator ==(VectorDbl v, int i) {
			return v == new VectorDbl(i);
		}

		static public bool operator !=(VectorDbl v, int i) {
			return ! (v == new VectorDbl(i) );
		}
		

		static public VectorDbl operator *(VectorDbl x, VectorDbl y) {
			return new VectorDbl( x.end.coord* y.end.coord );
		}

		static public VectorDbl operator -(VectorDbl x) {
			return new VectorDbl(-x.end.ToClass());
		}


		public override bool Equals(object obj)
		{
			return Equals(obj as VectorDbl);
		}

		public bool Equals(VectorDbl other)
		{
			return other != null &&
				   other == this;
		}

		public override int GetHashCode()
		{
			return end.GetHashCode();
		}
	}
}
