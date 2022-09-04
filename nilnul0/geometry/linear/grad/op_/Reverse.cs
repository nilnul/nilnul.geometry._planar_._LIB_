using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad.op_
{
	public class Reverse : OpI
	{
		public Grad op(Grad arg)
		{
			return new Grad(arg.Item2,arg.Item1);
			throw new NotImplementedException();
		}


		static public Reverse Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Reverse>.Instance;
			}
		}

	}
}
