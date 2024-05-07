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
	/// <see cref="planar.ICoil"/>
	/// <see cref="planar.ICycle"/>
	/// <see cref="planar.ICloze"/>
	public interface IEndAtStart : IFinite
	{
	}

	public interface INoncoil { }
}
