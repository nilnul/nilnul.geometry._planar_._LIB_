using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_
{
	/// <summary>
	/// stretch; no shear
	/// </summary>
	public class Scale
		:
		morph_.IScale
		//morph_.rebase_.axial_.

	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] CreateMatrix(double scaleX, double scaleY) {
			return new double[,] {
				{ scaleX, 0 }, { 0, scaleY }
			};
		}


	}


}
