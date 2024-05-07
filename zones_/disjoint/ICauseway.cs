using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zones_.disjoint
{
	/// <summary>
	/// eg:
	///		for 3 disjoint zones|islands, we can build 2 bridges to make a <see cref="flank"/>
	///		(if we build 3 bridges among each pair, this will logically make a hole inside, and the causeway would block the outflow, which might be intended)
	/// </summary>
	/// <remarks>
	/// the result would be <see cref="flank_"/>
	/// </remarks>
	/// <see cref="cycle_.hole.co_.apart.IChannel"/>
	internal class ICauseway:cloze.co_.disjoint.IDuct
	{
	}
}
