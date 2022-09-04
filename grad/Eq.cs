using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.grad
{

	public class Eq : IEqualityComparer<GradI>
	{

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}



		public bool Equals(GradI x, GradI y)
		{
			return point.co.Eq.Singleton.Equals(x.points, y.points);
		}

		public int GetHashCode(GradI obj)
		{
			return point.co.Eq.Singleton.GetHashCode(obj.points);

		}
	}


}
