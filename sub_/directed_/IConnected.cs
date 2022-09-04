using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.directed_
{
	/// <summary>
	/// This is not <see cref="planar.ITrail0_1"/> as this includes the empty
	/// </summary>
	public interface IConnected
		:IDirected
		,
		sub_.IConnected
	{
	}
}
