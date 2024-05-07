using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.surface_
{
	/// <summary>
	/// nonhole.
	/// excluding:
	///		donut
	/// </summary>
	/// <remarks>
	/// for twoD, we dont need consider self intrasecting.
	/// </remarks>
	/// <see cref="planar.IZone"/>
	/// alias
	/// stretch
	public interface ISimple:ISpread
	{
	}
}
