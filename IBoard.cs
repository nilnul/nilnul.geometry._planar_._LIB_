using nilnul.geometry.planar.grad_;
using nilnul.geometry.planar.grad_.nonnil_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// like a wooden board in furniture, this is boundaried surface; there might be holes.
	/// 
	/// </summary>
	/// alias:
	///		board
	///			same initial as <see cref="surface_.IBoundarable"/>
	///
	[Obsolete(nameof(IFacet))]
	public interface IBoard
		:
		surface_.IBoundarable
	{

	}



}
