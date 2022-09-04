using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co
{
	public class EqD : IEqualityComparer<CoD>
	{

		public bool Equals(CoD x, CoD y)
		{
			return geometry.planar.point.EqDbl.Singleton.Equals(x.component, y.component1) && geometry.planar.point.EqDbl.Singleton.Equals(x.component1, y.component1);
			//throw new NotImplementedException();
		}
		public bool Equals((Point4dblI,Point4dblI) x, (Point4dblI,Point4dblI) y)
		{
			return geometry.planar.point.EqDbl.Singleton.Equals(x.Item1, y.Item1) && geometry.planar.point.EqDbl.Singleton.Equals(x.Item2, y.Item2);
			//throw new NotImplementedException();
		}

		public int GetHashCode((Point4dblI basis, Point4dblI finish) p)
		{
			return geometry.planar.point.EqDbl.Singleton.GetHashCode(p.basis)
				^
				geometry.planar.point.EqDbl.Singleton.GetHashCode(p.finish);

		}

		public int GetHashCode(CoD obj)
		{
			return geometry.planar.point.EqDbl.Singleton.GetHashCode(obj.component)
				^
				geometry.planar.point.EqDbl.Singleton.GetHashCode(obj.component1);
			//throw new NotImplementedException();
		}



		static public EqD Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqD>.Instance;
			}
		}


	}
}
