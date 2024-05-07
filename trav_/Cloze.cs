using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trav_
{
	/// <summary>
	/// end at start. <see cref="planar.ICloze"/>
	/// </summary>
	/// vs <see cref="IClosed"/>, which closes at begin and end, but might be not <see cref="IEndAtStart"/>
	public interface IEndAtStart :
		ITrace
	{
	}
}
