using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.point.eq
{
	public class Ne:nilnul.obj.eq.Ne< linear.PointI, linear.point.Eq>
	{

		static public Ne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ne>.Instance;
			}
		}

	}
}
