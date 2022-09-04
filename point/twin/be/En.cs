using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin.be
{
	public class En<TBe>
		:nilnul.obj.be.En2<Twin,TBe>
		where TBe:BeI,new()

	{

		public En(Twin duo):base(duo)
		{

		}
	}
}
