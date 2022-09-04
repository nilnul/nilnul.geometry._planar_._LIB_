using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real_;
using nilnul.number;

namespace nilnul.geometry.planar.tope_.disc
{
	/// <summary>
	/// 
	/// </summary>
	public  class CircularSegment
		:ISected
	{
		private NonnegOfDouble _radius;
		public NonnegOfDouble radius
		{
			get { return _radius; }
			set {
				this._radius = value;
			}
			
		}

		private NormalizedAngle _angle;

		public NormalizedAngle angle
		{
			get { return _angle; }
			set { _angle = value; }
		}


		public CircularSegment(NonnegOfDouble r,NormalizedAngle a)
		{
			this._radius = r;
			this._angle = a;

		}

		public double area() {
			return Area(radius,angle);
		
		}
		static public double Area(NonnegOfDouble radius, NormalizedAngle angle) {

			return .5 * radius.ee * radius.ee * (angle.val - Math.Sin(angle.val));
		}

		static public double Area(double radius,double angle) {

			return Area(new NonnegOfDouble(radius), new NormalizedAngle(angle));
 

		
		}


		
		
		
		
	}
}
