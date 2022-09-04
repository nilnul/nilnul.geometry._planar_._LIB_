using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve.stream_.fractal_
{
	/// <summary>
	/// </summary>
	static public class Hilbert
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="g">assume it's square</param>
		static public void _DrawNonrecur(
			Graphics g

			,

			nilnul.geometry.planar.bloc_.Square4dbl bloc
			,
			Pen pen
		)
		{
			var upperLeft = new nilnul.geometry.planar.bloc_.Square4dbl(
				bloc.point
				,
				bloc.edge
			);

			var halfEdge = bloc.edge.realee.ee / 2;

			var upperRight = new nilnul.geometry.planar.bloc_.Square4dbl(
				bloc.point + new geometry.planar.vector_.Horizon4dbl(halfEdge)
				,
				bloc.edge
			);

			var lowerLeftStart = bloc.point + new geometry.planar.vector_.Vertical4dbl(halfEdge);

			var lowerLeft = new nilnul.geometry.planar.bloc_.Square4dbl(
				lowerLeftStart
				,
				bloc.edge
			);

			var lowerRight = new nilnul.geometry.planar.bloc_.Square4dbl(
				lowerLeftStart + new geometry.planar.vector_.Horizon4dbl(halfEdge)
				,
				bloc.edge
			);

			var path = new GraphicsPath();
			
			g.DrawLine(
				pen,
				upperRight.center.toPointF(),
				upperLeft.center.toPointF()
			);

			g.DrawLine(
				pen,
				upperLeft.center.toPointF(),
				lowerRight.center.toPointF()
			);

			g.DrawLine(
				pen,
				lowerRight.center.toPointF(),
				lowerLeft.center.toPointF()
			);




		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g">assume it's square</param>
		/// <param name="ord">how many times we recur</param>
		static public void Draw(
			Graphics g
			,
			int ord
			,

			nilnul.geometry.planar.bloc_.Square4dbl bloc
			,
			Pen pen
		//,
		//double rotationInDegree = 0
		)
		{
			var halfEdge = bloc.edge.realee.ee / 2;


			var upperLeft = new nilnul.geometry.planar.bloc_.Square4dbl(
				bloc.point
				,
				halfEdge
			);


			var upperRight = new nilnul.geometry.planar.bloc_.Square4dbl(
				bloc.point + new geometry.planar.vector_.Horizon4dbl(halfEdge)
				,
				halfEdge
			);

			var lowerLeftStart = bloc.point + new geometry.planar.vector_.Vertical4dbl(halfEdge);

			var lowerLeft = new nilnul.geometry.planar.bloc_.Square4dbl(
				lowerLeftStart
				,
				halfEdge
			);

			var lowerRight = new nilnul.geometry.planar.bloc_.Square4dbl(
				lowerLeftStart + new geometry.planar.vector_.Horizon4dbl(halfEdge)
				,
				halfEdge
			);

			if (ord > 0)
			{
				var newOrd = ord - 1;


				///upper left
				Draw(
					g,
					newOrd
					, upperLeft
					, pen
				);

				var checkerBoxesWideCountHalf = 1 << (ord);
				var checkerBoxesWideCount = checkerBoxesWideCountHalf * 2;
				var connectionLengthRadius = bloc.edge.realee.ee / checkerBoxesWideCount / 2;

				///connect upperLeft to upperRight
				g.DrawLine(
					pen,
						(bloc.point + new nilnul.geometry.planar.Vect4dbl(
							bloc.edge.realee.ee / 2 - connectionLengthRadius
							,
							bloc.edge.realee.ee / 2 - connectionLengthRadius

						)
						).toPointF()
						,
						(bloc.point + new nilnul.geometry.planar.Vect4dbl(
							bloc.edge.realee.ee / 2 + connectionLengthRadius
							,
							bloc.edge.realee.ee / 2 - connectionLengthRadius

						)).toPointF()


				);


				///upperRight
				Draw(
					g,
					newOrd
					, upperRight
					, pen
				);

				///connect upperRight to lowerRight
				var pointUpperRightOut = (bloc.point + new nilnul.geometry.planar.Vect4dbl(
							bloc.edge.realee.ee - connectionLengthRadius
							,
							bloc.edge.realee.ee / 2 - connectionLengthRadius

						)
				);

				g.DrawLine(
					pen,
						pointUpperRightOut.toPointF()
						,
						(pointUpperRightOut + new nilnul.geometry.planar.vector_.Vertical4dbl(


							 connectionLengthRadius * 2

						)).toPointF()


				);

				#region lower right

				/// note the connection reception is always at the lower left and lower right
				///
				///lower right
				///
				///rotate
				///
				var translatePoint = (
					 nilnul.geometry.planar.Vect4dbl.CreateSymmetry(halfEdge * 1.5).point
				).ToOrthogonal();

				var transPointF = translatePoint.toPointF();

				var halfEdgeAsFloat = (float)halfEdge;
				var saved = g.Save();
				//	g.BeginContainer(
				//	new RectangleF(0, 0, halfEdgeAsFloat, (float)halfEdge)
				//	,
				//	new RectangleF(
				//		halfEdgeAsFloat
				//		,
				//		halfEdgeAsFloat
				//		,
				//		halfEdgeAsFloat,
				//		halfEdgeAsFloat
				//	)
				//	, GraphicsUnit.Pixel
				//);


				g.TranslateTransform(
					transPointF.X,
					transPointF.Y
				);
				g.RotateTransform(-90);

				///lowerRight
				Draw(
					g,
					newOrd
					,
					//new bloc_.Square4dbl(
					//	new Point4dbl(0,0)
					//	,
					//	halfEdge
					//)
					new bloc_.Square4dbl(
						 -nilnul.geometry.planar.Vect4dbl.CreateSymmetry(
							 halfEdge * .5
						).point.ToOrthogonal()
						,
						halfEdge
					)

					,
					pen

				);

				g.Restore(saved);
				//g.RotateTransform(+90);

				//g.TranslateTransform(
				//	-transPointF.X,
				//	-transPointF.Y

				//);


				#endregion

				#region lower left

				var translatePoint4lowerLeft =
	new geometry.planar.Point4dbl(
		halfEdge * .5
		,
		halfEdge * 1.5
	);

				var transPointF4LowerLeft = translatePoint4lowerLeft.toPointF();

				var saved4lowerLeft = g.Save();
				g.TranslateTransform(
					transPointF4LowerLeft.X,
					transPointF4LowerLeft.Y
				);



				g.RotateTransform(90);
				Draw(
					g,
					newOrd
					,

					new bloc_.Square4dbl(
						 -nilnul.geometry.planar.Vect4dbl.CreateSymmetry(halfEdge * .5).point.ToOrthogonal()
						,
						halfEdge
					)

					, pen
				);

				g.Restore(saved4lowerLeft);
				//g.ResetTransform();
				#endregion

				///connect from lowerLeft to upperLeft
				g.DrawLine(
					pen,
						(bloc.point + new nilnul.geometry.planar.Vect4dbl(
							 connectionLengthRadius
							,
							bloc.edge.realee.ee / 2 + connectionLengthRadius

						)
						).toPointF()
						,
						(bloc.point + new nilnul.geometry.planar.Vect4dbl(
							 connectionLengthRadius
							,
							bloc.edge.realee.ee / 2 - connectionLengthRadius

						)).toPointF()


				);

			}
			else
			{

				g.DrawLine(
					pen,
					lowerLeft.center.toPointF(),
					upperLeft.center.toPointF()
				);

				g.DrawLine(
					pen,
					upperLeft.center.toPointF(),
					upperRight.center.toPointF()
				);

				g.DrawLine(
					pen,
					upperRight.center.toPointF(),
					lowerRight.center.toPointF()
				);

			}



		}



	}
}
