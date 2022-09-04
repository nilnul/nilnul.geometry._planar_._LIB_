using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.re_
{
	
	/// <summary>
	/// joint. share at least one point.
	/// </summary>
	public class Joint4dbl : Re4dblI
	{
		public bool re(Grad4dbl_byPointsI x, Grad4dbl_byPointsI y)
		{

			if (grad.be_.Skid4dbl.Singleton.be(x) )
			{
				return grad_.skid.vsGrad.be_.Joint4dbl.Singleton._re_assumeSkid(x, y);
			
			}

			//x is a point

			return grad.vsPoint.be_.Joint4dbl.Singleton.re(
				y
				,
				x.basis
			);
		}

		static public Joint4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Joint4dbl>.Instance;
			}
		}


	}
}
