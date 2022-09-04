using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad.be_
{
	public class NonNeg : BeI
	{
		public bool be(Grad obj)
		{
			return nilnul.num.real.be_.Nonneg.Singleton.be( (obj.Item1 - obj.Item2 ).x);
			//throw new NotImplementedException();
		}


		static public NonNeg Singleton
		{
			get
			{
				return nilnul._obj.Singleton<NonNeg>.Instance;
			}
		}

	}
}
