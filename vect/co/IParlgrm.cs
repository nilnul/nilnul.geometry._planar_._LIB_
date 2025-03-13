using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co
{
	static public class _ParlgrmX
	{
		static public IEnumerable<(double x, double y)> Parlgra(
			(double x, double y) vect
			,
			(double x, double y) vect1
		) {

			yield return (0, 0);
			yield return vect;
			yield return planar.vect.of_.binary_._AddX.Op(vect,vect1);
			yield return vect1;
		}
	}
}
