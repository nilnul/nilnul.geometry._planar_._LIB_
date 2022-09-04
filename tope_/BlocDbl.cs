using nilnul.geometry.planar.tope_._bloc;
using nilnul.geometry.planar.tope_._bloc_;
using nilnul.num.real.bound_;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace nilnul.geometry.planar.tope_
{
	public class BlocDbl
		:
		tope_._polygon_.Vertexes4dblI
		,
		_bloc_.BoundsI
		,
		Bloc4dbl_byAnchorI
	{
		/// <summary>
		/// start, location. like the start point of an vector.
		/// </summary>
		private nilnul.geometry.planar.Point4dbl _point;

		public nilnul.geometry.planar.Point4dbl point
		{
			get { return _point; }
			set { _point = value; }
		}

		public Point4dbl anchor => _point;


		[Obsolete()]
		public nilnul.geometry.planar._area.SizeDbl size
		{
			get { return new nilnul.geometry.planar._area.SizeDbl(_size1.width.realee,_size1.height.realee) ; }
			set { _size1 =new  nilnul.geometry.planar.tope_._bloc.SpreadDbl(
				value.width
				,
				value.height
			); }
		}

		private nilnul.geometry.planar.tope_._bloc.SpreadDbl _size1;

		public nilnul.geometry.planar.tope_._bloc.SpreadDbl size1
		{
			get { return _size1; }
			set { _size1 = value; }
		}



		public BlocDbl(
			nilnul.geometry.planar.Point4dbl point
			,
			nilnul.geometry.planar._area.SizeDbl size
		)
		{
			this._point = point;
			this.size = size;
		}

		public BlocDbl(
			nilnul.geometry.planar.Point4dbl point
			,
			nilnul.geometry.planar.tope_._bloc.SpreadDbl size
		)
		{
			this._point = point;
			this.size1 = size;
		}
		public BlocDbl(
			nilnul.geometry.planar.Point4dbl point
			,
			double h, double v
		):this(point, new tope_. _bloc.SpreadDbl(h,v) )
		{
		}

		public BlocDbl():this(new Point4dbl(),0,0)
		{

		}

		/// <summary>
		/// point#2
		/// </summary>
		public Point4dbl gradEnd {
			get {
				return geometry.planar.vect.op_.binary_._AddX.Op(
					this._point, this.size1
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
				return point.y + _size1.height.realee;
			}
		}

		public double widthEnd {
			get {
				return point.x + _size1.width.realee;
			}
		}

		public Point4dbl point3 { get {
				return new Point4dbl(
					point.x 
					,
					heightEnd
				);
			} }

		public IEnumerable<Point4dblI> vertexes => new Point4dblI[] { this._point, this.point1, gradEnd, this.point3};

		public ClosedDbl boundX {
			get  {
				return new ClosedDbl(
					point.x,
					widthEnd
				);
			}
		}
		public ClosedDbl boundY {
			get  {
				return new ClosedDbl(
					point.y
					,
					heightEnd
				);
			}

		}


		SpreadDbl SizeI.size => size1;

		public Rectangle toRect() {
			return new Rectangle(_point.toPointInt(), size1.toSizeInt());
		}

	}
}
