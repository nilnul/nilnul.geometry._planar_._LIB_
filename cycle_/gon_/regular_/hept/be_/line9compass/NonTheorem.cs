using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.regular_.hept.be_.line9compass
{
	/// <summary>
	/// the regular heptagon is the regular polygon with the least number of sides that is impossible to construct with compass and straightedge alone
	/// </summary>
	/// 
	internal class NonTheorem
	{
		/// each inner angle is tau/7; and half of inner angle is pi/7;
		/// cos(pi/7) is one root of  x^3 + x^2 -2x -1;
		/// so if we could can draw out such angle, then line9compass can solve the cubic root;
		/// but in fact line9compass can only represent:
		///		add
		///		,
		///		minus
		///		,
		///		multi
		///		,
		///		division
		///		,
		///		sqrt
		///	Hence, by contradiction, we know that such polygon cannot be drawn in line9compass only;

	}
}
