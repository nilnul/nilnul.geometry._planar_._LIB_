using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.to_.scalar_
{
	public class EksMax
		:ScalarI
	{
		

		public Point4dblI to(IEnumerable<Point4dblI> src)
		{

			return nilnul.objs_.started._MaxX.Max_assumeStarted(
				src
				,
				c => c.x
				,
				nilnul.num.real.ComparerDbl.Singleton

			);

		}


		static public EksMax Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EksMax>.Instance;
			}
		}

	}
}
