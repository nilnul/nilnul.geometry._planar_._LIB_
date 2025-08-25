using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._sub.locus.que.sigma_
{
	/// <summary>
	/// given a function real -> complex:
	///		x => s(x)
	///	,which is periodic with period: p,
	///	, then the que is:
	///		c[i] E( i * tau  * t / p   )
	///	,where c[i] = 1/p * integrate of: 0, p, s(x) * e^(-i * tau * i * x / p) dx
	///	,	E is <see cref="complex.of_.polar_._CisX"/>;
	///	;
	///	 note for c[i], the E() part has negative exponent, meaning a divisor, reflecting our intention to make the c[i] convergent by dividing sth, even though the dividing involving no radial and in fact just an opposite rotation, offering no help for convergence;
	/// </summary>
	/// 
	/// <remarks>
	/// this transforms amplitude function to frequency function.
	///The series does not necessarily converge (in the pointwise sense) and, even if it does, it is not necessarily equal to s(x). Only when certain conditions are satisfied (e.g. if s(x) is continuously differentiable) does the Fourier series converge to s(x);
	/// </remarks>
	/// alias:
	///		fourier series, but this series is a que, not a stream, even though we can convert the que into a stream; or it can be transformed as stream just as a <see cref="nilnul.ral_.ord_.infinite_.undense_.IUnFounded"/> usually does;
	///		discrete, like integers: while it's not stream, but discrete
	///		
	/// vs:
	///		<see cref="complex.str.convert_._DiscreteFourierTransformX"/>
	class IFourier
    {
    }
}
