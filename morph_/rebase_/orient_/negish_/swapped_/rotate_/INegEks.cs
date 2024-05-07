using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_.orient_.negish_.swapped_
{
	/// <summary>
	/// 0,-1
	/// 1,0
	/// </summary>
	/// <remarks>
	/// the coordinate sys becomes:
	///		old x is the new neg y;
	///		old y is new x.
	///	in other words:
	///		y axis is at the negative ray of old x;
	///		x axis is at the positive half of old y.
	///, so it rotates the sys by 90deg;
	///
	/// </remarks>
	internal class INegEks:INegOne
	{
	}


}
