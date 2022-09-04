using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.deg_.thirty
{

	static public class _TrignomyX
	{
		public const double SinAsDbl = 1d / 2;
		public static nilnul.num.RealI Sin = new nilnul.num.real_.Quotient(1, 2);

		public static double CosAsDbl = Math.Sqrt(3) / 2;
		public static nilnul.num.RealI Cos = nilnul.num.real.op_.unary_.Sqrt.Singleton.op(3).ToReal()/2;

		public static double TgAsDbl = Math.Sqrt(3) / 3;
		public static double CtgAsDbl = Math.Sqrt(3);

	}
}
