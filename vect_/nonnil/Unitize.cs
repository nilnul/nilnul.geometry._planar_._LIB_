using nilnul.geometry.planar.vect;
using nilnul.geometry.planar.vect.op_.unary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil
{
	static public class _UnitizeX
	{
		static public Vect4dbl UnitizeAsVect(this vect_.Nonnil4dblI nonnil) {
			return nonnil.Scale(
				1/
				nonnil.Distance()
			);
		}

		static public Unital4dbl UnitizeAsUnital(this vect_.Nonnil4dblI nonnil) {
			return new vect_.Unital4dbl((nonnil.UnitizeAsVect()));
		}


	}
}
