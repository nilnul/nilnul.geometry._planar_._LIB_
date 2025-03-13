using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad
{
	static public class _LerpX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="_prob">can exceed [0,1]</param>
		/// <returns></returns>
		static public Point4dbl Lerp(planar.Point4dbl start, planar.Point4dblI end, double _prob) {
			return start + (end - start) * _prob;
		}
		static public Point4dbl Lerp(planar.Point4dblI start, planar.Point4dblI end, double _prob) {
			return Lerp(start.ToImpl(),end,_prob);
		}


		static public Point4dbl Lerp_byComple(planar.Point4dbl start, planar.Point4dbl end, double _prob) {
			var comple = 1 - _prob;
			return start*comple + end * _prob;
		}
		static public Point4dbl Lerp_byComple(planar.Point4dbl start, planar.Point4dblI end, double _prob) {
			
			return Lerp_byComple(start,end,_prob);
		}


		static public Point4dbl Lerp_byComple(planar.Point4dblI start, planar.Point4dblI end, double _prob) {
			return Lerp_byComple(start.ToImpl(),end,_prob);
		}



	}
}
