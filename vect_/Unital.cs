using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.vect.be_.unital.vow;
using nilnul.num;

namespace nilnul.geometry.planar.vect_
{
	public interface IUnital
		:VectorI

	{
		vect.be_.unital.vow.Ee vectoree { get; }
	}
	public class Unital : vect.be_.unital.vow.Ee
		,
		IUnital
	{
		public Unital(IVector val) : base(val)
		{
		}


		public Real x => this.boxed.point.x;

		public Real y => this.boxed.point.y;

		public Ee vectoree => this;
	}
}
