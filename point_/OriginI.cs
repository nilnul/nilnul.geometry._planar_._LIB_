using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point_
{
	/// <summary>
	/// point: [0,0]
	/// </summary>
	interface OriginI
	{
	}
	public class Origin4dbl :
		Point4dblI
	{
		public double x =>0;

		public double y => 0;


		static public Origin4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Origin4dbl>.Instance;
			}
		}

	}
}
