using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_
{
	/// <summary>
	/// 
	/// </summary>
	public  class Line
		: BeI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		/// <remarks>
		///		don't use heronFormula for it involves irrationals if the three points are all quotients.
		///		If the three points are quotient, kee this within quotient.
		/// </remarks>
		public bool be(Trio obj)
		{
			return !Triangular.Singleton.be(obj);

			//throw new NotImplementedException();
		}


		static public Line Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Line>.Instance;
			}
		}

	}
}
