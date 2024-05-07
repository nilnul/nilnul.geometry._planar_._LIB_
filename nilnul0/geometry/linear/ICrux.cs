using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear
{
	/// <summary>
	/// </summary>
	/// vs:
	///		continuous, whileas this is connected. there might be back and forth movement, passing a point multiple times.
	public interface ICrux
		:
		linear.drawable_.IConnected

	{
	}
}
