using nilnul.geometry.planar.point_;
using nilnul.geometry.planar.tope_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.loop_.circ_
{
	/// <summary>
	/// for triviable circ, <see cref="planar.trace_.cloze_.ICirc0point"/>
	/// </summary>
	public class Nontrivia4dbl
		:loop_.simple_.convex_.quadratic_.conic_.IEllipse
,
		drawable_._boundaried_.Boundary4dblI
	{
		private num.dbl_.Positive _r;

		public num.dbl_.Positive  radius
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

		public Nontrivia4dbl(
			Point4dbl center
			,
			num.dbl_.Positive r
		
		)
		{

			_center = center;
			_r = r;

		}

		public Nontrivia4dbl(
			Point4dbl center,
			double r	
		)
			:this(
			center
				 ,
			new num.dbl_.Positive(r)	 
			)
		{

		}

		public double circumference() {
			return circ._LengthX.OfRadius(this.radius);
		}


		public IEnumerable<planar.Point4dbl> _sect_assumePositive(int countOfSlices)
		{
			return new originated_.Nontrivia4dbl(
				this.radius
			)._sect_assumePositive(countOfSlices).Select(
				p=> p + this._center
			);
			
		}

		public cycle_.Polygon4dbl _sectAsPolygon_assumePositive(int countOfSlices)
		{
			return new cycle_.Polygon4dbl(
				_sect_assumePositive(countOfSlices)
			);
			
		}



	}
}
