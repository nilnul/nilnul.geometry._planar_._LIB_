using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad.be_
{
	public class Vertical0point
		: grad.Be4dblI
	{
		public bool be(Grad4dbl_byPointsI obj)
		{
			return obj.basis.x == obj.finish.x;
			//throw new NotImplementedException();
		}


		static public Vertical0point Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Vertical0point>.Instance;
			}
		}

	}
}
