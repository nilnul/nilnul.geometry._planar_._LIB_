using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_.gtNegTau_
{
	public class LtTau4Dbl :
		rotation_.Radian4dbl
	{
		public LtTau4Dbl(nilnul.num.real.be_.gtNegTau_.ltTau.vow.Ee4dbl val) : base(val)
		{
		}
		public LtTau4Dbl(double val) : this(new num.real.be_.gtNegTau_.ltTau.vow.Ee4dbl(val))
		{
		}

		static public LtTau4Dbl Create_byCannonize(double r)
		{
			if (r >= 0)
			{
				return new LtTau4Dbl(
								nilnul.num.real_.floored._TailX.Doub(r / nilnul.num.real_.TauX.IntoDouble) * nilnul.num.real_.TauX.IntoDouble
							);
			}

			return new LtTau4Dbl(
							-nilnul.num.real_.floored._TailX.Doub(-r / nilnul.num.real_.TauX.IntoDouble) * nilnul.num.real_.TauX.IntoDouble
						);

		}

	}
}
