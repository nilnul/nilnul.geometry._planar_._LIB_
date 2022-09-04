using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.rebase_.scale_.uniform_.neg_
{
	/// <summary>
	/// neg one
	/// </summary>
	public class ReflectAboutOrigin:INeg
	{
		static public double[,] Matrix = new double[,] {
				{ -1,0}
			,
				{ 0,-1}
		};
	}
}
