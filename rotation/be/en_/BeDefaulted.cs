using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation.be.en_
{
	public class BeDefaulted<TBe>
		:
		be.En
		where TBe : planar.rotation.BeI, new()
	{
		public BeDefaulted(RotationI1 val) : base(val, nilnul.obj_.Singleton<TBe>.Instance)
		{
		}
	}
}
