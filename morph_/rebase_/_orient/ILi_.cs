using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_._orient
{
	/// <summary>
	/// new x can have 4 choices. then y would hence have 2 choices. Total we have 8.
	/// </summary>
	internal enum Li_
	{

		Xy
			,
		/// <summary>
		/// <see cref="orient_.rotate_.IQuarter"/>
		/// </summary>
		Y_NegX
			,
		NegX_NegY
			,
		NegY_X
			,
		/// <summary>
		/// flipped
		/// </summary>
		Yx
			,
		NegX_Y
			,
		/// <summary>
		/// <see cref="orient_.flip_.INegBisect"/>
		/// </summary>
		NegY_NegX
			,
		X_NegY

	}
}
