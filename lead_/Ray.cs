using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.lead_
{
	public class OvRay
		: nilnul.obj.Box<planar.RayI>
		,
		LeadI
	{
		public OvRay(RayI val) : base(val)
		{
		}

		public IArrow arrow =>  new Arrow(
			boxed.src,
			planar.point.convert_._ShiftX.Shift(
				this.boxed.src,
				ray._VectorX.VectorNonnil(  boxed )
			)
		);
	}
}
