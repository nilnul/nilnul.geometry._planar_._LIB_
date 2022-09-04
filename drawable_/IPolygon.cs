using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable_
{
	[Obsolete(nameof(planar.crux_.IPolygon))]
	public interface IPolygon
		:IDrawable
		,
		sub_.IPolygon
	{
	}
}
