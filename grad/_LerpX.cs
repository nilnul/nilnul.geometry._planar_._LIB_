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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="_prob">can exceed [0,1]</param>
		/// <returns></returns>
		static public double Lerp(double start, double end, double _prob) {
			return start + (end - start) * _prob;
		}


		static public double Lerp_byComple(double start, double end, double _prob) {
			var comple = 1 - _prob;
			return start * comple + end  * _prob;
		}


	}
}
