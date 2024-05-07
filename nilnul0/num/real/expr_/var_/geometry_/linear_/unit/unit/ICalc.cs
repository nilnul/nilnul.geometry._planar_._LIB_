using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit
{
	/// <summary>
	/// multi, and dividing of units;
	/// eg:
	///		cm/mm
	///		cm^2
	///		m * cm /mm = m * 10 = 100 dm
	/// </summary>
	/// <remarks>
	/// this can be used to convert between measures in different units;
	/// eg:
	///		100cm * ( 10mm/cm ), where 10mm/cm is one and can be multiplied to the effect of noop;
	/// </remarks>
	internal class ICalc
	{
	}
}
