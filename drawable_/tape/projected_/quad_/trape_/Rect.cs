using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable_.tape.projected_.quad_.trape_
{
	/// <summary>
	/// compute a quad from 3 points, with the constraint that the tape is perpendicular to the guid
	/// </summary>
	static public class _RectX
	{

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
			, double spreadOfArrowhead
		)
		{
			return Of(
				point,
				point4turn
				,
				new nilnul.num.real_.PositiveDbl(fromPointToTapeTip)
				,
			new nilnul.num.real_.NonnegOfDouble( eave)
			,caption
			,
			spreadOfArrowhead

			);
		}

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
			,double spreadOfArrowhead
		) {


			return _TrapeX.Of(
				point,point4turn
				,
				new planar.vect_.NonnilDbl(
					planar.grad._DirectionX.Direction(point,point4turn)+90
					,
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




	}
}
