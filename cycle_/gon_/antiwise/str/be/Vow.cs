using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.antiwise.str.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<IEnumerable<cycle_.gon_.Antiwise4dbl>>
	{
		public Vow(BeI1<IEnumerable<Antiwise4dbl>> be) : base(be)
		{
		}

		public Vow(Predicate<IEnumerable<Antiwise4dbl>> predicate) : base(predicate)
		{
		}

		public Vow(Func<IEnumerable<Antiwise4dbl>, bool> func) : base(func)
		{
		}
	}
}
