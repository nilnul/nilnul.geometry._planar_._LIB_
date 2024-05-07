using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.holes_.apart
{
	/// <summary>
	/// for n holes, we need only n-1 channels, to make them a monolithic marsh|sediment.
	/// if build n channels to form a cycle, an island would be secluded innerly, and it can go out, which is not favorable.
	/// </summary>
	/// <see cref="cloze.co_.disjoint.IDuct"/>
	/// vs:
	///		<see cref="zone.co_.disjoint.IBridge"/>
	/// 
	internal class IChannel:cloze.co_.disjoint.IDuct
	{
	}
}
