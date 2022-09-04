using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.zone_.gon_
{
	/// <summary>
	/// including trivia case:
	///		1) thre points are the same
	///			this is not in alignment with the definition of polygon
	///		2) two points are the same
	///			this is not in alignment with the definition of polygon
	///		3) three points share a line
	///			for points not sharing a line, use <see cref="nameof(planar.ITrigon)"/>
	/// </summary>
	public interface ITri {

	}
	
}
