using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar
{
	/// <summary>
	///  2d or 1d objects; excluding 0d points;
	/// eg:
	///		two zones connected by a line
	/// </summary>
	/// alias:
	///		tract
	/// region
	/// zone
	/// locale
	/// district
	/// milieu
	/// tract
	/// spot
	/// connected
	///		track
	///		trek
	///		trak
	///		trac
	///		
	///
	/// <see cref="linear.ILapse"/>
	//[Obsolete(nameof(IConnected))]
	///
	[Obsolete()]
	public interface ITrack
		:
		INonPointal
		//traject.IUnDirected
		//,
		//curve.IUnDirected
		//,
		//crux_.INonsingular, crux_.IPathable
	{
	}
}
