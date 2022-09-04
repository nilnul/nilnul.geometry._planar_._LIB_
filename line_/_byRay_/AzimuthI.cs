using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.line_._hinged_
{
	public interface AlignmentUnnormalI
	{
		/// <summary>
		/// any number. can be normalized into <see cref="rotation_.Orientation"/>
		/// </summary>
		double alignmentUnnormal {
			get;
		}
	}
}
