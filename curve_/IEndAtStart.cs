using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_
{
	/// <summary>
	/// the start and the end meet. there might be intersection in the middle.
	/// eg:
	///		circle
	///		8 and <see cref="splash_.polygon_.tetra_.Butterfly"/>
	/// </summary>
	/// <remarks>
	/// <see cref="planar.ICoil"/>
	/// </remarks>
	/// <see cref="planar.ICycle"/>
	/// vs:
	///		<see cref="planar.ICloze"/>, no point:<see cref="planar.cloze_.ISpanned"/>
	public interface IEndAtStart : IFiniteLong
	{
	}
}
