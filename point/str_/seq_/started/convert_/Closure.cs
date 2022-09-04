using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.geometry.planar.Point4dbl;


namespace nilnul.geometry.planar.point.str_.seq_.started.convert_
{
	/// <summary>
	/// 
	/// </summary>
	public class Closure
	{
		static public IEnumerable<P> Eval(IEnumerable<P> _dwelled) {
			return _dwelled.Concat(new[] { _dwelled.Last()});
		}
	}
}
