using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_
{
	/// <summary>
	/// stretch; no shear
	/// </summary>
	public class Scale
	{
		static public double[,] CreateMatrix(double scaleX, double scaleY) {
			return new double[,] {
				{ scaleX, 0 }, { 0, scaleY }
			};
		}
	}
}
