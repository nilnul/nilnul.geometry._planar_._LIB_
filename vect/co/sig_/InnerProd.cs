using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vector.co.sig_
{
	/// <summary>
	/// -1 obtuse
	/// 0 right (including one is zero)
	/// 1 acute
	/// </summary>
	public class InnerProd : nilnul.obj.SignI<Co>
	{
		public bool? sign(Co obj)
		{
			return nilnul.num.real.Sign.Singleton.sign(
				vector.co.to_.real_.InnerProduct.Singleton.to(obj)
			);
			throw new NotImplementedException();
		}


		static public InnerProd Singleton
		{
			get
			{
				return nilnul._obj.Singleton<InnerProd>.Instance;
			}
		}

	}
}
