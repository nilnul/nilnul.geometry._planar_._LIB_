using nilnul.num.real_;
using nilnul.num.real_.nonneg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.tope_._bloc
{
	/// <summary>
	/// no unit, or in other words, unit is appended later. can be a tend, or a point.
	/// </summary>
	/// <remarks>
	/// alias:
	///		size
	///			when in 1d geometry, this is called lenght(长“度”) (distance（距离） without unit)
	///				area in 2d is what distance is to 1d.
	///		to avoid confusion (as in screen, we call it width in the horizontal direction; in living/furniture, we use 'width' to mean from near to more further or from our back to our front and 'length' for the horizontal direction) , we avoid the use of 'length' for any axis.
	///			"length" is not specificially used for x-axis, or y-axis. Rather, it can be used for either axis, or a line at any direction (for example, a slant line.)
	///			we follow the nomanclature of screens. 
	///			
	/// </remarks>
	public class SpreadDbl
		:
		nilnul.obj.Box1<nilnul.num.real_.nonneg.CoDbl>
	{
		

		public SpreadDbl(nilnul.num.real_.NonnegOfDouble x, nilnul.num.real_.NonnegOfDouble y ):base(new num.real_.nonneg.CoDbl( x,y))
		{
			
		}

		public SpreadDbl(double x, double y)
			:this(
				new nilnul.num.real_.NonnegOfDouble(x)
				,
				new nilnul.num.real_.NonnegOfDouble(y)
			)
		{

		}

		//public SpreadDbl(LengthD lengthD1, LengthD lengthD2) : this(
		//	lengthD1.abs*lengthD1.unit.AsMeters
		//	,
		//	lengthD2.abs*lengthD2.unit.AsMeters

		//)
		//{
		//}

		public System.Drawing.Size toSizeInt() {
			return new System.Drawing.Size(
				(int)this.width.realee.ee
				,
				(int)this.height.realee.ee

			);
		}

		public SpreadDbl(CoDbl val) : base(val)
		{
		}

		public SpreadDbl(NonnegOfDoubleI x, NonnegOfDoubleI y)
			:base(new num.real_.nonneg.CoDbl(x, y))
		{
		}

		public override string ToString()
		{
			return string.Format("{0}*{1}", boxed.Item1.ToString() ,boxed.Item2.ToString());
		}

		public double area() {
			return  this.width.realee * this.height.realee ;
		}
		public double aspect() {
			return  this.height.realee  / this.width.realee ;
		}


		static public SpreadDbl A4_inMeters = new SpreadDbl(0.210, 0.297);

		/// <summary>
		/// latitude
		/// </summary>
		public nilnul.num.real_.NonnegOfDoubleI width
		{
			get
			{
				return boxed.Item1;

			}
		}


		/// <summary>
		/// longitude
		/// </summary>
		public nilnul.num.real_.NonnegOfDoubleI height
		{
			get
			{
				return boxed.Item2;
				
			}
		}

		//public static SpreadDbl CreateFromInches(double x, double y)
		//{

		//	return new SpreadDbl(
		//		nilnul.geometry.LengthD.CreateFroInch(x)
		//		,
		//		nilnul.geometry.LengthD.CreateFroInch(y)

		//	);

		//}
		public static SpreadDbl CreateByAbs(double x, double y)
		{

			return new SpreadDbl( CoDbl.CreateByAbs(x,y) );

		}

		public static SpreadDbl OfByProportion(double x, double portion)
		{

			return new SpreadDbl(x, x * portion);
				;

		}

		public vect_.NonnegDbl toVector() {
			return new vect_.NonnegDbl(
				this.width
				,
				this.height
			);
		}

		static public SpreadDbl Of(nilnul.geometry.planar.Point4dbl x)
		{
			return CreateByAbs(
				x.x
				,

				x.y);
		}

		static public SpreadDbl Of(nilnul.geometry.planar.Vector4dblI x)
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

