using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.tope_._bloc.size_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Spanned4dbl
		:
		nilnul.obj.Box1<(nilnul.num.real_.PositiveDblI, nilnul.num.real_.PositiveDblI)>
		,
		_bloc.Size4dblI
	{
		

		
		public Spanned4dbl((PositiveDblI, PositiveDblI) val) : base(val)
		{
		}

		public Spanned4dbl(PositiveDblI x, PositiveDblI y)
			:base((x, y))
		{
		}

		public Spanned4dbl(PositiveDbl x, PositiveDbl y)
			:base((x, y))
		{
		}

		public Spanned4dbl(double x, double y)
			:this(
				new nilnul.num.real_.PositiveDbl(x)
				,
				new nilnul.num.real_.PositiveDbl(y)
			)
		{

		}

		public Spanned4dbl(SpreadDbl size1)
			:this(
				 size1.width,size1.height
				)
		{
		}

		public Spanned4dbl(NonnegOfDoubleI width1, NonnegOfDoubleI height1)
			:this(
				 width1.realee,height1.realee
			)
		{
		}

		/// <summary>
		/// latitude
		/// </summary>
		public nilnul.num.real_.PositiveDblI width
		{
			get
			{
				return boxed.Item1;

			}
		}

		

		/// <summary>
		/// longitude
		/// </summary>
		public nilnul.num.real_.PositiveDblI height
		{
			get
			{
				return boxed.Item2;
				
			}
		}

		NonnegOfDoubleI Size4dblI.width =>new NonnegOfDouble(this.width.dblen.ee);

		NonnegOfDoubleI Size4dblI.height =>new NonnegOfDouble(this.height.dblen.ee) ;

		public System.Drawing.Size toSizeInt() {
			return new System.Drawing.Size(
				(int)this.width.dblen.ee
				,
				(int)this.height.dblen.ee

			);
		}
		public override string ToString()
		{
			return string.Format("{0}*{1}", boxed.Item1.ToString() ,boxed.Item2.ToString());
		}

		public double area() {
			return  this.boxed.Item1.dblen.ee * this.height.dblen.ee ;
		}
		static public Spanned4dbl A4_inMeters = new Spanned4dbl(0.210, 0.297);



		//public static SpreadDbl CreateFromInches(double x, double y)
		//{

		//	return new SpreadDbl(
		//		nilnul.geometry.LengthD.CreateFroInch(x)
		//		,
		//		nilnul.geometry.LengthD.CreateFroInch(y)

		//	);

		//}
		public static Spanned4dbl OfByAbs(double x, double y)
		{

			return new Spanned4dbl( Math.Abs(x),Math.Abs(y) );

		}

		public static Spanned4dbl OfByProportion(double x, double portion)
		{

			return new Spanned4dbl(x, x * portion);
				;

		}

		public vect_.Positives4dbl toVector() {
			return new vect_.Positives4dbl(
				this.width
				,
				this.height
			);
		}

		static public Spanned4dbl Of(nilnul.geometry.planar.Point4dbl x)
		{
			return OfByAbs(
				x.x
				,

				x.y);
		}

		static public Spanned4dbl Of(nilnul.geometry.planar.Vector4dblI x)
		{
			return Of(x.point);
		}

		static public SizeF Coerce2float_ofSquare(double x) {
			float y = (float)x;
			return new SizeF(
				y,y
			);
		}

	}
}

