using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.sig_
{
	
	public class Inside : SigI
	{
		public bool? sign(Duo obj)
		{



			return _InsideX.Inside(obj);
			
			//throw new NotImplementedException();
		}

		public bool? sign(Point x, Point y) {
			return _InsideX.Inside(x,y);
		}

		public bool? sign(Co obj)
		{
			return _InsideX.Inside(obj);

		}

		static public Inside Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Inside>.Instance;
			}
		}

	}
}
