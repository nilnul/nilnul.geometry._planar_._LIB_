using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.bag.be_
{
	public class Plural
		: nilnul.geometry.planar.point.bag.BeDblI
	{
		public bool be(BagDbl obj)
		{

			return obj.keysPositive.Skip(1).Any();
			;
		}


		static public Plural Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Plural>.Instance;
			}
		}

	}
}
