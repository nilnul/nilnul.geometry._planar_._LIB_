using System.Numerics;

namespace nilnul.geometry.planar.curl_.elbow_.pro.vsPoint.be_._subtend_.by_
{
	static public class _ByCrossProductX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="elbowPro">
		/// distinct, prowind
		/// </param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public bool _Has_0elbowPro(
			(Complex a, Complex b, Complex c) elbowPro
			,
			Complex x
		)
		{
			return geometry.planar.lead.vsPoint.be_._ProWindX._Be_0skid(
				(elbowPro.a, elbowPro.b), x
			)
			&&
			geometry.planar.lead.vsPoint.be_._ProWindX._Be_0skid(
				(elbowPro.b, elbowPro.c), x
			)
			&&
			geometry.planar.lead.vsPoint.be_._NonconWindX._Be_0skid(
				(elbowPro.c, elbowPro.a), x
			);
		}
	}
}
