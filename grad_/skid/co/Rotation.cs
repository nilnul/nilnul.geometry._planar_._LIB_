using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.co
{
	static public class _TurnX
	{
		static public planar.Rotation1 Rotation(planar.grad_. Arrow a, planar.grad_. Arrow end) {
			return  ( end.direction - a.direction );
		}
		static public rotation_.Direction Direction(planar.grad_. Arrow a, planar.grad_. Arrow end) {
			return  rotation_.Direction.Create_byCannonize_assumeNeighborTau(
				Rotation(a,end)
			);
		}

		static public rotation_.DirectionDbl Direction(planar.grad_.skid_.ByPoints4Dbl a, grad_.skid_.ByPoints4Dbl end) {
			return new rotation_.DirectionDbl( end.direction - a.direction );
		}

		public static double Rotation(Point4dbl a, Point4dbl b1, Point4dbl b2, Point4dbl c)
		{

			return Rotation(
				new grad_.skid_.ByPoints4Dbl(a,b1)
				,
				new grad_.skid_.ByPoints4Dbl(b2,c)
			);
			//throw new NotImplementedException();
		}

		public static double Rotation(grad_.skid_.ByPoints4Dbl currentDir, IRayDbl sectingDir)
		{
			return ( sectingDir.rotation - currentDir.direction );
		}

		public static double Rotation(grad_.skid_.ByPoints4Dbl currentDir, grad_.skid_.ByPoints4Dbl sectingDir)
		{
			return vect_.nonnil.co._RotationX.Rotation(
				currentDir.Vector()
				,
				sectingDir.Vector()
			);
		}

		public static rotation_.DirectionDbl Direction(grad_.skid_.ByPoints4Dbl currentDir, IRayDbl sectingDir)
		{
			return  rotation_.DirectionDbl.Create_byCannonize_assumeNeighborTau( Rotation(currentDir,sectingDir) );
		}

	}
}
