using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad_.skid.vsPoint_.colinear.be_
{
	static public class _ArrowHasPointX
	{
		static public bool _ofColinear(planar.grad_.Arrow segment, planar.Point1 _point_colinear) {

			return  planar.vect_.nonnil.vsPoint_.coline.be_._VectorHasPointX._ofColine(

				segment.ee.end-segment.ee.begin
				,
				_point_colinear - segment.ee.begin
			);
		}
	}
}
