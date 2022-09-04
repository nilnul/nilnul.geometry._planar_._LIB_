using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.twin.be_
{
	public class Dif : linear.point.twin.BeI
	{
		public bool be(Twin obj)
		{
			return linear.point.eq.Ne.Singleton.ne(obj.component,obj.component1);
		}


		static public Dif Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dif>.Instance;
			}
		}

	}
}
