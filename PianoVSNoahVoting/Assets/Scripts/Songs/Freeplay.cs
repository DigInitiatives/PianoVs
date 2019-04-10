using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Created By Noah Rittenhouse
 * Last Edited on : April 4 2019
 * This script is just a name so the menu can display that you are in freeplay mode
**/
public class Freeplay : Songholder
{
    public Freeplay()
    {
        SetMaxBeat(-1);
        SetDifficulty(0);
        SetSongName("Freeplay");
    }
}
