using nilnul.geometry.planar.tope_._bloc;
using nilnul.geometry.planar.tope_._bloc_;
using nilnul.num.real.bound_;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace nilnul.geometry.planar.zone_
{
	/// <summary>
	/// a nontrivia <see cref="tope_.IBloc"/>
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public class Bloc8dbl
		:
		tope_._polygon_.Vertexes4dblI
		,
		tope_._bloc_.AnchorI
		,
		tope_.bloc_.ISpanned
		,
		_bloc_.SizeI
	{
		/// <summary>
		/// start, location. like the start point of an vector.
		/// </summary>
		private nilnul.geometry.planar.Point4dbl _point;

		public nilnul.geometry.planar.Point4dbl anchor
		{
			get { return _point; }
			set { _point = value; }
		}

		//public Point4dbl anchor => _point;


		private nilnul.geometry.planar.tope_._bloc.size_.Spanned4dbl _size;

		public nilnul.geometry.planar.tope_._bloc.size_.Spanned4dbl size
		{
			get { return _size; }
			set { _size = value; }
		}



		public Bloc8dbl(
			nilnul.geometry.planar.Point4dbl point
			,
			nilnul.geometry.planar.tope_._bloc.size_.Spanned4dbl size
		)
		{
			this._point = point;
			this.size = size;
		}
		public Bloc8dbl(
			nilnul.geometry.planar.Point4dbl point
			,
			double h, double v
		):this(point, new tope_. _bloc.size_.Spanned4dbl(h,v) )
		{
		}
		public Bloc8dbl(double x, double y, double width, double height):this(
			new Point4dbl(x,y), width,height
		)
		{
				
		}

		public Bloc8dbl(double width, double height):this(0,0,width,height)
		{
				
		}

		public Bloc8dbl():this(1,1)
		{

		}
		public Bloc8dbl(Point4dbl anchor, SpreadDbl size1)
			:this(anchor, new tope_._bloc.size_.Spanned4dbl(size1))
		{
			
		}

		public Bloc8dbl(tope_.BlocDbl old):this(
			old.anchor,old.size1
		)
		{
		}



		/// <summary>
		/// point#2
		/// </summary>
		public Point4dbl drift {
			get {
				return geometry.planar.vect.op_.binary_._AddX.Op(
					this._point, this.size
				);
			}
		}

		public Point4dbl horizonEnd { get {
				return new Point4dbl(
					widthEnd
					,
					anchor.y
				);
			} }

		public double heightEnd {
			get {
				return anchor.y + _size.height.dblen.ee;
			}
		}

		public double widthEnd {
			get {
				return anchor.x + _size.width.dblen.ee;
			}
		}

		public Point4dbl verticalEnd { get {
				return new Point4dbl(
					anchor.x 
					,
					heightEnd
				);
			} }

		public IEnumerable<Point4dblI> vertexes => new Point4dblI[] { this._point, this.horizonEnd, drift, this.verticalEnd};

		public ClosedDbl boundX {
			get  {
				return new ClosedDbl(
					anchor.x,
					widthEnd
				);
			}
		}
		public ClosedDbl boundY {
			get  {
				return new ClosedDbl(
					anchor.y
					,
					heightEnd
				);
			}

		}



		public Rectangle toRect() {
			return new Rectangle(_point.toPointInt(), size.toSizeInt());
		}

	}
}
