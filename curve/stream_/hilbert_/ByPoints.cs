using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve.stream_.hilbert_
{
	/// <summary>
	/// get the points
	/// </summary>
	static public class _ByPointsX
	{
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="g">assume it's square</param>
		/// <param name="ord">how many times we recur</param>
		static public List<Point4dbl> Draw(

			int ord
			,

			nilnul.geometry.planar.bloc_.Square4dbl bloc

		//,
		//double rotationInDegree = 0
		)
		{
			if (ord == 0)
			{
				return new List<Point4dbl>(){bloc.center };
			}

			var r = new List<Point4dbl>();

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
				///
				r.AddRange(
						Draw(

							newOrd
							, upperLeft

						)
						
				);

				var checkerBoxesWideCountHalf = 1 << (ord);
				var checkerBoxesWideCount = checkerBoxesWideCountHalf * 2;
				var connectionLengthRadius = bloc.edge.realee.ee / checkerBoxesWideCount / 2;

				


				///upperRight
				///
				r.AddRange(
					Draw(

						newOrd
						, upperRight

					)
				);

				///connect upperRight to lowerRight
				var pointUpperRightOut = (bloc.point + new nilnul.geometry.planar.Vect4dbl(
							bloc.edge.realee.ee - connectionLengthRadius
							,
							bloc.edge.realee.ee / 2 - connectionLengthRadius

						)
				);

			

				#region lower right

				/// note the connection reception is always at the lower left and lower right
				///
				///lower right
				///
				///rotate
				///
			

				var halfEdgeAsFloat = (float)halfEdge;

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


				var t_lowerRight =
				Draw(

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



				);
				var m = new Matrix();
				m.Translate(transPointF.X, transPointF.Y);
				m.Rotate(-90);

				t_lowerRight.Transform(
					m
				);

				path.AddPath(t_lowerRight, false);


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

				//var saved4lowerLeft = g.Save();
				//g.TranslateTransform(
				//	transPointF4LowerLeft.X,
				//	transPointF4LowerLeft.Y
				//);



				//g.RotateTransform(90);

				var p4lowerLeft = Draw(

					newOrd
					,

					new bloc_.Square4dbl(
						 //new Point4dbl(0,0)
						 -nilnul.geometry.planar.Vect4dbl.CreateSymmetry(halfEdge * .5).point.ToOrthogonal()

						,
						halfEdge
					)


				);
				var m4lowerLeft = new Matrix();
				m4lowerLeft.Translate(
transPointF4LowerLeft.X,
					transPointF4LowerLeft.Y
				);

				m4lowerLeft.Rotate(90);
				p4lowerLeft.Transform(m4lowerLeft);

				path.AddPath(
					p4lowerLeft
					, false
				);


				//g.ResetTransform();
				#endregion

				/////connect from lowerLeft to upperLeft
				///
				var p1 = (bloc.point + new nilnul.geometry.planar.Vect4dbl(
							 connectionLengthRadius
							,
							 halfEdge + connectionLengthRadius

						)
						);
				path.StartFigure(); //without this , figure will be closed.

				path.AddLine(

						p1.toPointF()
						,
						(p1 + new nilnul.geometry.planar.vector_.Vertical4dbl(

							 -2 * connectionLengthRadius

						)).toPointF()


				);
				

			}
			else
			{

				path.AddLine(

					lowerLeft.center.toPointF(),
					upperLeft.center.toPointF()
				);

				path.AddLine(

					upperLeft.center.toPointF(),
					upperRight.center.toPointF()
				);

				path.AddLine(

					upperRight.center.toPointF(),
					lowerRight.center.toPointF()
				);

			}
			return path;


		}


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
			var p = Draw(
				ord, bloc
			);

			g.DrawPath(pen, p);
		}

	}
}
