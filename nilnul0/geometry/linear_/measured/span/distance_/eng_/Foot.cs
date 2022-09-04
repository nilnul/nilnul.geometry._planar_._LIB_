using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.physics.length
{
	[Obsolete()]
	public class Foot:UnitI
	{
		public const double MsPerFoot=.3048;

		public const double Foot_Per_Meter=1/MsPerFoot;

		public static double FeetFroMeters(double meters) {

			return meters * Foot_Per_Meter;
		
		}

		public static double MetersFroFeet(double feet)
		{

			return feet * MsPerFoot;

		}

	}
}
