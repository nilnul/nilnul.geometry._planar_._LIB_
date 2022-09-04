using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.vsPoint_.coline.be_
{
	static public class _VectorHasPointX
	{
		static public bool _ofColine(
			planar.IVector vector
			,
			planar.Point1 p_coline
		){

			return linear.vect_.nonneg.vsPoint.be_._HasX._Be(
				planar.vect.co.to_.real_._DotProductX.RealI(vector,vector)
				,
				planar.vect.co.to_.real_._DotProductX.RealI(
					vector
					,
					new Vector1(
						p_coline
					)
				)
			);
		}

		static public bool _AssumeColine(
			planar.Vect4dblI vector
			,
			planar.Point4dblI _assumeColine
		){

			return linear.vect_.nonneg.vsPoint.be_._HasX._Be_assumeNonneg(
				planar.vect.co.to_.real_._DotProductX.Dbl(vector,vector)
				,
				planar.vect.co.to_.real_._DotProductX.Dbl(
					vector
					,
					new Vect4dbl(
						_assumeColine
					)
				)
			);
		}

		public static bool _ofColine(Vector1 vector, Point1 point)
		{
			return _ofColine(
				(IVector)(vector)
				,
				point
			);
		}

		public static bool _ofColine(Point1 vector, Point1 point)
		{
			return _ofColine(
				new planar.Vector1(vector)
				,
				point
			);
		}

	}
}
