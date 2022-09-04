using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.complex_.polar_
{

	/// <summary>
	/// for real, eg: -1.23e-3= -1.23* 10^-3
	/// for complex, eg: -3.25E-3.5= -3.23 * (cos(-3.5) + i Sin(-3.5))
	/// </summary>
	static public class _UnitalX
	{
		static public string PhraseOfAzimuthWithNoParen(nilnul.num.RealI x) {
			return $"e^i{x}";

		}
		static public string PhraseOfAzimuthWithParen(nilnul.num.RealI x) {
			return $"e^i({x})";

		}

		static public string PhraseByFloatingOfAzimuthWithParen(nilnul.num.RealI x) {
			return $"E({x})";

		}

		static public string PhraseByFloatingOfAzimuthWithNoParen(nilnul.num.RealI x) {
			return $"E{x}";

		}


	}
}