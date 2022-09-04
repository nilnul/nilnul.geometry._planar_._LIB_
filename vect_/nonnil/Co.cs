using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil
{
	public class Co : nilnul.obj.Co<vect_.Nonnil>
	{
		public Co(Tuple<vect_.Nonnil, vect_.Nonnil> tuple) : base(tuple)
		{
		}

		public Co(vect_.Nonnil item1, vect_.Nonnil item2) : base(item1, item2)
		{
		}
	}
}
