using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_
{
	/// <summary>
	/// any two points can be connected by an inner path.
	/// this is different from <see cref="planar.ICrux"/> as this can be empty.
	/// </summary>
	public interface IConnected : ISub
	{
	}
}
