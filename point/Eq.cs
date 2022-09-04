
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace nilnul.geometry.planar.point
{
	public class Eq2
		: 
		IEqualityComparer<PointI1>
	{
		static public Eq2 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq2>.Instance;
			}
		}

		static public bool Eq(PointI1 a, PointI1 b)
		{
			return
				nilnul.num.real.Eq.Singleton.Equals(

				a.x, b.x
				) &&
				nilnul.num.real.Eq.Singleton.Equals(

				a.y, b.y
				);
		}

		public  bool Equals(PointI1 x, PointI1 y)
		{
			return Eq(x, y);
			//throw new NotImplementedException();
		}

		public  int GetHashCode(PointI1 obj)
		{
			return obj.x.GetHashCode() ^ obj.y.GetHashCode();
			//throw new NotImplementedException();
		}
	}
}