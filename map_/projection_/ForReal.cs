using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.linear;

namespace nilnul.geometry.planar.vect.as_
{
	/// <summary>
	/// if the axis is nil, the projection collapse into 0-dimension.
	/// if the axis is not nil, the projection collapse into 1-dimension.
	/// project of another vector onto this as an axis.  (can be zero).
	/// the projections may strectch the operated vector, for example,  lengthen it or shorten it
	/// </summary>
	public class Base :
		nilnul.obj.Box<IVector>
		,
		nilnul.obj._op.GenericI<IVector, nilnul.geometry.linear.Vector>
		
	{
		public Base(IVector val) : base(val)
		{
		}

		public Base(Vector1 v):this((IVector)v )
		{

		}

		public Base(Point1 point):this(new Vector1(point))
		{
		}


		public IVector vector
		{
			get { return boxed; }
		}





		public nilnul.geometry.linear.Vector op(IVector arg)
		{
			return new linear.Vector( 
				nilnul.geometry.planar.vect.co.to_.real_._DotProductX.RealI(arg,boxed) 
			);
			//throw new NotImplementedException();
		}
		public linear.Vector opOfSelf() {
			return op(this.boxed);
		}


		public linear.Vector op(Vector1 v) {
			return op((IVector)v);
		}
		public linear.Vector op(Point1 point)
		{
			return op(
				new Vector1(point)
			);
		//	throw new NotImplementedException();
		}


		public nilnul.num.RealI projectSelfAsReal() {
			return nilnul.geometry.planar.vect.co.to_.real_._DotProductX.RealI(boxed, boxed);
		}

		public nilnul.num.real_.NonnegI projectSelfAsNonneg() {
			return new nilnul.num.real_.Nonneg( projectSelfAsReal());
		}

	}
}
