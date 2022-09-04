using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.be_
{
	public class NilDbl : BeDblI
	{
		public bool be(Point4dbl pointD)
		{
			return pointD.x == 0 && pointD.y == 0;
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
