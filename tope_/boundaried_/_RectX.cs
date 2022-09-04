using nilnul.geometry.planar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tope_.boundaried_
{
	/// <summary>
	/// 
	/// </summary>
	public class _RectX
	{
		static public IEnumerable<Point4dbl> Drag2Points(
			Point4dbl origin
			,
			VectorDbl diagonal
		) {

			yield return origin;
			yield return origin+diagonal.getXFactor();
			yield return origin + diagonal;

			yield return origin + diagonal.getYFactor();

		}
	}
}
