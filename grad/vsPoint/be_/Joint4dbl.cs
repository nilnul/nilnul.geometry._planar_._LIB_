using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.vsPoint.be_
{
	
	/// <summary>
	/// joint. share at least one point.
	/// </summary>
	public class Joint4dbl
		:
		Re4dblI
	{
		public bool re(Grad4dbl_byPointsI x, Point4dblI y)
		{
			if (grad.be_.Collapsed4dbl.Singleton.be(x) )
			{
				return point.EqDbl.Singleton.Equals(x.basis, y);
			}
			return  planar.grad_.skid.vsPoint.be_.Has4dbl.Singleton._be_assumeSkid(x,y);

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
