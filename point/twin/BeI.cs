using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.twin
{
	public interface BeI
		:
		nilnul.obj.BeI1<Twin>
	{
	}

	public interface IBeD
		:
		nilnul.obj.BeI1<TwinD>

	{ }

	public abstract class BeOnReDA
		:
		nilnul.obj.twin.BeOnReA<planar.Point4dblI, point.TwinD>
		,
		IBeD
	{
		
	}
}
