using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	/// eg:
	///		two zones connected by a line
	/// </summary>
	/// region
	/// zone
	/// locale
	/// district
	/// milieu
	/// tract
	/// spot
	/// connected
	///		track
	///
	//[Obsolete(nameof(IConnected))]
	public interface ITrack : crux_.INonsingular, crux_.IPathable
	{
	}
}
