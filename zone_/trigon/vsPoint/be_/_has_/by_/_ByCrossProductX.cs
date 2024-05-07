using System.Numerics;

namespace nilnul.geometry.planar.zone_.trigon.vsPoint.be_._has_.by_
{
	static public class _ByCrossProductX
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
