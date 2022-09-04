using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead.vsPoint
{
	static public class _LayoutX
	{

		public static bool? LeewayFalse(LeadI lead, PointI1 c)
		{
			return nilnul.num.real._SignX.BitNul(
				nilnul.geometry.planar.coil_.gon._SurroundedX.Stokes(
					lead.arrow.points.ee.component
					,
					lead.arrow.points.ee.component1
					,c
				)
			);

		}


		public static bool? LeewayFalse(RayI sectingLead, PointI1 pointI1)
		{
			return LeewayFalse(
				new planar.lead_.OvRay(sectingLead),pointI1
			);

		}
		#region dbl

		[Obsolete("compute angle is expensive, unnecessary.")]
		static public bool? LeewayFalse(planar.ILeadDbl lead,  Point4dbl x)
		{
			var angle =  geometry.planar.angle_.Points4dbl.OfPivotIniEnd(lead.arrow.begin, lead.arrow.end, x).angle;

			var beNil = nilnul.num.real.be_.AboutNil4Dbl.Injected;

			var approx = nilnul.num.real.re_.approx_.ByInjected.Singleton;

			if (approx.re( angle , Math.PI) || beNil.be( angle))
			{
				return null;
			}
			if (angle < Math.PI)
			{
				return false;

			}
			return true;
		}
		public static bool? _LeewayTrue_assumeLead(
			Point4dblI leadStart, Point4dblI leadFinish, Point4dblI point
		)
		{
			return nilnul.num.real.Sign4dbl.Singleton.sign(
				cloze_.gon._SurroundedX._Stokes_ofStarted(
					leadStart
					,
					leadFinish
					,
					point
				)
			);
		}
		public static bool? _LeewayTrue_assumeLead(
			(Point4dblI, Point4dblI) _assumeDif, Point4dblI point
		)
		{
			return _LeewayTrue_assumeLead(_assumeDif.Item1,_assumeDif.Item2,point);
		}
		private static bool? LeewayTrue(Skid4dblI skid, Point4dblI x)
		{
			return _LeewayTrue_assumeLead(
				skid.basis
				,
				skid.finish
				,
				x
			);

		}
		static public bool? LeewayTrue(planar.Lead4dblI lead,  Point4dblI x)
		{

			return LeewayTrue(
				lead.skid
				,
				x
			);
		}



		[Obsolete()]
		public static bool? LeewayFalse(IRayDbl dirShoot, Point4dbl begin)
		{
			return LeewayFalse(
				new planar.lead_.OvRayDbl(dirShoot),begin
			);
		}

		#endregion
	}
}
