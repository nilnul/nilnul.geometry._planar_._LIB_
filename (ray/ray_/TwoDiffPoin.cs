using nilnul.geometry._2d.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.dir
{
	public partial class TwoDiffPoints:TwoPoints
	{
		static public bool Be(TwoPoints twoPoints) {
			return ! nilnul.geometry._2d.point.PointInDouble.Eq.Eval(twoPoints.point, twoPoints.point1);
		}
		static public void Assert(
			TwoPoints twoPoints
		) {
				nilnul.Assert.True(Be(twoPoints));
		
		}

		private TwoDiffPoints(TwoPoints twoPoints)
			:base(twoPoints.point,twoPoints.point1)
		{
		}

		public double angle
		{
			get
			{
				return nilnul.geometry._2d.point.Angle.Eval_0to2pi(this.point.x - this.point1.x, this.point.y - this.point1.y);
			}
		}


		static public TwoDiffPoints Create(PointInDouble p, point.PointInDouble p1) {
			return Create(
				new TwoPoints(p,p1)	
			);
		}

		static public TwoDiffPoints Create(TwoPoints twoPoints) {
			Assert(twoPoints);
			return new TwoDiffPoints(twoPoints);
		}
		
		
	}
}
