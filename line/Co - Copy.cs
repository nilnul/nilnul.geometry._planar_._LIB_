using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line
{
	public class CoD
		: nilnul.obj.Co<LineI>
	{
		public CoD(Tuple<LineI, LineI> tuple) : base(tuple)
		{
		}

		public CoD(LineI item1, LineI item2) : base(item1, item2)
		{
		}
	}
}
