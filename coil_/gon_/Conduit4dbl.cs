using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.coil_.gon_
{
	/// <summary>
	/// might be two coil each of which doesnot enclose the other, but there is a conduit as a bridge between the two peer island.
	/// So it might be not a facet.
	/// </summary>
	/// <remarks>
	/// or a <see cref="facet_.gon_.IConduit"/>, where it's a facet, so it
	///		:allows for one level, not for recursively embedding.
	///		:And also, it means a restrained area, so the outer must be inner winded.
	///		:we can have one hull, as two hulls need a conduct, which is a 1d curve that facet disallows.
	///		
	///	Here this allows:
	///		:multiple hull
	///		:hull can be negative winded, <see cref="cloze.IStokes"/>, <see cref="cycle.inner.IWrap"/>
	///		:recursive
	/// </remarks>
	///
	public interface IConduit:IGon { }
	public class Conduit4dbl
		:
		gon.be_.conduit.vow.Ee4dbl
	{
		public Conduit4dbl(Gon4dblI val) : base(val)
		{
		}

		public Conduit4dbl(IEnumerable<Point4dblI> vertexes)
			:
			this(new coil_.Gon4dbl(vertexes))
		{
		}
	}
}
