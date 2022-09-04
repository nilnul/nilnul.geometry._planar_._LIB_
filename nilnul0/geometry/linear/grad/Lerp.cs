using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.grad
{
	static public class _LerpX
	{
		static public double _Lerp_ratioAssumeProb(double start, double end, double _prob) {
			return start + (end - start) * _prob;
		}
	}
}
