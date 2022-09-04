using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.bloc_
{
	public class Square4dbl
		:
		_polygon_.Vertexes4dblI
	{
		private planar.Point4dblI _point;

		public planar.Point4dblI point
		{
			get { return _point; }
			set { _point = value; }
		}

		private num.real_.NonnegOfDoubleI _edge;

		public num.real_.NonnegOfDoubleI edge
		{
			get { return _edge; }
			set { _edge = value; }
		}

		public Square4dbl(
			planar.Point4dblI point
			,
			num.real_.NonnegOfDoubleI edge
		)
		{
			this._point = point;
			this._edge = edge;
		}

		public Square4dbl(
			planar.Point4dbl point
			,
			num.real_.NonnegOfDoubleI edge
		)
			: this((Point4dblI)point, edge)
		{

		}

		public Square4dbl(
			planar.Point4dblI point
			,
			num.real_.NonnegOfDouble edge
		)
			: this(point, (NonnegOfDoubleI)edge)
		{

		}

		public Square4dbl(
			planar.Point4dbl point
			,
			num.real_.NonnegOfDouble edge
		)
			: this(point, (NonnegOfDoubleI)edge)
		{

		}

		public Square4dbl(
			planar.Point4dbl point
			,
			double edge
		)
			: this(point, new NonnegOfDouble(edge))
		{

		}

		public Square4dbl(
			planar.Point4dblI point
			,
			double edge
		)
			: this(point, new NonnegOfDouble(edge))
		{

		}

		public Square4dbl(
			double x
			,
			double y
			,
			double edge
		)
			: this(new Point4dbl(x, y), edge)
		{

		}

		public Square4dbl(double v):this(new Point4dbl(),v)
		{
		}

		public RectangleF coerce2rectFloat()
		{
			return new RectangleF(
				Point4dbl.Coerce2float(this._point)
				,
				tope_._bloc.SpreadDbl.Coerce2float_ofSquare(this._edge.realee.ee)
			);

		}

		public Point4dbl center {
			get {
				var halfEdge = this._edge.realee.ee / 2;
				return new Point4dbl(
					_point.x + halfEdge
					,
					_point.y + halfEdge
				);
			}
		}



		/// <summary>
		/// horizon shifted
		/// </summary>
		public Point4dbl point1
		{
			get
			{
				return geometry.planar.point.op_.unary_._ShiftX.Shift(
					this._point, this._edge.realee.ee
				);
			}
		}

		/// <summary>
		/// point#2
		/// </summary>
		public Point4dbl point2
		{
			get
			{
				return geometry.planar.vect.op_.binary_._AddX.Point(
					this._point
					,
					this._edge.realee.ee
					,
					this._edge.realee.ee
				);
			}
		}


	
		public Point4dbl point3
		{
			get
			{
				return planar.point.op_.unary_._RaiseX.Raise(
					this.point
					,
					this._edge
				);
			}
		}


		public IEnumerable<Point4dblI> vertexes => new Point4dblI[] {
			this._point

			,
			this.point1
			,this.point2
			,this.point3

		};

		static public Square4dbl UnitalOf() {
			return new Square4dbl(1);
		}

	}
}
