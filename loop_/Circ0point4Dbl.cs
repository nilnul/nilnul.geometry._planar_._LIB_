using nilnul.geometry.planar.point_;
using nilnul.geometry.planar.tope_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.loop_
{
	/// <summary>
	/// for triviable circ, <see cref="planar.trail_.cloze_.ICirc0point"/>
	/// </summary>
	/// alias:
	///		circa
	///		circy
	///		circalet
	public class Circ0point4Dbl
		:loop_.simple_.convex_.quadratic_.conic_.IEllipse
,
		drawable_._boundaried_.Boundary4dblI
	{
		private num.real_.NonnegOfDouble _r;

		public num.real_.NonnegOfDouble  radius
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

		public Circ0point4Dbl(
			Point4dbl center
			,
			num.real_.NonnegOfDouble r
		
		)
		{

			_center = center;
			_r = r;

		}

		public Circ0point4Dbl(
			Point4dbl center,
			double r	
		)
			:this(
			center
				 ,
			new num.real_.NonnegOfDouble(r)	 
			)
		{

		}

		public double circumference() {
			return circ._LengthX.OfRadius(this.radius);
		}

		static public Circ0point4Dbl OfRadius(double x) {
			return new Circ0point4Dbl(
				new Point4dbl(),x
			);
		}
	

	}
}
