using nilnul.geometry.planar.vect.be_.nonnil.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil_
{
	public class Polar4dbl
		:
		planar.Vector4dblI,
		planar.vect_.NonnilDblI
		,
		planar.vect_.Nonnil4dblI
	{
		private planar.point_.nonnil_.Polar4dbl _point;

		public Point4dbl point
		{
			get { return _point.toOrthogonal(); }
		}
		private planar.point_.nonnil_.Polar4dbl polarPoint
		{
			get
			{
				return _point;
			}
		}

		public EeDouble vectoree => new EeDouble(this);

		public Ee4dbl vectNonnil => throw new NotImplementedException();

		Point4dblI Vect4dblI.point => throw new NotImplementedException();

		public Polar4dbl(
			planar.point_.nonnil_.Polar4dbl polar4Dbl
		)
		{
			_point = polar4Dbl;
		}
		public Polar4dbl(point_.Polar4dbl polar4dbl) : this(new point_.nonnil_.Polar4dbl(polar4dbl))
		{
		}


		public Polar4dbl(double rotation, double radius)
			: this(
				 new point_.Polar4dbl(
					 rotation, radius
				)
		)
		{
		}

		public Polar4dbl(NonnilDbl nonnil):this(
			vect_.Polar4dbl.Of(nonnil)

		)
		{
			
		}

		public Polar4dbl(NonnilDblI nonnil):this(
			vect_.Polar4dbl.Of(nonnil)

		)
		{
			
		}


		public Polar4dbl(vect_.Polar4dbl polar4dbl)
			:this(
				 new planar.point_.nonnil_.Polar4dbl(polar4dbl.polarPoint)
			)
		{
		}

		public Polar4dbl(Nonnil4dbl nonnil):this(
			planar.point_.nonnil_.Polar4dbl.Of(nonnil)
		)
		{
		}

		public vect_.NonnilDbl toOrthogonal() {
			return new NonnilDbl(
				this
			);
		}


		static public Polar4dbl Add(Polar4dbl nonnil, nilnul.num.real_.NonnegOfDouble extension) {
			return new Polar4dbl(
				nonnil.polarPoint.azimuth
				,
				nonnil.polarPoint.radius+extension
			);
		}

		public static Polar4dbl Add(NonnilDbl vector, num.real_.NonnegOfDouble length)
		{
			return Add(
				new Polar4dbl(vector)
				,
				length
			);
		}
		public static Polar4dbl Add(NonnilDblI vector, num.real_.NonnegOfDouble length)
		{
			return Add(
				new Polar4dbl(vector)
				,
				length
			);
		}

		static public Polar4dbl operator +(Polar4dbl nonnil, nilnul.num.real_.NonnegOfDouble extension) {
			return Add(nonnil,extension);
		}

	}
}
