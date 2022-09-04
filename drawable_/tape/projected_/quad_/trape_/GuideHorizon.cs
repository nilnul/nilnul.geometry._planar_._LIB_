using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable_.tape.projected_.quad_.trape_
{
	/// <summary>
	/// </summary>
	static public class _GuideHorizonX
	{
		static public projected_.Quad Of(
			planar.Point4dblI point

			,
			planar.Point4dblI point4turn
			,
			nilnul.num.real_.PositiveDblI fromPointToTapeTip

			,
			nilnul.num.real_.NonnegOfDouble eave
			,
			string caption
			,
			nilnul.geometry.planar.tope_._bloc.SpreadDbl spreadOfArrowhead
		)
		{


			return _TrapeX.Of(
				point, point4turn
				,
				new planar.vect_.Horizon4dbl(
					
					fromPointToTapeTip.dblen
				)
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
			planar.Point4dblI point4turn
			,
			double fromPointToTapeTip

			,
			double eave
			,
			string caption
			,
			nilnul.geometry.planar.tope_._bloc.SpreadDbl spreadOfArrowhead
		)
		{
			return Of(
				point,
				point4turn
				,
				new nilnul.num.real_.PositiveDbl(fromPointToTapeTip)
				,
			new nilnul.num.real_.NonnegOfDouble(eave)
			, caption
			,
			spreadOfArrowhead

			);
		}



	}
}
