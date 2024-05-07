using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.ray.co
{
	static public  class _RotationX
	{
		static public Rotation1 Rotation(RayI dir, RayI dir1) {

			return  planar.rotation.co.band_._MinusX.Minus(dir1.rotation, dir.rotation);

		}

		public static Rotation1 RotationNeighborTau(LeadI lead, IArrow arrow)
		{
			return  planar.rotation.co.band_._MinusX.Minus(
				planar.grad_.skid._DirectionX.Direction(arrow)
				,
				planar.grad_.skid._DirectionX.Direction(lead.arrow)

			);


		}
		public static rotation_.Direction Direction(LeadI lead, IArrow arrow)
		{
			return planar.rotation_.Direction.Create_byCannonize_assumeNeighborTau(RotationNeighborTau(lead,arrow));
		}

		static public double Rotation(IRayDbl dir, IRayDbl dir1)
		{
			return
				dir1.rotation - dir.rotation;
		}
		public static double Rotation(grad_.skid_.ByPoints4Dbl arrowBase, IRayDbl dirShoot)
		{
			return Rotation(
				new ray_.OnArrowDbl(arrowBase), dirShoot
			);
		}
		public static double Direction(IRayDbl arrowBase, IRayDbl dirShoot)
		{
			return planar.rotation_.DirectionDbl.Create_byCannonize(
				Rotation(
					(arrowBase),
					dirShoot
				)
			);
		}


		public static double Direction(grad_.skid_.ByPoints4Dbl arrowBase, IRayDbl dirShoot)
		{
			return planar.rotation_.DirectionDbl.Create_byCannonize(
				Rotation(
				(arrowBase), dirShoot
			));
		}

		public static double Direction(IRayDbl lead, grad_.skid_.ByPoints4Dbl arrowBase)
		{
			return Direction(
				lead,
				new ray_.OnArrowDbl(arrowBase)
			);
		}


	}
}
