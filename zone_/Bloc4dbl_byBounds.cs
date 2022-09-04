using nilnul.geometry.planar.tope_._bloc_;
using nilnul.num.real.bound_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_
{
	
	public class Bloc4dbl_byBounds
		:
		tope_._polygon_.Vertexes4dblI
		,
		planar.tope_.Bloc4dbl_byBoundsI
	{

		private nilnul.num.real.bound_.closed_.Spanned4dbl _boundX;

		public nilnul.num.real.bound_.closed_.Spanned4dbl boundX
		{
			get { return _boundX; }
			set { _boundX = value; }
		}

		private nilnul.num.real.bound_.closed_.Spanned4dbl _boundY;

		public nilnul.num.real.bound_.closed_.Spanned4dbl boundY
		{
			get { return _boundY; }
			set { _boundY = value; }
		}


		public nilnul.geometry.planar.Point4dbl point
		{
			get { return new Point4dbl(
				_boundX.avowed.lower.mark
				,
				_boundY.avowed.lower.mark
			); }
		}

		public nilnul.geometry.planar.tope_._bloc.SpreadDbl size1
		{
			get { return
					new planar.tope_._bloc.SpreadDbl(
						_boundX.width
						,
						_boundY.width
					)

					; }
		}

		[Obsolete()]
		public nilnul.geometry.planar._area.SizeDbl size
		{
			get { return new nilnul.geometry.planar._area.SizeDbl(size1.width.realee,size1.height.realee) ; }
		
		}


		public Bloc4dbl_byBounds(
			nilnul.num.real.bound_.closed_.Spanned4dbl _boundX
			,
			nilnul.num.real.bound_.closed_.Spanned4dbl _boundY

		)
		{
			this._boundX = _boundX;
			this._boundY = _boundY;
		}


		

		/// <summary>
		/// point#2
		/// </summary>
		public Point4dbl gradEnd {
			get {
				return geometry.planar.vect.op_.binary_._AddX.Op(
					this.point, this.size1
				);
			}
		}

		public Point4dbl point1 { get {
				return new Point4dbl(
					widthEnd
					,
					point.y
				);
			} }

		public double heightEnd {
			get {
				return point.y + size1.height.realee;
			}
		}

		public double widthEnd {
			get {
				return point.x + size1.width.realee;
			}
		}

		public Point4dbl point3 { get {
				return new Point4dbl(
					point.x 
					,
					heightEnd
				);
			} }

		public IEnumerable<Point4dblI> vertexes => new Point4dblI[] { this.point, this.point1, gradEnd, this.point3};

		ClosedDbl BoundsI.boundX => boundX;

		ClosedDbl BoundsI.boundY => boundY;

		public Rectangle toRect() {
			return new Rectangle(point.toPointInt(), size1.toSizeInt());
		}

	}
}
