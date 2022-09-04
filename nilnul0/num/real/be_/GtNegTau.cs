using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{
	public class GtNegTau4Dbl : nilnul.num.real.BeDblI
	{
		public bool be(double obj)
		{
			return obj < nilnul.num.real_.TauX.IntoDouble;
			//throw new NotImplementedException();
		}


		static public GtNegTau4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<GtNegTau4Dbl>.Instance;
			}
		}

	}
}
