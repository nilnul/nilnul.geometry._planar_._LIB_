using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable.draw_._svg.el_.grp_
{
	public class ForGuides
	{
		/// <summary>
		/// fill for text
		/// </summary>
		/// <returns></returns>
		public XElement el()
		{
			return new XElement(
				"g"
				,
				_el.attrs_.ForGuides.Singleton.attrs()
			);

		}


		static public ForGuides Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ForGuides>.Instance;
			}
		}

	}
}
