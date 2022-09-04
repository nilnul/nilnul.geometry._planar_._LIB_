using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend.duo.be_
{
	public class Cross : BeI
	{
		public bool be(Duo obj)
		{
			return be(obj.Item1,obj.Item2);
			//throw new NotImplementedException();
		}

		public bool be(TendI x, TendI y)
		{
			return nilnul.geometry.planar.grad.co.be_.Cross.Singleton.be(x.points,y.points);
			
		}
	}
}
