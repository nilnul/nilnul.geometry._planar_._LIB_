using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._rotation
{
	[Obsolete()]
	public interface UnitI
	{
		nilnul.num.Real asRadian { get; }
	}


	[Obsolete()]
	public class Unit : UnitI
	{
		public Real asRadian => 1;

		static public Unit Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Unit>.Instance;
			}
		}

	}
}
