using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.be_
{
	public class NondecreaseDbl : co.BeDblI
	{
		public bool be(CoD obj)
		{
			return obj.Item1.x <= obj.Item2.x
				&& obj.Item1.y <= obj.Item2.y;
			//throw new NotImplementedException();
		}

		static public NondecreaseDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NondecreaseDbl>.Instance;
			}
		}

	}
}
