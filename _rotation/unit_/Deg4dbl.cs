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
	/// one degree =  1/360 round.
	/// </summary>
	public class Deg4dbl : _rotation.Unit4dblA
	{

		public Deg4dbl()
			:
			base(
				Turn4dbl.Singleton.magnitude.dblen.ee/360 
			)
		{
		}


		static public Deg4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Deg4dbl>.Instance;
			}
		}

	}
}
