using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._area
{
	public interface UnitI:_unit_.AsSqMetersI1
		,
		nilnul.obj._measure.UnitI
	{

	}
	/// <summary>
	/// square meterS
	/// </summary>
	public class Unit:
		nilnul.obj._measure.Unit

		,
		UnitI

	{

	}
}
