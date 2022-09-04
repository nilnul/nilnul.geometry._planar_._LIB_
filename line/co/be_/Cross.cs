using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_.peg.duo.be_
{
	
	public class Cross : BeI
	{

		public bool be(Duo obj)
		{
			return peg.re_.Inter.Singleton.re(obj.Item1,obj.Item2);
			
			
			//throw new NotImplementedException();
		}


		static public Cross Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Cross>.Instance;
			}
		}

	}
}
