using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon.str.be_
{
	public class SiegeProper
		:
		str.BeI
	{
		public bool be(IEnumerable<Polygon4dblI> obj)
		{
			return new nilnul.obj.co.str.of_._PeekAhead_ovStr<Polygon4dblI>(obj).All(
				c=> gon.re_.CloseInner.Singleton.re(c)
			);
			//throw new NotImplementedException();
		}


		static public SiegeProper Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SiegeProper>.Instance;
			}
		}

	}
}
