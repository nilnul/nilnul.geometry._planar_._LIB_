using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.connected_
{
	/// <summary>
	/// 2d everywhere.
	///		eg:tangigent two discs.
	/// </summary>
	/// sweep
	public interface ISpread:
		IConnected
		,
		manifold_.IDimTwo
	{
	}
}
