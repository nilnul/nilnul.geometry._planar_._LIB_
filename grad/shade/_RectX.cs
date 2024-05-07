using System.Collections.Generic;
using System.Numerics;

namespace nilnul.geometry.planar.grad.shade
{
	/// <summary>
	/// augement the grad into a rectangular.
	/// </summary>
	static public class _RectX
	{
		static public IEnumerable<Complex> Rect(Complex start, Complex stop) {
			yield return new Complex(stop.Real, 0);
			yield return new Complex(start.Real, 0);

			var auxAdd = start.Imaginary + stop.Imaginary;

			yield return new Complex(start.Real,auxAdd );

			yield return new Complex(stop.Real, auxAdd);

		}
	}
}
