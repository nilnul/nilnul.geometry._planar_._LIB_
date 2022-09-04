using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead_
{
	public class OvRayDbl
		: nilnul.obj.Box<planar.IRayDbl>
		,
		ILeadDbl
	{
		public OvRayDbl(IRayDbl val) : base(val)
		{
		}

		public grad_.skid_.ByPoints4Dbl arrow =>  new grad_.skid_.ByPoints4Dbl(
			boxed.src,
			planar.point.convert_._ShiftX.Shift(
				this.boxed.src.ToOrthogonal(),
				ray._VectorX.VectorNonnil(  boxed )
			)
		);
	}
}
