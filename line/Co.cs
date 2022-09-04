using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line
{
	public class Co
		: nilnul.obj.Co<LineI>
	{
		public Co(Tuple<LineI, LineI> tuple) : base(tuple)
		{
		}

		public Co(LineI item1, LineI item2) : base(item1, item2)
		{
		}
	}
}
