using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.trans_
{
	/// <summary>
	/// coord * 1*1 matrix.
	/// </summary>
	public interface IMatrixed:
		map_.ITrans
		,
		map_.IMatrixed
	{
	}
}
