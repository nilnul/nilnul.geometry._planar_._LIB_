using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.swath_
{

	/// <summary>
	/// 
	/// </summary>
	/// <see cref="IFacet"/> , including: <see cref="IZone"/>; that is defined by a cycle. But <see cref="ISwath"/> can be without any edges, resulting a plane
	public interface IBoundarable
		:ISwath

	{

	}
}
