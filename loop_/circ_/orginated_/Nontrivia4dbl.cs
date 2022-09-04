using nilnul.geometry.planar.point_;
using nilnul.geometry.planar.tope_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.loop_.circ_.originated_
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


		public Point4dbl center
		{
			get { return new Point4dbl(); }
		}

		public Bloc4dbl_byBoundsI bounds
		{
			get
			{
				var horizonBound = num.real.bound_._CenteredDblX.Close_ofCenterRadius(
0, _r
						)
					;
				var verticalBound = num.real.bound_._CenteredDblX.Close_ofCenterRadius(
0, _r
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
			
		num.dbl_.Positive r 
		)
		{

			_r = r;

		}

		public Nontrivia4dbl(
			double r	
		)
			:this(
			new num.dbl_.Positive(r)	 
			)
		{

		}

		public double circumference() {
			return circ._LengthX.OfRadius(this.radius);
		}


		public IEnumerable<Polar4dbl_radius1st> _sect_assumePositive(int countOfSlices)
		{
			var step = Math.PI * 2 / countOfSlices;
			var total = 0d;

			for (int i = 0; i < countOfSlices; i++)
			{
				yield return new point_.Polar4dbl_radius1st(
					this.radius
					,
					total
				);

				total += step;

			}
		}



	}
}
