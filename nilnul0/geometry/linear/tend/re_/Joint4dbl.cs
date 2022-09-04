using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.geometry.linear.vect_.basis.vector.categorize_._inside.Category;

namespace nilnul.geometry.linear.tend.re_
{
	 public class Joint4dbl
		:Re4dblI
	{

		

		public bool re(Tend4dbl a, Tend4dbl b)
		{
			return nilnul.num.real.bound_.closed.re_.Intersected4dbl.Singleton.re(
				a.ToClosedBound()
				,
				b.ToClosedBound()
			);
		}

		public bool re(GradDbl a, GradDbl b)
		{
			return nilnul.num.real.bound_.closed.re_.Intersected4dbl.Singleton.re(
				a.ToClosedBound()
				,
				b.ToClosedBound()
			);

		}

		public bool re(
			(double, double xMappedProj) a
			,
			(double yBasisMappedProjected, double yEndMappedProjected) b
		)
		{
			return nilnul.num.real.bound_.closed.re_.Intersected4dbl.Singleton.re(
				a.ToClosedBound()
				,
				b.ToClosedBound()
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
