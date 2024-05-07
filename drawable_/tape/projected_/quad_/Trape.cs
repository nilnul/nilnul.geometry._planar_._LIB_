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
	static public class _TrapeX
	{




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
			,tope_._bloc.SpreadDbl spreadOfArrowhead
		) {

			var tip = point1.ToOrthogonal() + fromPointToTapeTip;
			var tip1 = planar.cycle_.gon_.quad_.convex_.trape_.Perpend.ExtendTrigon_assumeTrigon(
				point,point1,tip
			);



			return new Quad(
				new Tape4dbl(
					 zone_.gon_.octa_.BidirectionalArrow4Dbl.OfTips(
						tip.ToOrthogonal()
						,
						tip1.ToOrthogonal()
						, 
							spreadOfArrowhead
					),
					caption
				)
				,
				new point.CoD(point,point1)
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
			,double spreadOfArrowhead
		) {

			return Of(
				point, point1, fromPointToTapeTip, eave, caption, new tope_._bloc.SpreadDbl(spreadOfArrowhead, spreadOfArrowhead)
			); ;

			var tip = point1.ToOrthogonal() + fromPointToTapeTip;
			var tip1 = planar.cycle_.gon_.quad_.convex_.trape_.Perpend.ExtendTrigon_assumeTrigon(
				point,point1,tip
			);



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
				new point.CoD(point,point1)
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
			double eave
			,
			string caption
			, tope_. _bloc.SpreadDbl spreadOfArrowhead
		)
		{
			return Of(
				point,point1
				,
				fromPointToTapeTip
				,
				new num.real_.NonnegOfDouble(eave)
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
			planar.Vect4dblI fromPointToTapeTip
			,
			double eave
			,
			string caption
			, tope_._bloc.SpreadDbl spreadOfArrowhead
		)
		{
			return Of(
				point,point1
				,
				new planar.vect_.NonnilDbl(
				fromPointToTapeTip
				)
				,
				(eave)
				,
				caption
				,
				spreadOfArrowhead
			);
		}

	}
}
