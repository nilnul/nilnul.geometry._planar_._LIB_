using nilnul.num;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._rotation.unit_
{
	/// <summary>
	/// tau sounds some like Turn
	/// </summary>
	public class Turn4dbl : _rotation.Unit4dblA
	{
		

		public Turn4dbl() : base( nilnul.num.real_._Tau4dblX.FULL)
		{
		}


		static public Turn4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Turn4dbl>.Instance;
			}
		}

	}
}
