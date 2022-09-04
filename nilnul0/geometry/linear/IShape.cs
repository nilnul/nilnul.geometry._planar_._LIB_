using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{

	/// <summary>
	/// how would we generate lienar object from:
	///		0d point?
	///	we can:
	///		cloze by two points. <see cref="linear.ISpan"/>
	///		involve time.Interval, moving a point continuously. <see cref="linear.IGrad"/>,<see cref="linear.IRay"/>, <see cref="linear.ILine"/>
	///		
	/// </summary>
	/// this is not ordered
	/// <seealso cref="linear.ITope"/>
	///
	[Obsolete(nameof(ITope))]
	public interface IShape
		:drawable_.IConnected
	{
	}
}
