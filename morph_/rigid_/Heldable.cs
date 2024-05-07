using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rigid_
{
	/// <summary>
	///  preserves handedness
	///  
	/// Any proper rigid transformation can be decomposed into a rotation followed by a translation,
	/// while any improper rigid transformation can be decomposed into
	///		an improper flip followed by a translation
	///		,
	///		or into a sequence of reflections.
	/// 
	/// </summary>
	public interface IHandnessKept
	{
	}
}
