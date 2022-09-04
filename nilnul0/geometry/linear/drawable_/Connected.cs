using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.drawable_
{
	/// <summary>
	/// path connected.
	/// grad, ray, or line
	/// </summary>
	/// <see cref="geometry.planar.spread_.IRoadable"/>: band connected; banded/taped
	/// also 3d tunnel-connected
	///
	[Obsolete(nameof(linear.ITope))]
	public interface IConnected : IDrawable
	{
	}
}
