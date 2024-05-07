using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_
{
	/// <summary>
	/// <seealso cref="geometry.planar.IVector"/>
	/// </summary>
	/// 
	public class OriginatedDbl :Step4dbl 
	{
		

		public OriginatedDbl( Point4dbl end) : base(new Point4dbl(), end)
		{
		}
	}
}
