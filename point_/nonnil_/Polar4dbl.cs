using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.point_.nonnil_
{
	public  class Polar4dbl
		
	{
		public double azimuth;
		public nilnul.num.real_.NonnilDbl radius;

		public Polar4dbl( double azimuth, nilnul.num.real_.NonnilDbl radius)
		{
			this.azimuth = azimuth;
			this.radius = radius;
		}

		public Polar4dbl(double v1, double v2):this(v1,new num.real_.NonnilDbl(v2) )
		{
		}

		public Polar4dbl(point_.Polar4dbl polar4dbl):this(
			polar4dbl.azimuth
			,
			polar4dbl.radius
		)
		{
		}

		public Point4dbl toOrthogonal() {
			return ToOrthogonal(this);
		}

		

		public static  Point4dbl ToOrthogonal(Polar4dbl polarD)
		{
			return point_.Polar4dbl.ToPointD(polarD.radius,polarD.azimuth);
		}

		public static Polar4dbl Of(Point4dblI point) {
			return new Polar4dbl(
				geometry.planar.vect._DirectionX._Ge0LtTau(point)
				,
				planar.point._DeviationX.Deviation(point)
			);
		}

		public static Polar4dbl Of(Point4dbl point) {
			return new Polar4dbl(
				geometry.planar.vect._DirectionX._Ge0LtTau(point)
				,

				planar.point._DeviationX.Deviation(point)
			);
		}

		public static Polar4dbl Of(vect_.Nonnil4dbl nonnil)
		{
			return Of(nonnil.point);
		}
	}
}
