using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vector.be
{
	public class En<TBe> : 
		nilnul.obj.be.En2<VectorI, TBe>
		where TBe : BeI,new()
	{
		public En(VectorI val) : base(val)
		{
		}
	}
}
