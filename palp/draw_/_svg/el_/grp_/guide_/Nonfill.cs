using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.geometry.planar.drawable.draw_._svg.el_.grp_.guide_
{
	public class Nonfill
	{

		public XElement el()
		{
			return new XElement(
				"g"
				,
				_el.attrs_.guide_.Nonfill.Singleton.attrs()
			);

		}


		static public Nonfill Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nonfill>.Instance;
			}
		}

	}
}
