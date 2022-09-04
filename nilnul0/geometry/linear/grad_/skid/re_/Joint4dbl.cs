using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.geometry.linear.vect_.basis.vector.categorize_._inside.Category;

namespace nilnul.geometry.linear.grad_.skid.re_
{
	public class Joint4dbl
	   :
	   Re4dblI
	{
		public bool re(Skid4dbl a, Skid4dbl b)
		{
			return grad.re_.Joint4dbl.Singleton.re(a, b);
			//throw new NotImplementedException();
		}
		public bool re(
			(double, double xMappedProj) p1
			,
			(double yBasisMappedProjected, double yEndMappedProjected) p2
		)
		{
			return grad.re_.Joint4dbl.Singleton.re(p1, p2);

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
