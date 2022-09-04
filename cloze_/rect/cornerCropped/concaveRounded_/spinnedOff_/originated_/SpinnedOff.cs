using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.rect.cornerCropped.concaveRounded_.spinnedOff_.originated_
{

	static public class _RightwardX
	{
		static public ConcaveRounded ConcaveRounded(
			 num.real_.NonnegOfDoubleI  radius
			,
			 num.real_.NonnegOfDoubleI horizonEdgeRemained

			,




		 num.real_.NonnegOfDoubleI verticalEdgeRemained
		
		) {
			return new ConcaveRounded() {
				starter=new planar.Point4dbl(
					radius.realee*2
					,
					0
				)
				,
				vectTop=new planar.vect_.Horizon4dbl(
					horizonEdgeRemained
					)
				,
				radius=radius
				,
				cornerDownward=radius
				,
				cornerRightward=radius
				,
				verticalEdgeRemain=verticalEdgeRemained
			};

		}

		//static public ConcaveRounded OfBounding(
		//	 num.real_.NonnegOfDoubleI horizon
		//	,




		// num.real_.NonnegOfDoubleI verticalEdgeRemained

		//	,
		//	 num.real_.NonnegOfDoubleI  radius
		
		//) {
		//	return OriginHorizontally(
		//		new 
		//	);

		//}


		static public ConcaveRounded OfBounding(
			double width
			,




		 double height

			,
			double radius
		
		) {
			var diameter = radius * 2;
			var diameterDouble = diameter * 2;
			return ConcaveRounded(
				new nilnul.num.real_.NonnegOfDouble(radius)
				,
				new nilnul.num.real_.NonnegOfDouble(


				width-diameterDouble
				)
				,
				new nilnul.num.real_.NonnegOfDouble(


				height-diameterDouble
				)


			);

		}

	}
}
