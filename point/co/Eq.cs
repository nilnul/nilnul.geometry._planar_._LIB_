using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co
{
	public class Eq : IEqualityComparer<Co>
	{

		public bool Equals(Co x, Co y)
		{
			return geometry.planar.point.Eq2.Singleton.Equals(x.component, y.component)
				&& geometry.planar.point.Eq2.Singleton.Equals(x.component1, y.component1);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Co obj)
		{
			return geometry.planar.point.Eq2.Singleton.GetHashCode(obj.component)
				^
				geometry.planar.point.Eq2.Singleton.GetHashCode(obj.component1);
			//throw new NotImplementedException();
		}



		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
