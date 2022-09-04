using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace nilnul.geometry.planar._rect
{
	public static class Extensions
	{

		static public RectangleF CreateFromDialogal(float x, float y, float x1, float y1)
		{

			return CreateFromDialogal(
				new PointF(x,y)
				,
				new PointF(x1,y1)	
			);
		}

		static public RectangleF CreateFromDialogal(PointF start, PointF end)
		{

			var leftLower = nilnul.geometry.planar.point.co.band_.Min.Lazy.combine(start, end);

			return new RectangleF(


				leftLower
				,
				nilnul.geometry.planar.tope_._bloc.SpreadFloat.CreateFromDiagonal(
					start
					,
					end
				)
			);
		}

		

		static public IEnumerable<PointF> GetPathPointsFromDiagonal(PointF start, PointF end)
		{


			 
			yield return start;


			

			var turningPoint = GetTurnPointFromDiagonal(start,end);
			yield return turningPoint;
 
			yield return end;

			var shiftOfFirstEdge = nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine(start, turningPoint);


			yield return point.co.band_.AddDbl.Lazy.combine(
				end, 
				 
					shiftOfFirstEdge	
				 	
			);

		}
		static public IEnumerable<PointF> GetPath(RectangleF rectF)
		{


			yield return new PointF(rectF.X, rectF.Y);

			yield return new PointF(rectF.X + rectF.Width, rectF.Y);

			yield return new PointF(rectF.X + rectF.Width, rectF.Y + rectF.Height);

			yield return new PointF(rectF.X, rectF.Y + rectF.Height);

		}


		static public PointF GetTurnPointFromDiagonal(PointF start, PointF end)
		{

			var vector =nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine(end,start);


			var rotation = nilnul.geometry.planar.vect_.nonnil._DirectionX.ToLtTau(vector);

			if (rotation<Math.PI/2)
			{

				return new PointF(end.X, start.Y);

			}
			if (rotation<Math.PI)
			{
				return new PointF(start.X,end.Y);
			}
			if (rotation< nilnul.geometry.planar._RotationX.ThreeQuarter)
			{
				return new PointF(end.X,start.Y  );
			}
			return new PointF(start.X,end.Y);


		


		}
	}
}
