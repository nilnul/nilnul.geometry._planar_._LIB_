using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_.co_.decompose_.ortho_
{
	/// <summary>
	/// decompose into two normal vector
	/// </summary>

	static public class _NormalX
	{


		static public (Vect4dblI,Vect4dblI) Decompose(
			planar.Vect4dblI vect
			,
			double basisAzimuth
		) {

			var projection = decompose._ProjectionX.Project(
				vect,
				basisAzimuth
			);

			return (projection, planar.vect.op_.binary_._MinusX.Op(vect,projection));



			
		}

	}
}
