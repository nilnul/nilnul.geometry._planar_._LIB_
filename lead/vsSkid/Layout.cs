using nilnul.geometry.planar.lead.vsArrow._layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.lead.vsArrow
{
	/// <summary>
	/// lead withArrow
	/// </summary>
	static public class _LayoutDblX
	{

		/// <summary>
		/// ray to cut arrow; this is useful in a ray cutting a polygon.
		/// 
		/// </summary>
		/// <param name="arrow"> based on the arrow, we say leeway or restrict </param>
		/// <param name="lead"></param>
		/// <returns></returns>
		static public ResultI Eval(
			planar.IRayDbl lead
			,
			planar.grad_.skid_.ByPoints4Dbl arrow
		)
		{
			var direction = ray.co._RotationX.Direction( lead, arrow);

			///align
			if (direction == 0 || direction == Math.PI)
			{
				var position = planar.lead.vsPoint._LayoutX.LeewayFalse(lead, arrow.begin.ToOrthogonal());

				if (position is null)
				{
					return new lead.vsArrow._layout.ret_.align_.Incident(direction == 0);
				}
				if (position == true)
				{
					return new lead.vsArrow._layout.ret_.align_.Restrict(direction == 0);

				}
				return new lead.vsArrow._layout.ret_.align_.Leeway(direction == 0);
			}

			///no align
			var intersectedPoint = nilnul.geometry.planar.line.co_.crossed.Cross4Dbl._Eval_twoIntersectingLines(
				lead, arrow
			);

			var arrowVsPoint =
				planar.grad_.skid.vsPoint_.colinear._LayoutX._ofColinear(arrow, intersectedPoint);

			//	binary.be.coline.Point_To_Arrow._Eval_Position(arrowBase, intersectedPoint);


			if (direction < Math.PI)
			{
				switch (arrowVsPoint)
				{
					case linear.vect_.positive.vsPoint._layout.Category.Behind:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Lag(intersectedPoint);
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Start: // Point_To_Arrow.Position.Start:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Start(arrow.begin.ToOrthogonal());
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Between:  // Point_To_Arrow.Position.Middle:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Between(intersectedPoint);
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Stop: // Point_To_Arrow.Position.End:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Stop(arrow.end.ToOrthogonal());
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Forward:// Point_To_Arrow.Position.Ahead:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Ahead(intersectedPoint);
						break;
					default:
						throw new UnexpectedReachException();
						break;
				}


			}

			/// rotation le pi

			switch (arrowVsPoint)
			{
				case linear.vect_.positive.vsPoint._layout.Category.Behind:// Point_To_Arrow.Position.Lag:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Lag(intersectedPoint);

					break;
				case linear.vect_.positive.vsPoint._layout.Category.Start:// Point_To_Arrow.Position.Start:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Start(arrow.begin.ToOrthogonal());
					break;
				case linear.vect_.positive.vsPoint._layout.Category.Between:// Point_To_Arrow.Position.Middle:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Between(intersectedPoint);
					break;
				case linear.vect_.positive.vsPoint._layout.Category.Stop:// Point_To_Arrow.Position.End:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2End(arrow.end.ToOrthogonal());
					break;
				case linear.vect_.positive.vsPoint._layout.Category.Forward:// Point_To_Arrow.Position.Ahead:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Ahead(intersectedPoint);
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}

			//throw new NotImplementedException();

		}
	}
}
