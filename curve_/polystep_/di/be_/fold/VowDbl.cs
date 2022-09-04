using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.polystep_.di.be_.fold
{
	public class Vow4dbl:polystep_.di.be.Vow4dbl

	{

		public Vow4dbl(double x=0):base(new Foldback4dbl(x) )
		{

		}
		public Vow4dbl():this(0)
		{

		}


		static public Vow4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Vow4dbl>.Instance;
			}
		}

	}


}
