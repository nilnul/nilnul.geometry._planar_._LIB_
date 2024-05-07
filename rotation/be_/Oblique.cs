using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.rotation.be_
{
	public  class Oblique
	{
		static public bool Be(double radian) {
			return ! ObliqueNot.Be( radian / ( Math.PI / 2) );
		}
	}

}
