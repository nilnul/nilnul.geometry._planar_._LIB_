//using System.Drawying;

namespace nilnul.geometry.linear
{
	static public class Tend4dblX
	{
		static public (PointDblI, PointDblI) Order(this Tend4dbl span) {
			return span.component.ToClass() <= span.component1 ? (span.component, span.component1) : (span.component1,span.component);
		}
	}
}
