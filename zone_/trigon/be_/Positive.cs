using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.be_
{
	/// <summary>
	/// allowing negative trigon such that in some cases like <see cref="nameof(planar.zone_.polygon_.tetra_.simple_.convex_.trape_.Perpend)"/>, it is convenient 
	/// </summary>
	public class Positive : nilnul.geometry.planar.zone_.trigon.BeDoubleI
	{
		public bool be(TriangleDbl obj)
		{
			return geometry.planar.lead.vsPoint_.nonincident.be_._LeewayX.LeewayTrue(
				obj.ee.a
				,
				obj.ee.b
				,
				obj.ee.c
			);
			///throw new NotImplementedException();
		}

		static public Positive Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positive>.Instance;
			}
		}

	}
}
