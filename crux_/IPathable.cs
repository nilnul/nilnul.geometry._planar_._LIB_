using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.crux_
{
	/// <summary>
	/// there exists a path, allowing experiment of a run of car/missile/etc. for a single point region, this cannot be done.
	/// excluding point
	/// different from <see cref="drawable_.IConnected"/> which includes point
	/// </summary>
	/// <seealso cref="INonsingular"/>
	public interface IPathable : ICrux
	{
	}
}
