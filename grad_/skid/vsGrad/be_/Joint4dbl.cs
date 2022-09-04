using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.vsGrad.be_
{
	
	/// <summary>
	/// joint. share at least one point.
	/// </summary>
	public class Joint4dbl : Re4dblI
	{
		public bool _re_assumeSkid(Grad4dbl_byPointsI x, Grad4dbl_byPointsI y)
		{

			if (grad.be_.Collapsed4dbl.Singleton.be(y) )
			{
				return skid.vsPoint.be_.Has4dbl.Singleton._be_assumeSkid(x, y.basis);
			}
			return skid.re_.Joint4dbl.Singleton._re_assumeSkids(x, y);


		}
		public bool re(Skid4dblI x, Grad4dbl_byPointsI y)
		{
			return _re_assumeSkid(x,y);

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
