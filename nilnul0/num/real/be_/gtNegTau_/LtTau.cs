using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.gtNegTau_
{
	public class LtTau4Dbl : nilnul.num.real.BeDblI
	{
		public bool be(double obj)
		{
			return be_.GtNegTau4Dbl.Singleton.be(obj) && be_.LtTau4Dbl.Singleton.be(obj);
			//throw new NotImplementedException();
		}


		static public LtTau4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LtTau4Dbl>.Instance;
			}
		}

	}
}
