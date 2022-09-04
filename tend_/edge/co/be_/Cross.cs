using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.planar.tend_.edge.duo.be_
{
	public class Cross : BeI
	{
		public bool be(Duo obj)
		{
			return be(obj.Item1,obj.Item2);
			//throw new NotImplementedException();
		}

		public bool be(EdgeI x, EdgeI y)
		{

			return nilnul.geometry.planar.grad.co.be_.Cross.Singleton.be(x.pair,y.pair);
		}

		static public Cross Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cross>.Instance;
			}
		}

	}
}