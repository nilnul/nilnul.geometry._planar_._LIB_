using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._sub.locus_.consec_.eg_
{
	/// <summary>
	/// 
	/// </summary>
    class IRect
    {
    }

	static public class _RectX
	{
		static public C Op(double time) {
			if (Math.Abs(time) <1)
			{
				return new System.Numerics.Complex(1, 0);
			}

			return new System.Numerics.Complex(0, 0);
		}
	}
}
