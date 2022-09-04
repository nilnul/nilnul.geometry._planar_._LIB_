using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend.be_
{
	public class Nil : tend.BeI
	{
		public bool be(TendI obj)
		{
			return planar.point.twin.be_.Same.Singleton.be(obj.points);
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
