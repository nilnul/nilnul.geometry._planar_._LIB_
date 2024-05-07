using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// including :
	///		shortcut: a point
	///		intersected
	///	
	///		
	/// </summary>
	/// <remarks>
	/// this is not a curve as this might be a point
	/// </remarks>
	/// cloze is directed. for undirected inner area, <see cref="planar.ITope"/> or <see cref="planar.IZone"/>
	/// alias:
	///		circuit
	///		recycle
	public interface ICloze : trav_.IEndAtStart
	{
	}
}