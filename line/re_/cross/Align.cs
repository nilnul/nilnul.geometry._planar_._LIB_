using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real;

namespace nilnul.geometry.planar.line.re_.cross
{
	/// <summary>
	/// parallel or incident; not crossed, intersected
	/// </summary>
	public class Anto :
		nilnul.obj.re.Complement<planar.LineI,Inter>
		,
		ReI
	{


		static public Anto Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}

	}
}
