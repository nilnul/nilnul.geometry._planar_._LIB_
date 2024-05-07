using System.Collections.Generic;
using System.Numerics;

namespace nilnul.geometry.planar.grad.shade_.uxp_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _OnAuxillaryX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="start"></param>
		/// <param name="stop"></param>
		/// <returns>
		/// <see cref="IShade"/>
		/// </returns>
		static public IEnumerable<Complex> Trapezoid(Complex start, Complex stop) {
			yield return start;
			yield return stop;
			yield return new Complex(stop.Imaginary, 0);
			yield return new Complex(start.Imaginary,0);

		}
	}
}
