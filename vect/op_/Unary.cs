using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.op_
{
	public interface Unary4dblI
		:
		nilnul.obj.op_.UnaryI<
			geometry.planar.Vector4dblI
		>
		,
		vect.Op4dblI
	{
	}

	public interface Unary4dblI1
		:
		nilnul.obj.op_.UnaryI<
			geometry.planar.Vect4dblI
		>
		,
		vect.Op4dblI
	{
	}

	/// <summary>
	/// onClass is abstract. on interface is implemented.
	/// </summary>
	public abstract class Unary4dblA
		: Unary4dblI
		,
		_unary_.OnClassI
	{
		public Vector4dblI op(Vector4dblI par)
		{
			return op(
				VectorDbl.OfInterface(par)
			);
			//throw new NotImplementedException();
		}

		public abstract VectorDbl op(VectorDbl par);
	}
}
