using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co
{
	static public class _Hexagon8concaveX
	{
		static public IEnumerable<(double x, double y)> Parlgra(
			(double x, double y) vect
			,
			(double x, double y) vect1
		) {

			
			//yield return vect;
			yield return (vect.x, vect1.y);
			//yield return vect1;
			yield return (0, vect1.y);
			yield return (0, vect.y);
			yield return (vect1.x,vect.y);
			yield return (vect1.x,0);
			yield return (vect.x,0);

			/// it's concave if the rotation is le quarter.
			/// it's a self-intersect one,
			/// 
			/// <see cref="planar.cloze_.gon_.orthy"/>


		}
	}
}
