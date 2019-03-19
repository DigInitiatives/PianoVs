///Author: Austin Bentley
///Stores note values for songs
///Last Modified By: Austin Bentley
///Last Modified Date: 7-Mar-2019
///Dependencies: N/A
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClass
{
	public int key;
	public int start;
	public int end;
	public int hand;

	public NoteClass(int Key, int Start, int End, int Hand)
	{
		key = Key;
		start = Start;
		end = End;
		hand = Hand;
	}

	public int GetKey()
	{
		return key;
	}
	public void SetKey(int changeKey)
	{
		key = changeKey;
	}
	public int GetStart()
	{
		return start;
	}
	public void SetStart(int changeStart)
	{
		start = changeStart;
	}
	public int GetEnd()
	{
		return end;
	}
	public void SetEnd(int changeEnd)
	{
		end = changeEnd;
	}
	public int GetHand()
	{
		return hand;
	}
	public void SetHand(int changeHand)
	{
		hand = changeHand;
	}
}
