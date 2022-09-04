using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be_.dif
{
	public class VowDbl : nilnul.geometry.planar.point.co.be.vow_.BeDefaultDbl1<Dif>
		,
		point.co._vow_.OfTwoPointsI

	{
		public void vow(Point4dblI a, Point4dblI b)
		{
			vow(new point.CoD(a,b) );
		}

		static public VowDbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<VowDbl>.Instance;
			}
		}

	}
}
