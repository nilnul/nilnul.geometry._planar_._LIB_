using nilnul.geometry.planar.tope_._bloc;
using nilnul.geometry.planar.tope_._bloc_;
using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_
{

	public class Bloc4dbl_byBounds
		:
		tope_._polygon_.Vertexes4dblI,
		Bloc4dbl_byBoundsI, Bloc4dbl_byAnchorI
	{

		private nilnul.num.real.bound_.ClosedDbl _boundX;

		public nilnul.num.real.bound_.ClosedDbl boundX
		{
			get { return _boundX; }
			set { _boundX = value; }
		}

		private nilnul.num.real.bound_.ClosedDbl _boundY;

		public nilnul.num.real.bound_.ClosedDbl boundY
		{
			get { return _boundY; }
			set { _boundY = value; }
		}


		public nilnul.geometry.planar.Point4dbl point
		{
			get
			{
				return new Point4dbl(
			  _boundX.avowed.lower.mark
			  ,
			  _boundY.avowed.lower.mark
		  );
			}
		}

		public Point4dbl anchor =>  new Point4dbl(
			  _boundX.avowed.lower.mark
			  ,
			  _boundY.avowed.lower.mark
		  );


		public nilnul.geometry.planar.tope_._bloc.SpreadDbl size1
		{
			get
			{
				return
				  new _bloc.SpreadDbl(
					  _boundX.width
					  ,
					  _boundY.width
				  )

				  ;
			}
		}

		[Obsolete()]
		public nilnul.geometry.planar._area.SizeDbl size
		{
			get { return new nilnul.geometry.planar._area.SizeDbl(size1.width.realee, size1.height.realee); }

		}


		public Bloc4dbl_byBounds(
			nilnul.num.real.bound_.ClosedDbl _boundX
			,
			nilnul.num.real.bound_.ClosedDbl _boundY

		)
		{
			this._boundX = _boundX;
			this._boundY = _boundY;
		}

		

		public Bloc4dbl_byBounds() : this(
			new num.real.bound_.ClosedDbl(0, 0)
			,
			new num.real.bound_.ClosedDbl())
		{

		}

		public Bloc4dbl_byBounds(double minX, double maxX, double minY, double maxY)
			:this(
				 new num.real.bound_.ClosedDbl(minX,maxX)
				 ,
				 new num.real.bound_.ClosedDbl(minY,maxY)
			)
		{
		}


		/// <summary>
		/// point#2
		/// </summary>
		public Point4dbl gradEnd
		{
			get
			{
				return geometry.planar.vect.op_.binary_._AddX.Op(
					this.point, this.size1
				);
			}
		}

		public Point4dbl point1
		{
			get
			{
				return new Point4dbl(
					widthEnd
					,
					point.y
				);
			}
		}

		public double heightEnd
		{
			get
			{
				return point.y + size1.height.realee;
			}
		}

		public double widthEnd
		{
			get
			{
				return point.x + size1.width.realee;
			}
		}

		public Point4dbl point3
		{
			get
			{
				return new Point4dbl(
					point.x
					,
					heightEnd
				);
			}
		}

		public IEnumerable<Point4dblI> vertexes => new Point4dblI[] { this.point, this.point1, gradEnd, this.point3 };


		SpreadDbl SizeI.size => size1;

		public Rectangle toRect()
		{
			return new Rectangle(point.toPointInt(), size1.toSizeInt());
		}

	}
}
