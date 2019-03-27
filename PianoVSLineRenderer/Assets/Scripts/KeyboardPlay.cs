///Author: Josh Sadoway
///This is a debug script, allowing for use of the computer keyboard
///Last Modified By: Josh Sadoway
///Last Modified Date: 7-Mar-2019
///Dependencies: Using the Individual Key Script(Adam), the user can use the keyboard instead of touch controls.
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPlay : MonoBehaviour
{
	// List of keys
	public List<GameObject> pianoKeys = new List<GameObject>();

	void Update()
	{
		// Press Down

		// FIRST ROW
		if (Input.GetKeyDown(KeyCode.Q)) 
		{
			pianoKeys[0].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			pianoKeys[1].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			pianoKeys[2].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			pianoKeys[3].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			pianoKeys[4].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			pianoKeys[5].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			pianoKeys[6].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			pianoKeys[7].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.T))
		{
			pianoKeys[8].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha6))
		{
			pianoKeys[9].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Y))
		{
			pianoKeys[10].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			pianoKeys[11].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.U))
		{
			pianoKeys[12].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha8))
		{
			pianoKeys[13].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.I))
		{
			pianoKeys[14].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha9))
		{
			pianoKeys[15].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.O))
		{
			pianoKeys[16].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Alpha0))
		{
			pianoKeys[17].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			pianoKeys[18].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Minus))
		{
			pianoKeys[19].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.LeftBracket))
		{
			pianoKeys[20].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Equals))
		{
			pianoKeys[21].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.RightBracket))
		{
			pianoKeys[22].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Backspace))
		{
			pianoKeys[23].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Backslash))
		{
			pianoKeys[24].GetComponent<IndividualKeyScript>().PlayNote(false);
		}

		// SECOND ROW
		if (Input.GetKeyDown(KeyCode.Z))
		{
			pianoKeys[25].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			pianoKeys[26].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.X))
		{
			pianoKeys[27].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			pianoKeys[28].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			pianoKeys[29].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.F))
		{
			pianoKeys[30].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.V))
		{
			pianoKeys[31].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			pianoKeys[32].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			pianoKeys[33].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.H))
		{
			pianoKeys[34].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.N))
		{
			pianoKeys[35].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			pianoKeys[36].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			pianoKeys[37].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.K))
		{
			pianoKeys[38].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Comma))
		{
			pianoKeys[39].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.L))
		{
			pianoKeys[40].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Period))
		{
			pianoKeys[41].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Semicolon))
		{
			pianoKeys[42].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Slash))
		{
			pianoKeys[43].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Quote))
		{
			pianoKeys[44].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.RightShift))
		{
			pianoKeys[45].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			pianoKeys[46].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Keypad1))
		{
			pianoKeys[47].GetComponent<IndividualKeyScript>().PlayNote(false);
		}
		if (Input.GetKeyDown(KeyCode.Keypad4))
		{
			pianoKeys[48].GetComponent<IndividualKeyScript>().PlayNote(false);
		}

		// Key Release

		// FIRST ROW
		if (Input.GetKeyUp(KeyCode.Q))
		{
			pianoKeys[0].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha2))
		{
			pianoKeys[1].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.W))
		{
			pianoKeys[2].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha3))
		{
			pianoKeys[3].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.E))
		{
			pianoKeys[4].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha4))
		{
			pianoKeys[5].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.R))
		{
			pianoKeys[6].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha5))
		{
			pianoKeys[7].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.T))
		{
			pianoKeys[8].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha6))
		{
			pianoKeys[9].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Y))
		{
			pianoKeys[10].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha7))
		{
			pianoKeys[11].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.U))
		{
			pianoKeys[12].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha8))
		{
			pianoKeys[13].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.I))
		{
			pianoKeys[14].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha9))
		{
			pianoKeys[15].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.O))
		{
			pianoKeys[16].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Alpha0))
		{
			pianoKeys[17].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.P))
		{
			pianoKeys[18].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Minus))
		{
			pianoKeys[19].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.LeftBracket))
		{
			pianoKeys[20].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Equals))
		{
			pianoKeys[21].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.RightBracket))
		{
			pianoKeys[22].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Backspace))
		{
			pianoKeys[23].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Backslash))
		{
			pianoKeys[24].GetComponent<IndividualKeyScript>().StopNote();
		}

		// SECOND ROW
		if (Input.GetKeyUp(KeyCode.Z))
		{
			pianoKeys[25].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.S))
		{
			pianoKeys[26].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.X))
		{
			pianoKeys[27].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.D))
		{
			pianoKeys[28].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.C))
		{
			pianoKeys[29].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.F))
		{
			pianoKeys[30].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.V))
		{
			pianoKeys[31].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.G))
		{
			pianoKeys[32].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.B))
		{
			pianoKeys[33].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.H))
		{
			pianoKeys[34].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.N))
		{
			pianoKeys[35].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.J))
		{
			pianoKeys[36].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.M))
		{
			pianoKeys[37].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.K))
		{
			pianoKeys[38].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Comma))
		{
			pianoKeys[39].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.L))
		{
			pianoKeys[40].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Period))
		{
			pianoKeys[41].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Semicolon))
		{
			pianoKeys[42].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Slash))
		{
			pianoKeys[43].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Quote))
		{
			pianoKeys[44].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.RightShift))
		{
			pianoKeys[45].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Return))
		{
			pianoKeys[46].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Keypad1))
		{
			pianoKeys[47].GetComponent<IndividualKeyScript>().StopNote();
		}
		if (Input.GetKeyUp(KeyCode.Keypad4))
		{
			pianoKeys[48].GetComponent<IndividualKeyScript>().StopNote();
		}
	}
}