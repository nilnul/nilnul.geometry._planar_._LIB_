using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.ellipse
{
	static public class Extensions
	{

		/// <summary>
		/// draw a quater of ellipse from one point to another. Note the direction of the curve must on the outer side of the diagonal.
		/// </summary>
		/// <param name="graphics"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="x1"></param>
		/// <param name="y1"></param>
		static public void AddArc(GraphicsPath graphics, PointF start, PointF end, bool connected)
		{

			graphics.AddPath(CreateQuarter(start, end), connected);

			






		}
		static public GraphicsPath CreateQuarter(  PointF start, PointF end)
		{


			//var rect = nilnul.geometry.planar._rect.Extensions.CreateFromDialogal(start, end);

			//var points = nilnul.geometry.planar._rect.Extensions.GetPathPointsFromDiagonal(start,end);

			var corner = nilnul.geometry.planar._rect.Extensions.GetTurnPointFromDiagonal(start, end);


			var corner2end = nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine( end,corner);

			var corner2end_ext = nilnul.geometry.planar.point.co.band_.AddDbl.Lazy.combine(
				end, corner2end	
			);


			var corner2begin=nilnul.geometry.planar.point.co.band_.Minus.Singleton.combine( start,corner);

			var corner2begin_ext= nilnul.geometry.planar.point.co.band_.AddDbl.Lazy.combine(
				start, corner2begin	
			);


			//var rightUpper =  nilnul.geometry.planar.pointF.op_._RaiseX.Raise(
			//	end, 
			//	nilnul.geometry.planar.pointF.duo.to_._Raise.Raise(start,end)
			//	) ;

			//var upperLeft = nilnul.geometry.planar.pointF.op_._ShiftX.Shift(
			//	rightUpper
			//	,
			//	nilnul.geometry.planar.pointF.duo.to_._Shift.Shift(end,start)*2
			//	);

			//var leftLower= nilnul.geometry.planar.pointF.op_._RaiseX.Raise(
			//	upperLeft, 
			//	nilnul.geometry.planar.pointF.duo.to_._Raise.Raise(end,start)*2
			//	) ;






			//var point = _rect.Extensions.GetTurnPointFromDiagonal(start, end);

			//var xCompared = nilnul.geometry.planar.pointF.comparer_.byX.Decider.Lazy.gt(end, start);

			var rotation = nilnul.geometry.planar.vect_.nonnil.co._RotationX.Rotation(
				start, end
			);

			float initial; float sweep;

			if (rotation < nilnul.geometry.planar.rotation_.Turns.Quarter)
			{

				initial = 270;
				//sweep = 90;

			}
			else if (rotation < rotation_.Turns.Half)
			{
				initial = 0;
				//sweep = 90;
			}
			else if (rotation < rotation_.Turns.ThreeQuarter)
			{

				initial = 90;
				//sweep = 90;

			}
			else
			{
				initial = 180;
				//sweep = 90;
			}
			sweep = 90;
			var path = new GraphicsPath();

			path.AddArc(
				nilnul.geometry.planar._rect.Extensions.CreateFromDialogal(
						corner2begin_ext,corner2end_ext
					)
				, initial, sweep);

			return path;




		}

		static public void AddArc(GraphicsPath graphics, float x, float y, float x1, float y1,bool connect) {
			  AddArc(
				graphics,new PointF(x,y),new PointF(x1,y1)	,connect
			);
		}
	static public GraphicsPath CreateQuarter(  float x, float y, float x1, float y1) {
			  return CreateQuarter(
				new PointF(x,y),new PointF(x1,y1)	
			);
		}
		 
	}
}
