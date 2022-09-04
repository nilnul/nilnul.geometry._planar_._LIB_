using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.conic_
{
	/// <summary>
	/// note: we need curve to be contiguous. So here is only half of the common hyperbola.
	/// For complete hyperbola, see <see cref="conic_.hyperbola.ICo"/> or <see cref="nilnul.geometry.planar.curves_.Hyperbola"/>
	///  eg:
	///		half of xy=1
	/// </summary>
	public interface IHyperbola:
		algebraic_.IConic
	{
	}
}
