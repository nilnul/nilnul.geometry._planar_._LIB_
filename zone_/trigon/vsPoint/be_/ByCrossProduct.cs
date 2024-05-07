using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.vsPoint.be_
{

	static public class _HasX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="trigon">
		/// distinct, prowind
		/// </param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public bool _Has_0trigon(
			(Complex a, Complex b, Complex c) trigon
			,
			Complex x
		)
		{
			return geometry.planar.lead.vsPoint.be_._NonconWindX._Be_0skid((trigon.a, trigon.b), x)
				&&
geometry.planar.lead.vsPoint.be_._NonconWindX._Be_0skid((trigon.b, trigon.c), x) &&
geometry.planar.lead.vsPoint.be_._NonconWindX._Be_0skid((trigon.c, trigon.a), x);
		}
	}

	
}
