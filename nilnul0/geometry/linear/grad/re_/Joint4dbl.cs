using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.geometry.linear.vect_.basis.vector.categorize_._inside.Category;

namespace nilnul.geometry.linear.grad.re_
{
	 public class Joint4dbl
		:
		grad.Re4dblI
	{

		
		public bool re(GradDbl a, GradDbl b)
		{
			return tend.re_.Joint4dbl.Singleton.re(a, b);
		}
		public bool re(
			(double, double xMappedProj) p1
			,
			(double yBasisMappedProjected, double yEndMappedProjected) p2
		)
		{
			return tend.re_.Joint4dbl.Singleton.re(p1, p2);

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
