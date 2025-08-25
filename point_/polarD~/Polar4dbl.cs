using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.point_
{
	/// <summary>
	/// azimuth(angle) first.
	/// </summary>
	///
	[Obsolete(nameof(Polar4dbl_radius1st))]
	public class Polar4dbl
		:
	Point4dblI


	{
		public double azimuth;
		public double radius;

		public double x { get => radius * Math.Cos(this.azimuth); }
		public double y { get => radius * Math.Sin(azimuth); }

		public Polar4dbl(double azimuth, double radius)
		{
			this.azimuth = azimuth;
			this.radius = radius;
		}

		public Point4dbl toStraight()
		{
			return ToPointD(this);
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

		public static Point4dbl ToPointD(Polar4dbl polarD)
		{
			return ToPointD(polarD.radius, polarD.azimuth);
		}

		public static Polar4dbl Of(Point4dbl point)
		{
			return new Polar4dbl(
				geometry.planar.vect._DirectionX._Ge0LtTau(point)
				,

				planar.point._DeviationX.Deviation(point)
			);
		}

		public static Polar4dbl Of(Point4dblI point)
		{
			return point switch
			{
				Polar4dbl a => a
				,
				_ => new Polar4dbl(
					geometry.planar.vect._DirectionX._Ge0LtTau(point)
					,

					planar.point._DeviationX.Deviation(point)
				)

			};

		}


	}
}
