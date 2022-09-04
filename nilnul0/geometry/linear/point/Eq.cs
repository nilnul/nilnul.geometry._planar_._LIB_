using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point
{
	public class Eq :
		nilnul.obj.eq_.Homomorph<linear.PointI, num.RealI>
		,
		nilnul.obj.EqI<linear.PointI>
	{
		public Eq() : base(
			p=>p.x
			,
			nilnul.num.real.Eq.Singleton
		)
		{

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
