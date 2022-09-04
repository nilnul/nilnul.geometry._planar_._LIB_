using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.crux_
{

	[Obsolete(loop_.IPolygon)]

	//[Obsolete(nameof(trail_.IPolygon))]
	public interface IPolygon :
		sub_.IPolygon
		,
		ICrux
	{
	}
}
