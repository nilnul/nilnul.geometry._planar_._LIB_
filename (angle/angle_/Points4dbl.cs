using nilnul.geometry.planar.grad_.skid;
using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle_
{
	public class Points4dbl
		:
		nilnul.geometry.planar.point.trio.be_.steps.vow.Ee4dbl
		,
		IAngleD
	{





		public Point4dbl pivot
		{
			get { return ee.b; }

		}

		[Obsolete("not in line with " + nameof(point.TrioD), true)]
		public Points4dbl(
			Point4dblI pivot
			,
			Point4dblI ray
			,
			Point4dblI ray1
		) : base(
			new TrioD(
			pivot,

			ray,
			ray1
				)
		)
		{


		}
		static public Points4dbl OfPivotIniEnd(
			Point4dblI pivot
			,
			Point4dblI ray
			,
			Point4dblI ray1
		)
		{
			return new Points4dbl(
				new TrioD(

					ray,
					pivot,

					ray1
				)
			);
		}

		[Obsolete("not in line with " + nameof(point.TrioD), true)]

		public Points4dbl(
			Point4dbl pivot
			,
			Point4dbl ray
			,
			Point4dbl ray1
		) : base(
			pivot,
			ray,
			ray1)
		{


		}
	static public Points4dbl OfPivotIniEnd(
			Point4dbl pivot
			,
			Point4dbl ray
			,
			Point4dbl ray1
		)
		{
			return new Points4dbl(
				new TrioD(

					ray,
					pivot,

					ray1
				)
			);
		}
		public Points4dbl(IEnumerable<Point4dbl> enumerable) : this(new TrioD(enumerable))
		{
		}

		public Points4dbl(TrioD val) : base(val)
		{
		}



		public double angle
		{
			get
			{
				return
					nilnul.geometry.planar.vect_.nonnil.co._RotationX.Direction(
						-this.inward.Vector()
						,
						this.outward.Vector()
					);
			}

		}



		public IRayDbl initial => new ray_.OnArrowDbl(
					this.ee.b,this.ee.a
		);
		public IRayDbl finish => new ray_.OnArrowDbl(
					this.ee.b,this.ee.c
		);


		public double azimuth => angle;
	}
}
