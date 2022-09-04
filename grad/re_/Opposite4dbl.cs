using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad.re_
{
	/// <summary>
	/// one is the same as the other as a <see cref="ITend"/>, but different in direction.
	/// if the grad is trivia, then it's opposite to itself.
	/// </summary>
	public class Opposite4dbl : Re4dblI
	{
		public bool re(Grad4dbl_byPointsI a, Grad4dbl_byPointsI b)
		{
			return planar.point.EqDbl.Singleton.Equals(a.basis, a.finish)
				&&
				planar.point.EqDbl.Singleton.Equals(
					a.finish
					,
					b.basis
				)
			;
			//throw new NotImplementedException();
		}
		static public Opposite4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Opposite4dbl>.Instance;
			}
		}
	}
}