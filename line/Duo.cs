using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_.peg
{
	public class Duo : nilnul.obj.Duo<line_.Peg>
	{
		public Duo(Tuple<Peg, Peg> tuple) : base(tuple)
		{
		}

		public Duo(Peg item1, Peg item2) : base(item1, item2)
		{
		}
	}
}
