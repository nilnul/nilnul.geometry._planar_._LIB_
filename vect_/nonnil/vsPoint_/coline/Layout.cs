using nilnul.geometry.linear.vect_.positive.vsPoint._layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.vsPoint_.coline
{
	static public class _LayoutX
	{
		static public linear.vect_.positive.vsPoint._layout.Category _ofColine(
			planar.vect_.NonnilI vector
			,
			planar.Point1 p_coline
		){

			return linear.vect_.positive.vsPoint._LayoutX.Layout(
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

		public static linear.vect_.positive.vsPoint._layout.Category _ofColine(NonnilI vector, PointI1 p_coline)
		{
			return linear.vect_.positive.vsPoint._LayoutX.Layout(
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

		public static linear.vect_.positive.vsPoint._layout.Category _ofColine(planar.vect_.NonnilDblI vector, planar.Point4dbl p_coline)
		{
			return linear.vect_.positive.vsPoint ._LayoutX.Layout(
				planar.vect.co.to_.real_._DotProductX.Square(vector)
				,
				planar.vect.co.to_.real_._DotProductX.Dbl(
					vector
					,
					new VectorDbl(
						p_coline
					)
				)
			);
		}

		public  static Category _ofColine(Point4dbl pointDbl1, Point4dbl pointDbl2)
		{
			return _ofColine(
				new planar.vect_.NonnilDbl(pointDbl1)
				,
				pointDbl2
			);
		}

		public static linear.vect_.positive.vsPoint._layout.Category _ofColine(Point1 vector, Point1 point)
		{
			return _ofColine(
				new planar.vect_.Nonnil(vector)
				,
				point
			);
		}
	}
}
