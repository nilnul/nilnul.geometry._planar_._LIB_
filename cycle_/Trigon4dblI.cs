using nilnul.geometry.planar.zone_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.cycle_
{

	
	public interface Triangle4dblI
		:ITriangle
		,
		planar.cycle_._gon_.Vertexes4dblI
		,
		planar.cycle_._gon_.Grads4dblI
	{
		planar.point.trio.be_.tripod.vow.EeD points { get; }


	}
}
