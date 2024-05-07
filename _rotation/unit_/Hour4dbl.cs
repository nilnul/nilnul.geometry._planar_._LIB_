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
	/// 360/12 <see cref="Deg4dbl"/>
	/// </summary>
	public class Hour4dbl : _rotation.Unit4dblA
	{

		public Hour4dbl()
			:
			base(
				nilnul.num.real_._Tau4dblX.FULL /12 
			)
		{
		}


		static public Hour4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Hour4dbl>.Instance;
			}
		}

	}
}
