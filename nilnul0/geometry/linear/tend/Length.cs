using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.span
{
	/// <summary>
	/// the distance without unit
	/// </summary>
	public interface ILength
	{
	}

	/// <summary>
	/// the distance with unit
	/// </summary>
	public interface IDistance:nilnul.obj.IMeasure { }
}
