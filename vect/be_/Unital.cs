using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.real;

namespace nilnul.geometry.planar.vect.be_
{
	public class Unital : planar.vect.BeI1
		,
		planar.vect.Be4dblI
	{
		public bool be(IVector obj)
		{
			return planar.vect._MagnitudeX.Magnitude(obj) ==1;
			
		}

		public bool be(Vect4dblI obj)
		{
			return nilnul.num.real.re_.approx_.ByInjected.Singleton.re(
				obj.Distance(),1
			);
			//throw new NotImplementedException();
		}


		static public Unital Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unital>.Instance;
			}
		}


	}
}
