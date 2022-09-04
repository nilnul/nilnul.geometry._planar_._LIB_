using nilnul.num;
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
	public class Turn : UnitI
	{
		public Real asRadian => nilnul.num.real_.Tau.Singleton.ToReal();
	}
}
