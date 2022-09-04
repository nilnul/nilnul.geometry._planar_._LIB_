using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co
{
	public interface VowDblI:nilnul.obj.VowI2< planar.point.CoD>
	{
	}

	public abstract class Vow4dblA : VowDblI
		,
		_vow_.OfTwoPointsI
	{
		public void vow(CoD obj) { vow(obj.component,obj.component1); }
		public abstract void vow(
			Point4dblI a
			,
			Point4dblI b
		);
		
	}
}
