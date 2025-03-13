using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co.be_
{
	public class NonConwind
		:
		vect_.nonnil.co.Be4dblI
	{
		public bool be(Co4dbl obj)
		{
			return   co.CrossProduct.Singleton.to(obj) >=0;
		}

		public bool be(Complex c0, Complex c1)
		{
			return   co.CrossProduct.Singleton.to(c0,c1) >=0;

		}

		static public NonConwind Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NonConwind>.Instance;
			}
		}

	}
}
