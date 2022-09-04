using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.be
{
	public class Vow
		:
		nilnul.obj.be.Vow4<
			geometry.planar.grad_.Skid4dblI
		>
		,
		geometry.planar.grad_.skid.Vow4dblI
	{
		public Vow(BeI1<geometry.planar.grad_.Skid4dblI> be) : base(be)
		{
		}

		public Vow(Predicate<geometry.planar.grad_.Skid4dblI> predicate) : base(predicate)
		{
		}

		public Vow(Func<geometry.planar.grad_.Skid4dblI, bool> func) : base(func)
		{
		}
	}
}
