using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.re_
{
	/// <summary>
	/// <see cref="grad.re_.Opposite4dbl"/>
	/// 	one is the same as the other as a <see cref="ITend"/>, but different in direction.
	/// </summary>
	public class Oppo4dbl : grad_.skid.Re4dblI
	{
		public bool re(Skid4dblI a, Skid4dblI b)
		{
			return grad.re_.Opposite4dbl.Singleton.re(a, b);
		}
		static public Oppo4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Oppo4dbl>.Instance;
			}
		}
	}
}