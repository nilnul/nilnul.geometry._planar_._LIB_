using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.drawable.draw_._svg.style_
{
	/// <summary>
	/// 
	/// </summary>
	public class StaticSetting
	{
		private string _fontSize;

		/// <summary>
		/// svg default is 16
		/// </summary>
		public string fontSize
		{
			get { return _fontSize ; }
			set { _fontSize = value; }
		}



		static public StaticSetting Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<StaticSetting>.Instance;
			}
		}


	}
}
