using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{

	/// <summary>
	/// undirected orbit.
	/// </summary>
	/// alias:
	///		locus:
	///			start with "l" as <see cref="geometry.ILinear"/>
	///			, "l" tinges with curl
	///			,
	///			loc implies local
	///		<see cref="ICurl"/>
	///		,
	///		<see cref="ITrail"/>
	///		track
	///
	//[Obsolete(nameof(ICurl))]

	public interface ILocus :
		curl.IUndirected
		//trace_.ISpanned
	{
	}
}
