using nilnul.geometry.planar.grad_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// line with direction.
	/// when drawing a lead, draw the arrowHead in the middle, not at the end, such as to differ from arrow; as drawn below:
	///			---------------->----------------------------
	/// </summary>
	public interface LeadI
	{
		grad_.IArrow arrow { get; }
	}

	public class Lead
		:
		nilnul.obj.Box<grad_.IArrow>
		,
		LeadI
	{
		public Lead(IArrow val) : base(val)
		{
		}

		public Lead(PointI1 a, PointI1 b):this( new grad_.Arrow(a,b))
		{
		}

		public IArrow arrow => boxed;
	}


}
