using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar_
{
	/// <summary>
	/// a coordinated planar system built per human perspective. <see cref="nameof(geometry.planar_.ergo_.ILevel)"/> <see cref="nameof(planar_.ergo_.level_.IBoard)"/>
	/// </summary>
	/// <remarks>
	/// 长 宽 高
	///		<see cref="nameof(nilnul.geometry.)"/>
	/// </remarks>
	public interface IErgo
		:nilnul.geometry.linear_.IErgo // which is horizon. We need to add a vertical here.

	{
	}
}
