using nilnul.geometry.planar.rotation_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid
{
	/// <summary>
	/// 
	/// </summary>
	static public class _DirectionX
	{

		static public rotation_.Direction _Direction_assumeDif(planar.Point1 a, planar.Point1 b)
		{
				return planar.vect_.nonnil._DirectionX._ofAssumeNonnil(
					b - a
				);
		}

		static public rotation_.Direction _Direction_assumeDif(planar.PointI1 a, planar.PointI1 b)
		{
				return _Direction_assumeDif(
					b.ToPoint(), a.ToPoint()
				);
		}

		static public double _Direction_assumeDif(planar.Point4dblI a, planar.Point4dblI b)
		{
			
				return planar.vect_.nonnil._DirectionX._Ge0LtTau_ofAssumeNonnil(
					planar.grad_._StepX.Vect(
					a,b
					)
				);
			
		}

		static public double _Direction_assumeDif(planar.Point4dbl a, planar.Point4dbl b)
		{
			
				return planar.vect_.nonnil._DirectionX._Ge0LtTau_ofAssumeNonnil(
					b - a
				);
			
		}

		public static rotation_.Direction Direction(Arrow stop)
		{
			return planar.vect_.nonnil._DirectionX._ofAssumeNonnil(grad_.skid._VectorX.Vector(stop));

		}
		public static rotation_.Direction Direction(IArrow stop)
		{
			return planar.vect_.nonnil._DirectionX._ofAssumeNonnil(grad_.skid._VectorX.Vector(stop));

		}


		public static double Direction(grad_.skid_.ByPoints4Dbl stop)
		{
			return planar.vect_.nonnil._DirectionX._Ge0LtTau_ofAssumeNonnil(grad_.skid._VectorX.Vector(stop));

		}

		public static double GtNegPiLePi(Skid4dblI line)
		{

			return planar.vect_.nonnil._DirectionX._GtNegPiLePi__ofAssumeNonnil(
				grad._DisplaceX.Vect(line)
			);

		}
	}
}
