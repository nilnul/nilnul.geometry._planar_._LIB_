using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_
{
	/// <summary>
	/// connecting a few pieces of curve.
	/// </summary>
	/// Pieces
	///		piecewise without "wi" and "e"
	public interface IPiecewise
		:ICycle, curve_.IPiecewise
	{
	}
}
