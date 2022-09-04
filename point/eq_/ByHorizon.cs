using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.eq_
{
	public class ByHorizonDbl
		: EqDblI
	{
		public bool Equals(Point4dbl x, Point4dbl y)
		{
			return x.x == y.x;
			//throw new NotImplementedException();
		}

		public bool Equals(Point4dblI x, Point4dblI y)
		{
			return x.x == y.x;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Point4dbl obj)
		{
			return obj.x.GetHashCode();
		}

		public int GetHashCode(Point4dblI obj)
		{
			return obj.x.GetHashCode();
		}


		//static private Lazy<ByHorizon> _Lazy = new Lazy<ByHorizon>(()=>Singleton);
		//static public ByHorizon Lazy
		//{
		//	get
		//	{
		//		return _Lazy.Value;
		//	}
		//}


		static public ByHorizonDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ByHorizonDbl>.Instance;
			}
		}




	}
}
