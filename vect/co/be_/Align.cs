using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.co.be_
{

	/// <summary>
	/// in line
	/// </summary>
	static public class _AlignX
	{
		static public bool Align(VectorI a, VectorI b) {
			return nilnul.num.real.be_.Nil.Singleton.be(
				vect.co._CrossProductX.AreaOfParallelogram(a, b)
			);
		}
		static public bool Align(IVector a, IVector b) {
			return nilnul.num.real.be_.Nil.Singleton.be(
				vect.co._CrossProductX.AreaOfParallelogram(a, b)
			);
		}

		static public bool Align(Vector1 a, Vector1 b) {
			return Align(a,b);
		}


		static public bool Align(PointI1 point1, PointI1 point2)
		{
			return Align(
				new Vector1(point1)
				,
				new Vector1(point2)
				
			);
			
		}
	}
	/// <summary>
	/// one vector is zero; or
	/// the two vectors is on the same line (may in opposite direction)
	/// </summary>
	public class Align : BeI
	{
		public bool be(Co obj)
		{
			return _AlignX.Align(obj.component, obj.component1);
			throw new NotImplementedException();
		}

		public bool be(PointI1 point1, PointI1 point2)
		{
			return _AlignX.Align(point1, point2);
		}

		static public Align Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Align>.Instance;
			}
		}

	}
}
