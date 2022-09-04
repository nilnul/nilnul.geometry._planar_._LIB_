using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace nilnul.num.real.expr.co_.equiv_.trigno_
{
	public class _OfAdd0minusX
	{
		/// <summary>
		/// sin(a+b) = sin(a)cos(b) + cos(a) sin(b)
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		
		static public System.Linq.Expressions.Expression SinOfAdd(double a, double b) {
			return (
				(Expression<Func<double,double,bool >>) (
					(double a, double b)
					=>
					Sin(a+b) ==
					Sin(a) * Cos(b) + Cos(a) * Sin(b)
				)
			).Body;
		}

		static public System.Linq.Expressions.Expression SinOfMinus(double a, double b) {
			return (
				(Expression<Func<double,double,bool >>) (
					(double a, double b)
					=>
					Sin(a-b) ==
					Sin(a) * Cos(b) - Cos(a) * Sin(b)
				)
			).Body;
		}

		static public System.Linq.Expressions.Expression CosOfAdd(double a, double b) {
			return (
				(Expression<Func<double,double,bool >>) (
					(double a, double b)
					=>
					Cos(a+b) == Cos(a) * Cos(b) -Sin(a) * Sin(b)
				)
			).Body;
		}

		static public System.Linq.Expressions.Expression CosOfMinus(double a, double b) {
			return (
				(Expression<Func<double,double,bool >>) (
					(double a, double b)
					=>
					Cos(a-b) == Cos(a) * Cos(b)+Sin(a) * Sin(b)
				)
			).Body;
		}


	}
}
