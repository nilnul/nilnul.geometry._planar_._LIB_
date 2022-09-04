using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.rect.cornerCropped.concaveRounded
{
	/// <summary>
	/// a <seealso cref="nameof(ICross)"/>, with the convex corner rounded. Some cross road is designed as such, in order for vehicles to have a round angle of view and a round moving trail.
	/// </summary>
	public class Points

	{


		private planar.Point4dbl _topRight;

		public planar.Point4dbl topRight
		{
			get
			{
				return _topRight;
			}
		}




		private planar.Point4dbl _topRightArcStart;

		public planar.Point4dbl topRightArc_up
		{
			get
			{
				return _topRightArcStart;
			}
		}




		private planar.Point4dbl _topRightArcEnd;

		public planar.Point4dbl topRightArc_down
		{
			get
			{
				return _topRightArcEnd;
			}
		}


		private planar.Point4dbl _rightTop;

		public planar.Point4dbl rightTop
		{
			get
			{
				return _rightTop;
			}
		}

		private planar.Point4dbl _rightDown;
		public planar.Point4dbl rightDown
		{
			get
			{
				return _rightDown;
			}
		}

		private planar.Point4dbl _downRightArcStart;
		public planar.Point4dbl downRightArcStart
		{
			get
			{
				return _downRightArcStart;
			}
		}

		public Point4dbl downRightArcEnd { get; private set; }
		public Point4dbl downRight { get; private set; }
		public Point4dbl downLeft { get; private set; }
		public Point4dbl downLeftArc_down { get; private set; }
		public Point4dbl downLeftArc_up { get; private set; }
		public Point4dbl leftDown { get; private set; }

		public Point4dbl leftUp { get; private set; }
		public Point4dbl topLeftArc_down { get; private set; }
		public Point4dbl topLeftArc_up { get; private set; }


		public Point4dblI topLeft { get; private set; }

		public Points(ConcaveRounded convexRounded)
		{
			this.topLeft = convexRounded.starter;
			var _vectAtTop = convexRounded.vectTop;

			this._topRight = planar.grad_._DragX.End(topLeft, _vectAtTop);

			var vect4centerDown = new planar.vect_.Vertical4dbl(convexRounded.cornerDownward);

			this._topRightArcStart = planar.grad_._DragX.End(
					topRight
					,
					vect4centerDown

				);



			var vectAtRight = new planar.vect_.Vertical4dbl(convexRounded.verticalEdgeRemain);



			this._topRightArcEnd = topRightArc_up + new Point4dbl(
					convexRounded.radius
					,
					convexRounded.radius
				);

			var vect4CornerArcHorizon = new planar.vect_.Horizon4dbl(
				convexRounded.cornerRightward

				);
			this._rightTop = topRightArc_down + vect4CornerArcHorizon;

			this._rightDown = _rightTop + vectAtRight;


			this._downRightArcStart = _rightDown - vect4CornerArcHorizon;

			this.downRightArcEnd = _downRightArcStart + new Point4dbl(
					-convexRounded.radius.realee
					,
					convexRounded.radius
			);


			this.downRight = downRightArcEnd + vect4centerDown;

			this.downLeft = downRight - _vectAtTop;

			this.downLeftArc_down = downLeft - vect4centerDown;

			this.downLeftArc_up = downLeftArc_down + new Point4dbl(
					-convexRounded.radius.realee
					,
					-convexRounded.radius.realee
			);


			this.leftDown = downLeftArc_up - vect4CornerArcHorizon;

			this.leftUp = leftDown - vectAtRight;

			this.topLeftArc_down = leftUp + vect4CornerArcHorizon;

			this.topLeftArc_up = topLeftArc_down + new Point4dbl(
					convexRounded.radius.realee
					,
					-convexRounded.radius.realee
			);







		}

		public double boundingWidth { get {
				return (rightTop - leftUp).x;
			} }

		public double boundingHeight{ get {
				return (topLeft - downLeft).y;
			} }

	}
}
