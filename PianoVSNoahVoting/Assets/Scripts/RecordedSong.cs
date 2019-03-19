///Author: Austin Bentley
///Stores recored song
///Last Modified By: Austin Bentley
///Last Modified Date: 7-Mar-2019
///Dependencies: Song recording MUST be done
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordedSong : Songholder
{
	public RecordedSong()
	{
		SetBPM(120);
		SetTimeSignature(4);
		SetMaxBeat(192);
		int barTime = timeSignature * 16;
	}
}
