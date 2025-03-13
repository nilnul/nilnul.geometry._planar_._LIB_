using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._troll.locus_
{
	/// <summary>
	/// the domain is <see cref="nilnul.num.real.IBorel"/>, which can be empty, or countable union of disjoint intervals (<see cref="nilnul.num.real.borel_.contig_.IDwelt"/>).
	/// in other words, only countable xpn or breaks are allowed.
	/// </summary>
	/// <remarks>
	/// this is powerful to express:
	///		empty
	///		contiguous curve
	///		broken curve like <see cref="planar.curve.co_.eg_.IHyperbola"/>
	///	excluding:
	///		curve stream like <see cref="planar.curve.stream_.Fractal"/>
	///			,as the previous locus is removed here, which is not in lign with the locus which means the trail.
	///		
	/// </remarks>
	/// 
    class IBorel
    {
    }
}
