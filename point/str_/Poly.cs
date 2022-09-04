using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.point.str_.seq.be_.poly;
using nilnul.geometry.planar.point.str_.seq.be_.poly.vow;

namespace nilnul.geometry.planar.point.str_.seq_
{
	public interface PolyI {
		point.str_.seq.be_.poly.vow.Ee points { get; }
	}
	public class Poly
		: point.str_.seq.be_.poly.vow.Ee
		,
		PolyI
	{
		public Poly(SeqI val) : base(val)
		{
		}

		public Ee points => this;
	}
}
