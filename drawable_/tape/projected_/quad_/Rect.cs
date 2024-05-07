//using nilnul.geometry.planar._bloc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable_.tape.projected_.quad_
{
	/// <summary>
	/// compute a quad from 3 points, with the constraint that the tape is perpendicular to the guid
	/// </summary>
	static public class _RectX
	{

		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			nilnul.num.real_.PositiveDblI fromPointToTapeTip
			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			,
			 planar.tope_._bloc.SpreadDbl arrowHead
		)

		{
			var gradDirection = planar.grad_.skid._DirectionX._Direction_assumeDif(point, point1);

			var v = new planar.vect_.Polar4dbl(
				gradDirection
				+
				nilnul.num.real_.TauX.QuarterD
				,
				fromPointToTapeTip
			);

			var tip = point1.ToOrthogonal() + v;

			var tip1 = point.ToOrthogonal() + v;



			return new Quad(
				new Tape4dbl(
					 zone_.gon_.octa_.BidirectionalArrow4Dbl.OfTips(
						tip.ToOrthogonal()
						,
						tip1.ToOrthogonal()
						,
						arrowHead

					),
					caption
				)
				,
				new point.CoD(point, point1)
				,
				eave
			);

		}

		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			nilnul.num.real_.PositiveDblI fromPointToTapeTip
			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			, double spreadOfArrowhead
		)

		{

			return Of(point,point1, fromPointToTapeTip,eave, caption, new tope_._bloc.SpreadDbl(spreadOfArrowhead,spreadOfArrowhead)
			);


			var gradDirection = planar.grad_.skid._DirectionX._Direction_assumeDif(point, point1);

			var v = new planar.vect_.Polar4dbl(gradDirection
				,
				fromPointToTapeTip
			);

			var tip = point1.ToOrthogonal() + v;

			var tip1 = point.ToOrthogonal() + v;



			return new Quad(
				new Tape4dbl(
					new zone_.gon_.octa_.BidirectionalArrow4Dbl(
						tip.ToOrthogonal()
						,
						tip1.ToOrthogonal()
						,
						new tope_._bloc.SpreadDbl(
							spreadOfArrowhead,
							spreadOfArrowhead
						)
					),
					caption
				)
				,
				new point.CoD(point, point1)
				,
				eave
			);

		}


		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			planar.vect_.NonnilDblI fromPointToTapeTip
			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			, tope_._bloc.SpreadDbl spreadOfArrowhead
		)
		{

			var tip = point.ToOrthogonal() + fromPointToTapeTip;
			var tip1 = planar.cycle_.gon_.quad_.convex_.trape_.Perpend.ExtendTrigon_assumeTrigon(
				point1, point, tip
			);



			return new Quad(
				new Tape4dbl(
					new zone_.gon_.octa_.BidirectionalArrow4Dbl(
						tip.ToOrthogonal(), tip1.ToOrthogonal()
						,
							spreadOfArrowhead
					),
					caption
				)
				,
				new point.CoD(point, point1)
				,
				eave
			);

		}

		//public static Quad Of(Point4dbl semicircleRight, Point4dbl rightNeaer, int v1, int v2, string v3, SpreadDbl spreadDbl)
		//{
		//	throw new NotImplementedException();
		//}

		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			nilnul.num.real_.PositiveDbl fromPointToTapeTip
			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			, planar.tope_._bloc.SpreadDbl spreadOfArrowhead
		)

		{
			return Of(point, point1,
				(num.real_.PositiveDblI)fromPointToTapeTip
				,
				eave
				,
				caption
				,
				spreadOfArrowhead

			);
		}
		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			nilnul.num.real_.PositiveDbl fromPointToTapeTip
			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			, double spreadOfArrowhead
		)

		{
			return Of(point, point1,
				(num.real_.PositiveDblI)fromPointToTapeTip
				,
				eave
				,
				caption
				,
				spreadOfArrowhead

			);
		}		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			double fromPointToTapeTip
			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			,
			planar.tope_._bloc.SpreadDbl spreadOfArrowhead
		)
		{
			return Of(
				point,
				point1,
				new nilnul.num.real_.PositiveDbl(fromPointToTapeTip)
				,
				eave,
				caption,
				spreadOfArrowhead
			);
		}

		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			double fromPointToTapeTip
			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			, double spreadOfArrowhead
		)
		{
			return Of(
				point,
				point1,
				new nilnul.num.real_.PositiveDbl(fromPointToTapeTip)
				,
				eave,
				caption,
				spreadOfArrowhead
			);
		}
		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			double fromPointToTapeTip
			,
			double eave
			,
			string caption
			, double spreadOfArrowhead
		)
		{
			return Of(
				point,
				point1,
				fromPointToTapeTip
				,
				new num.real_.NonnegOfDouble(
				eave)
				,
				caption,
				spreadOfArrowhead
			);
		}
		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point1
			,
			double fromPointToTapeTip
			,
			double eave
			,
			string caption
			,
			planar.tope_._bloc.SpreadDbl spreadOfArrowhead
		)
		{
			return Of(
				point,
				point1,
				fromPointToTapeTip
				,
				new num.real_.NonnegOfDouble(
				eave)
				,
				caption,
				spreadOfArrowhead
			);
		}

	}
}
