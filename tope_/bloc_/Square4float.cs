using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.bloc_
{
	public class Square4float
	{
		private PointF _point;

		public PointF point
		{
			get { return _point; }
			set { _point = value; }
		}

		private num.real_.Nonneg4floatI _edge;

		public num.real_.Nonneg4floatI edge
		{
			get { return _edge; }
			set { _edge = value; }
		}

		public Square4float(
			PointF point
			,
			num.real_.Nonneg4floatI edge
		)
		{
			this._point = point;
			this._edge = edge;
		}

		public Square4float(
			PointF point
			,
			num.real_.Nonneg4float edge
		):this(point, (Nonneg4floatI)edge)
		{
			
		}

		public Square4float(
			planar.Point4dbl point
			,
			num.real_.Nonneg4floatI edge
		)
			:this( Point4dbl.Coerce2float(point) , edge)
		{
			
		}

		public Square4float(
			planar.Point4dbl point
			,
			num.real_.Nonneg4float edge
		)
			:this( point, (Nonneg4floatI)edge)
		{
			
		}

		public Square4float(
			PointF  point
			,
			float edge
		)
			:this( point, new Nonneg4float(edge) )
		{
			
		}

		public Square4float(
			float x
			,
			float y
			,
			float edge
		)
			:this( new PointF(x,y) , edge )
		{
			
		}

		public Square4float(float v):this( new PointF(),v)
		{
		}

		/// <summary>
		/// horizon shifted
		/// </summary>
		public PointF point1
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
		public PointF point2
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



		public PointF point3
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


		public IEnumerable<PointF> vertexes => new PointF[] {
			this._point

			,
			this.point1
			,this.point2
			,this.point3

		};

		
		static public Square4float UnitalOf()
		{
			return new Square4float(1);
		}


	}
}
