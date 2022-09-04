using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.point_
{
	public class Polar4dbl_radius1st
		:
		nilnul.obj.Box1<nilnul.num.complex_.Polar4dbl_radiusAllowNeg>
		,
	Point4dblI


	{
		public double azimuth { get { return boxed.azimuth; } }
		public double radius { get { return boxed.radius; } }

		public double x { get => radius * Math.Cos(this.azimuth); }
		public double y { get => radius * Math.Sin(azimuth); }

		public Polar4dbl_radius1st(nilnul.num.complex_.Polar4dbl_radiusAllowNeg complex):base(complex)
		{

		}

		public Polar4dbl_radius1st( double radius, double azimuth):this(
			new num.complex_.Polar4dbl_radiusAllowNeg(radius,azimuth)
		)
		{
			//this.azimuth = azimuth;
			//this.radius = radius;
		}
		public Point4dbl toStraight()
		{
			return ToPointD(this);
		}

		public void normalize() {
			boxed.normalize();
		}

		/// <summary>
		/// in Euler form
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			/// i is the imaginary unit
			return $"{radius}*e^i{azimuth}";
		}

		static public Point4dbl ToPointD(double radius, double angle)
		{
			return new Point4dbl(
				radius * Math.Cos(angle)
				,
				radius * Math.Sin(angle)
			);
		}

		public static Point4dbl ToPointD(Polar4dbl_radius1st polarD)
		{
			return ToPointD(polarD.radius, polarD.azimuth);
		}

		public static Polar4dbl_radius1st Of(Point4dbl point)
		{
			return new Polar4dbl_radius1st(
				planar.point._DeviationX.Deviation(point)
				,

				geometry.planar.vect._DirectionX._Ge0LtTau(point)

			);
		}

		public static Polar4dbl_radius1st Of(Point4dblI point)
		{
			return point switch
			{
				Polar4dbl_radius1st a => a
				,
				_ => new Polar4dbl_radius1st(
					planar.point._DeviationX.Deviation(point)
					,
					geometry.planar.vect._DirectionX._Ge0LtTau(point)

				)

			};

		}


	}
}
