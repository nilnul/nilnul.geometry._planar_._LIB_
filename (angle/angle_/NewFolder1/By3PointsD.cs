using nilnul.geometry.planar.grad_.skid;
using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle_
{
	[Obsolete(nameof(angle_.Points4dbl),true)]
	public  class By3PointsD
		:
		nilnul.geometry.planar.point.trio.be_.steps.vow.Ee4dbl
		,
		IAngleD
	{

		/// <summary>
		/// inward
		/// </summary>
		public Point4dbl point
		{
			get { return this.ee.a; }
			set { this.ee.a = value; }
		}


		public Point4dbl point1
		{
			get { return ee.c; }
			set { ee.c = value; }
		}
		


		public Point4dbl pivot
		{
			get { return ee.b; }
			set { ee.b = value; }
		}


		public By3PointsD(
			Point4dblI pivot
			,
			Point4dblI ray
			,
			Point4dblI ray1
		):base(
			new TrioD(
			ray,
			pivot ,
			ray1
				)
		)
		{
			

		}

		public By3PointsD(
			Point4dbl pivot
			,
			Point4dbl ray
			,
			Point4dbl ray1
		):base(ray, pivot , ray1)
		{
			

		}

		public By3PointsD(IEnumerable<Point4dbl> enumerable):this(new TrioD(enumerable) )
		{
		}

		public By3PointsD(TrioD val) : base(val)
		{
		}

		



		public double angle{
			get
			{
				return
					nilnul.geometry.planar.vect_.nonnil.co._RotationX.Direction(start.Vector(), stop.Vector());
			}
		
		}

	

		public IRayDbl initial =>new ray_.OnArrowDbl(
					pivot
					,
					point
		); 

		public double azimuth => angle;
	}
}
