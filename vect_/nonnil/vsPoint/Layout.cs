using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.vect_.nonnil.vsPoint
{
	static public  class _LayoutX
	{
		static public nilnul.geometry.planar.grad_.skid.vsPoint._layout.Category Layout(planar.vect_.NonnilI vector, planar.PointI1 point) {

			switch (nilnul.num.real._SignX.BitNul(planar.vect.co._CrossProductX.AreaOfParallelogram(vector, new planar.Vector1(point)))
				)
			{
				case null:
					return (nilnul.geometry.planar.grad_.skid.vsPoint._layout.Category)vect_.nonnil.vsPoint_.coline._LayoutX._ofColine(vector, point);
				case true:
					return grad_.skid.vsPoint._layout.Category.Interior;
				case false:
				default:
					return grad_.skid.vsPoint._layout.Category.External;

			}




		}

	
	}
}
