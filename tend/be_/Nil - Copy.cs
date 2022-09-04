using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend.be_
{
	public class NilDbl : tend.BeDblI
	{
		public bool be(planar.Tend4dblI obj)
		{
			return planar.point.twin.be_.Same.Singleton.be(obj.points);
		}


		static public NilDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NilDbl>.Instance;
			}
		}

	}
}
