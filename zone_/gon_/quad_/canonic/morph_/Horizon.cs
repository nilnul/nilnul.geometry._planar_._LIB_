using nilnul.geometry.planar.point_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad_.canonic.morph_
{
	/// <summary>
	/// </summary>
	public class Horizon
		:
		nilnul.obj.Box1<
			planar.point_.PositivesDbl
		>
		,
		drawable._morph_.OfPoint4DblI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">old tip point</param>
		public Horizon(PositivesDbl val) : base(val)
		{
		}

		private nilnul.num.real_.PositiveDblI _newTip;
		public nilnul.num.real_.PositiveDblI newTip
		{
			get { return _newTip; }
			set { _newTip = value; }
		}

		public PositivesDbl oldTip { get { return boxed; } }

		public Point4dblI morph(Point4dblI oldPoint2trans)
		{
			var scale = _newTip.dblen / boxed.x;
			if (oldTip.y < 1)
			{
				if (oldPoint2trans.y <=oldTip.y)
				{
					var incrementTriangleHeight = oldTip.y;
					var incrementTirangleBase = _newTip.dblen.ee - oldTip.x;

					var oldWidthOfPoint2tran =1
						+
						(oldTip.y - oldPoint2trans.y) / oldTip.y * (oldTip.x -1)
					;

					var proportion = _newTip.dblen.ee / oldTip.x;

					var newWidthOfPoint2tran = 1 + (oldTip.y - oldPoint2trans.y) / oldTip.y * ( _newTip.dblen.ee -1);

					return new Point4dbl(
						oldPoint2trans.x
						/
						oldWidthOfPoint2tran
						*
						newWidthOfPoint2tran
						,
						oldPoint2trans.y 
					);
				}
				else
				{
					var point2transHeight_ov_triangleHeight = (oldPoint2trans.y - oldTip.y) / (1 - oldTip.y);
					var oldWidthOfPoint2tran =oldTip.x 
						*
						( oldPoint2trans.y-oldTip.y) /  (1-oldTip.y)
					;


					var newWidthOfPoint2tran =
						_newTip.dblen.ee 
						*
						( oldPoint2trans.y-oldTip.y) /  (1-oldTip.y)
					;

					return new Point4dbl(
						oldPoint2trans.x
						/
						oldWidthOfPoint2tran
						*
						newWidthOfPoint2tran
						,
						oldPoint2trans.y 
					);
				}
			}
			#region tip.y >=1

			/// oldTip.y is eq to, or above 1.
			if (oldPoint2trans.y<=1) // in the trape
			{

				var incrementTriangleHeight = oldTip.y;
				var incrementTirangleBase = _newTip.dblen.ee - oldTip.x;

				var oldWidthOfPoint2tran =  oldTip.x 
					+

					(1-oldTip.x)
					*

					oldPoint2trans.y / oldTip.y
				;

				var proportion = _newTip.dblen.ee / oldTip.x;

				var newWidthOfPoint2tran = newTip.dblen.ee   +
					(1-newTip.dblen.ee)
					*
					oldPoint2trans.y / oldTip.y
					;

				return new Point4dbl(
					oldPoint2trans.x
					/
					oldWidthOfPoint2tran
					*
					newWidthOfPoint2tran
					,
					oldPoint2trans.y
				);

			}
			else  //innner of the sticked out triangle. so oldTip.y must >1
			{
				

				//note the left to the triangle, and the inside of the triangle are not changing uniformly.

				var proportionOfLeft = (oldTip.y - oldPoint2trans.y) / (oldTip.y - 1);

				var oldLeft = proportionOfLeft * (oldTip.x);

				var oldInside = (oldTip.x) + ( oldPoint2trans.y) / oldTip.y * (1 - oldTip.x);

				var newLeft = proportionOfLeft * newTip.dblen.ee;
				var newInside = newTip.dblen.ee + ( oldPoint2trans.y) / oldTip.y * (1 - newTip.dblen.ee);

				return new Point4dbl(
					newLeft
					+
					(oldPoint2trans.x -oldLeft) / oldInside * newInside
					,
					oldPoint2trans.y
				);

				;

			}
			#endregion

		}
	}
}