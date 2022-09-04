using nilnul.geometry.linear_._measured.unit_.eng_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_.measured.span.distance_.eng_.inches_
{
	/// <summary>
	/// generally refers to the inner (after all, pipe is used for the inner space) diameter. so outer diameter is larger.
	/// </summary>
	static public class _PlumbingX
	{
		/// <summary>
		/// one fraction of an inch
		/// </summary>
		static public nilnul.num.RealI OneFrac = nilnul.geometry.linear_._measured.unit_.eng_.Inch.Singleton.magnitude.ToReal() / 8;

		static public nilnul.num.RealI FourFrac = Inch.Singleton.magnitude.ToReal() / 2;

		static public nilnul.num.RealI SixFrac = Inch.Singleton.magnitude.ToReal() / 8 *6;

	}
}
