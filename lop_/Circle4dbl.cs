using nilnul.geometry.planar.point_;
using nilnul.geometry.planar.tope_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.lop_
{
	/// <summary>
	/// for triviable circ, <see cref="planar.trail_.cloze_.ICirc0point"/>
	/// </summary>
	/// alias:
	///		circa
	///		circy
	///		circalet
	public class Circle4dbl
		:loop_.simple_.convex_.quadratic_.conic_.IEllipse
,
		drawable_._boundaried_.Boundary4dblI
	{
		private num.real_.PositiveDbl _r;

		public num.real_.PositiveDbl  radius
		{
			get { return _r; }
			set { _r = value; }
		}

		private Point4dbl _center;

		public Point4dbl center
		{
			get { return _center; }
			set { _center = value; }
		}

		public Bloc4dbl_byBoundsI bounds
		{
			get
			{
				var horizonBound = num.real.bound_._CenteredDblX.Close_ofCenterRadius(
_center.x, _r
						)
					;
				var verticalBound = num.real.bound_._CenteredDblX.Close_ofCenterRadius(
_center.y, _r
						)
					;

				return new Bloc4dbl_byBounds(
					new num.real.bound_.ClosedDbl(
					 horizonBound.avowed.lower.mark,horizonBound.avowed.upper.mark
					 )
					
					,
					new num.real.bound_.ClosedDbl(
						verticalBound.avowed.lower.mark
						,
						verticalBound.avowed.upper.mark
					)
			);

			}
		}

		public Circle4dbl(
			Point4dbl center
			,
			num.real_.PositiveDbl r
		
		)
		{

			_center = center;
			_r = r;

		}


		public Circle4dbl(
			Point4dbl center,
			double r	
		)
			:this(
			center
				 ,
			new num.real_.PositiveDbl(r)	 
			)
		{

		}
		public Circle4dbl(
			double r	
		)
			:this(
			new PointD()
				 ,
			(r)	 
			)
		{

		}


		public double circumference() {
			return curve_.cloze_.circ._LengthX.OfRadius(this.radius);
		}

		static public Circle4dbl OfRadius(double x) {
			return new Circle4dbl(
				new Point4dbl(),x
			);
		}
	

	}
}
