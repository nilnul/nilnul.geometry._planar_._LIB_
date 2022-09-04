using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.complex_.polar_
{
	/// <summary>
	/// r*e^ix, where r=1
	/// </summary>
	/// alias:
	///		normal
	public class Unital : nilnul.num.complex_.Polar
	{
		public Unital( R azimuth) : base(1, azimuth)
		{
		}

		



		static public string Phrase(R x)
		{
			return $"e^i{x}";

		}

		/// like in JS/C#, we can denote a floating number as:
		///		300.5e-3
		///	we can also denote a complex number as:
		///		1.5E3.7
		///			which is 1.5* e^i(3.7)
		static public string PhraseByFloating(R x)
		{
			return $"E{x}";

		}

		public override string ToString()
		{
			return PhraseByFloating(this.azimuth);
		}



	}
}
