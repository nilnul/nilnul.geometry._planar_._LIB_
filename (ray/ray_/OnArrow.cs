using nilnul.geometry.planar.point;
using nilnul.geometry.planar._ray_;
using nilnul.geometry.planar.point;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.Real;

namespace nilnul.geometry.planar.ray_
{
	static public class _OnArrowX
	{
		static public planar.PointI1 End(planar.RayI ray) {
			return planar.vect.co.band_._AddX.Point(  ray.src , planar.ray._VectorX.Vector(ray) );
		}

		static public (planar.PointI1,planar.PointI1) Points(planar.RayI ray) {
			return (ray.src, End(ray));
		}


	}
	public  class OnArrow
		:
		nilnul.geometry.planar.point.co_.Dif
		,
		RayI
	{
		public PointI1 src => this.component;

		public RotationI1 rotation => planar.grad_.skid._DirectionX._Direction_assumeDif(  this.component,this.component1);


		public OnArrow(Point1 x,Point1 y)
			:this(new planar.point.Co(x,y))
		{

		}

		public OnArrow(PointI1 x,PointI1 y)
			:this(new planar.point.Co(x,y))
		{

		}

		public OnArrow(planar.RayI ray):this(ray.src, _OnArrowX.End(ray))
		{

		}

		public OnArrow(R startX, R startY,R endX,R endY) 
			:this(new Point1( startX,startY),new Point1( endX,endY))
		{ 
		
		}
		public OnArrow(planar.point.Co val) : base(val)
		{
		}


	
		
		
	}
}
