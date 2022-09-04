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
	


	public class Vect4dbl
		: nilnul.obj.Box1< planar.Point4dblI>
		,
		Vect4dblI
		,Vector4dblI
	{
		public Vect4dbl(Point4dblI val) : base(val)
		{
		}

		public Vect4dbl(double a, double b) : this(new Point4dbl(a,b))
		{
		}



		public Point4dblI point => this.boxed;

		Point4dbl Vector4dblI.point => this.boxed.ToOrthogonal();

		public Vect4dbl getXFactor() {
			return new Vect4dbl(this.boxed.x,0);
		}
		public Vect4dbl getYFactor() {
			return new Vect4dbl(0,this.boxed.y);
		}

		static public Vect4dbl Of(Vect4dblI x) {
			return x is Vect4dbl y ? y : new Vect4dbl(x.point);
		}
		static public Vect4dbl CreateSymmetry(double x) {
			return  new Vect4dbl(x,x) ;
		}

		static public implicit operator Vect4dbl(Point4dbl origin){
			return new Vect4dbl(
				origin
			);
		}

		static public Point4dbl Add(Point4dbl origin, Vect4dblI vector){
			return new Point4dbl(
				origin.x+vector.point.x
				,
				origin.y+vector.point.y
			);
		}

		static public Point4dbl operator +(Point4dbl origin, Vect4dbl vector){
			return new Point4dbl(
				origin.x+vector.boxed.x
				,
				origin.y+vector.boxed.y
			);
		}

		static public Point4dbl operator +(Point4dblI origin, Vect4dbl vector){
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

		static public Point4dbl operator -(Point4dbl origin, Vect4dbl vector){
			return origin + -vector;
		}

		//static public PointDbl operator -(PointDbl origin, Vect4dblI vector){
		//	return  origin +
		//		planar.vector.op_.unary_.Neg4dbl.Singleton.op(
		//			vector
		//		);
		//}

		

		static public Point4dbl operator +( Vect4dbl vector, Point4dbl origin)
		{
			return new Point4dbl(
				origin.x+vector.boxed.x
				,
				origin.y+vector.boxed.y
			);
		}

		static public Point4dbl operator +( Vect4dbl vector, Vector4dblI origin)
		{
			return new Point4dbl(
				origin.point.x+vector.boxed.x
				,
				origin.point.y+vector.boxed.y
			);
		}

		/// <summary>
		/// as complex number
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="origin"></param>
		/// <returns></returns>
		static public Vect4dbl operator *( Vect4dbl vector, Vect4dblI origin)
		{
			return vect.op_.binary_._MultiX.Op(vector,origin);
		}


		static public Vect4dbl operator -( Vect4dbl vector)
		{
			return new Vect4dbl(
				-vector.point.ToOrthogonal()
			);
		}


	}
}
