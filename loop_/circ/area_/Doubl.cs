using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.Real;
using nilnul.num.real;



namespace nilnul.geometry.planar.crux_.disk.area_
{
	static public class _DoublX
	{
		

		static public double Area(double d) {
			return Math.PI* d*d;
		}
		static public double OfDiameter(double d) {
			return Area(d / 2);
		}


	}
}
