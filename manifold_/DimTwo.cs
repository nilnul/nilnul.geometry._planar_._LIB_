using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.manifold_
{
	/// <summary>
	/// two dimensional continuous for every point, except edge. edge is 1d continuos.
	/// For a closed set, we can convert it to an open set by removing the edge interimly.
	/// including adacent two discs.
	/// </summary>
	/// <remarks>
	/// use case:
	///		in furniture, to make a board tenuale, it must be 2d every where.
	/// </remarks>
	/// also known as <see cref="planar.ISurface"/>
	/// 
	public interface IDimTwo : IManifold
	{
	}
}
