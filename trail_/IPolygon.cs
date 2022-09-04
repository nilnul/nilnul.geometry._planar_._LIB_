using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trail_
{
	//[Obsolete(nameof(loop_.IPolygon))]

	[Obsolete(nameof(cloze_.IPolygon))]
	public interface IPolygon :
		ITrail,
		sub_.directed_.connected_.IPolygon //but with at least one point
	{
	}
}
