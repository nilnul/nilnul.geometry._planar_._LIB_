using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.str.vow
{
	public class Ee4dbl<TVow> : nilnul.obj.vow.Ee1<IEnumerable<planar.grad_.Skid4dblI>, TVow>
		where TVow : nilnul.obj.VowI2<IEnumerable<planar.grad_.Skid4dblI>>
	{
		public Ee4dbl(IEnumerable<planar.grad_.Skid4dblI> val, TVow vow) : base(val, vow)
		{
		}
	}
	public class Ee4dbl : Ee4dbl<
		nilnul.obj.VowI2<IEnumerable<planar.grad_.Skid4dblI>>
	>

	{
		public Ee4dbl(
			IEnumerable<planar.grad_.Skid4dblI> val, VowI2<IEnumerable<planar.grad_.Skid4dblI>> vow
		) : base(val, vow)
		{
		}
	}

}
