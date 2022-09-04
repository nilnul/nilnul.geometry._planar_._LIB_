using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.point.twin.be_
{
	/// <summary>
	/// </summary>
	public class Same
		:
		BeI,
		planar.point.twin.IBeD
		,
		planar.point.IReD
	{
		static public bool _Be(Twin duo) {

			return nilnul.geometry.planar.point.Eq2.Eq(
				duo.begin , duo.end
			);
		}

		static public bool _Be(PointI1 point, PointI1 point1) {

			return _Be(new Twin(point,point1));

		}

		public bool be(Twin obj)
		{
			return _Be(obj);
			//throw new NotImplementedException();
		}

		public bool be(TwinD obj)
		{
			return re(obj.component,obj.component1);
		}

		public bool re(Point4dbl a, Point4dbl b)
		{
			return a == b;
			throw new NotImplementedException();
		}

		public bool re(Point4dblI a, Point4dblI b)
		{
			return point.EqDbl.Singleton.Equals(a,b);
			throw new NotImplementedException();
		}

		static public Same Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Same>.Instance;
			}
		}


	}
}
