using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.map_
{
	/// <summary>
	/// nonlinear mapping. this cannot be a proj, as that is linear. So this must be a trans.
	/// this is synonym to trans
	/// </summary>
	public interface INonmatrix:

		IMap
		//,
		//nilnul.obj.alias
	{
	}
}
