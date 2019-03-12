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
