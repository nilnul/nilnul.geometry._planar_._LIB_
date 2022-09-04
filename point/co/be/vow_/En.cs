using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.pointD.duo.be
{
	/// <summary>
	/// 
	/// </summary>
	public class En<TBe>
		: nilnul.obj.be.En_beDefaultable<Duo, TBe>
	where TBe : BeI, new()
	{
		public En(Duo val) : base(val)
		{
		}
	}
}
