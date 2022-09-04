using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_.rebase_.scale_
{
	public interface ISqueeze : IHandednessKept { }
	/// <summary>
	/// 	
	/// preserve the area. 
	/// </summary>

	static public class _Squeezex
	{
		static public Matrix Matrix_assumePositive(float x) {
			var r = new Matrix();
			r.Scale(
				x,
				1/x

				);
			return r;
		}
	}
}
