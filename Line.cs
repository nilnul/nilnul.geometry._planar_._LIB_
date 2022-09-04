using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point.twin_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using R = nilnul.num.Real;

namespace nilnul.geometry.planar
{
	public class Line :
		nilnul.geometry.planar.point.co_.Dif
		,
		LineI
	{

		public Point1 begin { get { return ee.begin; } }

		public Point1 end { get { return ee.end; } }
		public Line(planar.point.Co duo) : base(duo)
		{

		}

		public Line(RayI dir):this( planar.ray_._OnArrowX.Points(dir) )
		{
		}

		public Line((PointI1, PointI1) p):base(new Co( p.Item1,p.Item2 ))
		{
		}

		public Line(LeadI lead):this(lead.arrow)
		{
		}

		public Line(IArrow arrow):this(arrow.points.ee.begin,arrow.points.ee.end)
		{
		}

		public Line(Point1 begin1, Point1 end1):this((begin1,end1))
		{
		}


		/// <summary>
		/// the angle with x; normalized to be in [0,pi)
		/// </summary>
		public planar.rotation_.Orientation orientation {
			get {

				return planar.line._OrientationX.Orientation(this);
			}
		}

		public Dif points => new Dif(this.ee);

		public bool containsPoint(Point1 point)
		{

			return ( point.x-begin.x)
				*(
					end.y-(begin.y)
				)
				==

					(point.y-begin.y)
					*(
						end.x-begin.x
					)
				
			;
		}
	}
}
