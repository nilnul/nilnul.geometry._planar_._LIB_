using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.roulette_
{
	/// <summary>
	/// <see cref="nilnul.num.complex.str.convert_._DiscreteFourierTransformX"/>
	///	rE(a) + r1 E(t a1) + r2 E(t a2) + ...	# finite terms.
	/// where 
	/// ,E is the <see cref="nilnul.num.complex.of_.polar_._CisX"/>
	///		,r[i] is the radial, a real number, often sorted in descending order, representing the amplitude from high to low.
	/// , a[i] is the rotor speed, often sorted in ascending order, representing the frequency from low to high.
	/// , t is the time.
	/// </summary>
	/// <remarks>
	/// <see cref="nilnul.num.complex.stream_.pow.series.Radius4convergence"/> for denumerable terms.
	/// </remarks>
	public interface IFourier

		: curve_.IRoulette
		///nilnul.num.complex.str.convert_._DiscreteFourierTransformX
    {
    }



}
