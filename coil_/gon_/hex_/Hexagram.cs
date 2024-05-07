using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_.hex_
{
	/// <summary>
	/// 六角星
	/// ，
	/// YinYang BiTrigon
	/// </summary>
	/// <remarks>
	/// note: to draw each <see cref="zone_.trigon_.IIsoscele"/> complete fro vertex to vertex, the two wouldnot be continous. Rather, we need to draw from one intersected point of the two triangles, and in this case, it's a coil, continous.
	/// </remarks>
	static public class _HexagramX
	{
		static public IEnumerable<Complex> WithinUnialDisk()
		{
			yield return  Complex.FromPolarCoordinates(1, 0);
			yield return Complex.FromPolarCoordinates (1,  rotation_.Degree4dbl.ToRadian(120));
			yield return Complex.FromPolarCoordinates (1,  rotation_.Degree4dbl.ToRadian(240));

			Complex transchange = Complex.FromPolarCoordinates(rotation_.deg_.thirty._TrignomyX.TgAsDbl, rotation_.Degree4dbl.ToRadian(-30));

			yield return transchange;

			yield return Complex.FromPolarCoordinates (1,  rotation_.Degree4dbl.ToRadian(60));
			yield return Complex.FromPolarCoordinates (1,  rotation_.Degree4dbl.ToRadian(180));
			yield return Complex.FromPolarCoordinates (1,  rotation_.Degree4dbl.ToRadian(300));

			yield return transchange;




		}
	}
}
