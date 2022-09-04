using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;



namespace nilnul.geometry.planar
{
	


	[Obsolete(nameof(Vect4dbl))]
	public class VectorDbl : nilnul.obj.Box_pub< planar.Point4dbl>
		,Vector4dblI,
		Vect4dblI
	{
		public VectorDbl(Point4dbl val) : base(val)
		{
		}

		public VectorDbl(double a, double b) : this(new Point4dbl(a,b))
		{
		}



		public Point4dbl point => this.boxed;

		Point4dblI Vect4dblI.point => this.boxed;

		public VectorDbl getXFactor() {
			return new VectorDbl(this.boxed.x,0);
		}
		public VectorDbl getYFactor() {
			return new VectorDbl(0,this.boxed.y);
		}

		static public VectorDbl OfInterface(Vector4dblI x) {
			return x is VectorDbl y ? y : new VectorDbl(x.point);
		}
		static public implicit operator VectorDbl(Point4dbl origin){
			return new VectorDbl(
				origin
			);
		}

		static public Point4dbl operator +(Point4dbl origin, VectorDbl vector){
			return new Point4dbl(
				origin.x+vector.boxed.x
				,
				origin.y+vector.boxed.y
			);
		}

		static public Point4dbl Add(Point4dblI origin, Vector4dblI vector){
			return new Point4dbl(
				origin.x+vector.point.x
				,
				origin.y+vector.point.y
			);
		}

		static public Point4dbl operator -(Point4dbl origin, VectorDbl vector){
			return origin + -vector;
		}

		

		static public Point4dbl operator +( VectorDbl vector, Point4dbl origin)
		{
			return new Point4dbl(
				origin.x+vector.boxed.x
				,
				origin.y+vector.boxed.y
			);
		}

		static public Point4dbl operator +( VectorDbl vector, Vector4dblI origin)
		{
			return new Point4dbl(
				origin.point.x+vector.boxed.x
				,
				origin.point.y+vector.boxed.y
			);
		}

		static public VectorDbl operator -( VectorDbl vector)
		{
			return new VectorDbl(-vector.point);
		}


	}
}
