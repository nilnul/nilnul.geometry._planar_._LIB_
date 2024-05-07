using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.cubic_
{
	internal class FoliumOfDescartes
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a">parameter</param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public bool Predicate(double a, double x, double y) {
			return x * x * x + y * y * y - 3 * a * x * y == 0;
		}
	}
}
