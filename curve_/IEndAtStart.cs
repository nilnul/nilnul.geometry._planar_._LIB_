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
	///		8 and <see cref="spread_.polygon_.tetra_.Butterfly"/>
	/// </summary>
	public interface IEndAtStart : IFinite
	{
	}
}
