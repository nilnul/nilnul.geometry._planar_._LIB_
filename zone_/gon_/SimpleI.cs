using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.sub_.polygon.be_.simple;

namespace nilnul.geometry.planar.zone_.polygon_
{

	/// <summary>
	/// no cross of edges. the points can be incidental, as we can remove them safely (but we cannot defuse the crossing of edges).
	/// </summary>
	public interface ISimple { }
	//public interface SimpleI:ISimple
		
	//{
	//	nilnul.geometry.planar.sub_.polygon.be_.simple.En polygon { get; }
	//}

	//public class Simple :
	//	nilnul.geometry.planar.zone_.polygon.be_.simple.En
	//	,

	//	SimpleI
	//{
	//	public Simple(PolygonI val) : base(val)
	//	{
	//	}

	//	public En polygon => this;
	//}
}
