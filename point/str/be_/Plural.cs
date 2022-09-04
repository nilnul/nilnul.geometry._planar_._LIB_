using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.str.be_
{
	/// <summary>
	/// >=2.
	/// 
	/// </summary>
	public class Plural : Be4dblI
	{ 
		public bool be(str_.SeqI obj)
		{
			return obj.Count() >= 2;
			//throw new NotImplementedException();
		}

		public bool be(IEnumerable<Point4dblI> obj)
		{
			return  obj.Count() >= 2;
		}


		static public Plural Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Plural>.Instance;
			}
		}


	}
}
