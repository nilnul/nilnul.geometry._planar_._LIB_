using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.holed_.gon
{
	public interface ITo<T> :
		nilnul.obj.ITo<facet_.donut_.IGon,T>
		{ }
	public interface ToI<T>
		:
		nilnul.obj.ToI< facet_.donut_.Polygon4dbl, T>
	{
	}
}
