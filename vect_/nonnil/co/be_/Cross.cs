using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co.be_
{
	public class Cross4dbl
		:
		vect_.nonnil.co.Be4dblI
	{
		public bool be(Co4dbl obj)
		{
			return !nilnul.num.real.be_.AboutNil4Dbl.Injected.be(  co.CrossProduct.Singleton.to(obj) );
		}

		static public Cross4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cross4dbl>.Instance;
			}
		}

	}
}
