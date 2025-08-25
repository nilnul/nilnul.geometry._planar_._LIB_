using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._area.unit_
{
	static public class _SqKmX
	{
		public static double SquareMetersPerSquareKm = nilnul.num.real.convert_._SquareX.Square(nilnul.geometry.linear_._measured.unit_._KmDblX.MetersPerKm);

		public static double SqKm_per_SqM = nilnul.num.real.doubl.op.Inverse.Eval(SquareMetersPerSquareKm);


	}
}
