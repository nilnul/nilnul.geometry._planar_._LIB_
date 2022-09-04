using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.be_
{
	public class Nil : BeI
	{
		public bool be(PointI1 obj)
		{
			return nilnul.num.real.be_.Nil.Singleton.be(obj.x)

				&&
				nilnul.num.real.be_.Nil.Singleton.be(obj.y);
			//throw new NotImplementedException();
		}


		static public Nil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil>.Instance;
			}
		}

	}
}
