using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.point
{
	public  class CoD
		:nilnul.obj.Co<planar.Point4dblI>
	{
		//private PointD _point;

		//public PointD point
		//{
		//	get { return _point; }
		//	set { _point = value; }
		//}
		//private PointD _point1;

		//public PointD point1
		//{
		//	get { return _point1; }
		//	set { _point1 = value; }
		//}

		public CoD(
			Point4dblI p,
			Point4dblI p1
		):base(p,p1)
		{
			//this.point = p;
			//this.point1 = p1;

		}

		

		public bool isReflexive() { 
			return nilnul.geometry.planar.point.EqDbl.Eq(component, component1);
			
		}

		static public bool TwoPointsSame(Point4dbl x, Point4dbl y) {
			return nilnul.geometry.planar.point.EqDbl.Eq(x, y);
		}

		//static public bool TwoPointsSame(Pair twoPoints) {
		//	return TwoPointsSame(twoPoints.point, twoPoints.point1);
		//}


		public double horizonShift
		{
			get
			{
				return this.component1.x - component.x;
			}
		}
		public double verticalShift
		{
			get
			{
				return component1.y - component.y;
			}
		}



	}
}
