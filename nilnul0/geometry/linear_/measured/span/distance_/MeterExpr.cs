using nilnul.geometry.linear_._measured.unit_;
using nilnul.geometry.linear_._measured.unit_.eng_;
using nilnul.geometry.linear_.measured.span.distance_.eng_;

namespace nilnul.geometry.linear_.measured.span.distance_
{
	public class Meters4dbl
		:
		Distance4dbl
	{
		public Meters4dbl(double m):base(m)
		{
		}
		public FootsInches toFootInchFloat() {
			return new FootsInches(((int)(this.amount.realee / Foot.MsPerFoot)),(this.amount.realee % Foot.MsPerFoot)/Inch.Inch2MeterAsDouble);
		}

		
	}
}
