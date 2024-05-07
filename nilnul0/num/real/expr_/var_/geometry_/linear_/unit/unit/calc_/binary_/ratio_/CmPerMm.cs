using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_._measured.unit.calc_.binary_.ratio_
{

	internal class CmPerMm
	{

		static public double Mms2cms(double inMms) {
			/// eg:
			/// 19mm * cm/mm / (1cm/1mm )
			return inMms / Ratio4dbl.OfCmMm.toRatio();
		}
	}
}
