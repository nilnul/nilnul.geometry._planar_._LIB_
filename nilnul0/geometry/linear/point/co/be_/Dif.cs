using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.linear.point.co.be_
{
	public class Dif : co.BeA
		,co.BeI
		,co.Be4dblI
	{
		static public bool _Be(
			linear.PointI point
			,
			linear.PointI point1
		) {
			return nilnul.geometry.linear.point.eq.Ne.Singleton.ne(point, point1);
		}

		public override bool be(PointI a, PointI b)
		{
			return _Be(a,b);
		}

		public bool be(CoDbl obj)
		{
			return obj.Item1 != obj.Item2;

		}

		static public Dif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dif>.Instance;
			}
		}

	}
}
