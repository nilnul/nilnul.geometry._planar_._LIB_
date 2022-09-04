using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.original
{
	public interface IVec { }
	/// <summary>
	/// 
	/// </summary>
	public interface VecI:IVec
	{
		 original.IPoint point { get; set; }

	}
}
