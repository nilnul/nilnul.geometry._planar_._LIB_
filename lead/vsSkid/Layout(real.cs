using nilnul.geometry.planar.grad_;
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
	static public class _LayoutX
	{

		/// <summary>
		/// ray to cut arrow; this is useful in a ray cutting a polygon.
		/// 
		/// </summary>
		/// <param name="arrow"> based on the arrow, we say leeway or restrict </param>
		/// <param name="lead"></param>
		/// <returns></returns>
		static public ResultI Result(
			planar.LeadI lead
			,
			planar.grad_.IArrow arrow
		)
		{
			var direction = ray.co._RotationX.Direction( lead, arrow);

			///align
			if (direction == 0 ||

				direction == nilnul.num.real_.Tau.Singleton
			)
			{
				var position = planar.lead.vsPoint._LayoutX.LeewayFalse(lead, arrow.points.ee.begin);

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
			var intersectedPoint = nilnul.geometry.planar.line.co_.crossed._CrossX._Point_ofAssumeCrossed(
				lead, arrow
			);

			var arrowVsPoint =
				planar.grad_.skid.vsPoint_.colinear._LayoutX._ofColinear(arrow, intersectedPoint);

			//	binary.be.coline.Point_To_Arrow._Eval_Position(arrowBase, intersectedPoint);


			if (direction < nilnul.num.real_.TauX.Half)
			{
				switch (arrowVsPoint)
				{
					case linear.vect_.positive.vsPoint._layout.Category.Behind:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Lag4Real(intersectedPoint);
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Start: // Point_To_Arrow.Position.Start:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Start4Real(arrow.points.ee.begin);
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Between:  // Point_To_Arrow.Position.Middle:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Between4Real(intersectedPoint);
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Stop: // Point_To_Arrow.Position.End:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Stop4Real(arrow.points.ee.end);
						break;
					case linear.vect_.positive.vsPoint._layout.Category.Forward:// Point_To_Arrow.Position.Ahead:
						return new lead.vsArrow._layout.ret_.fork_.FroLeeway2Ahead4Real(intersectedPoint);
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
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Lag4Real(intersectedPoint);

					break;
				case linear.vect_.positive.vsPoint._layout.Category.Start:// Point_To_Arrow.Position.Start:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Start4Real(arrow.points.ee.begin);
					break;
				case linear.vect_.positive.vsPoint._layout.Category.Between:// Point_To_Arrow.Position.Middle:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Between4Real(intersectedPoint);
					break;
				case linear.vect_.positive.vsPoint._layout.Category.Stop:// Point_To_Arrow.Position.End:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2End4Real(arrow.points.ee.end);
					break;
				case linear.vect_.positive.vsPoint._layout.Category.Forward:// Point_To_Arrow.Position.Ahead:
					return new lead.vsArrow._layout.ret_.fork_.FroRestrict2Ahead4Real(intersectedPoint);
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}

			//throw new NotImplementedException();

		}

		public static ResultI Result(RayI sectingLead, IArrow currentArrow)
		{
			return Result(new planar.lead_.OvRay(sectingLead) , currentArrow);
			//throw new NotImplementedException();
		}
	}
}
