using nilnul.geometry.planar.vect.be_.nonnil.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.norm_
{
	public class Polar4dbl
		:
		planar.Vect4dbl
		,
		planar.Vect4dblI
	{
		

		


		public Polar4dbl(double rotation)
			:base(
				 new point_.Polar4dbl(
					 rotation, 1
				)
		)
		{
		}

		static public Polar4dbl OfQuarter() {
			return new Polar4dbl(
				Math.PI/2
			);
		}

		
		static public Polar4dbl OfNegQuarter() {
			return new Polar4dbl(
				-Math.PI/2
			);
		}


	

	}
}
