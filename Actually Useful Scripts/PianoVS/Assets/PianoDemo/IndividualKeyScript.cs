using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualKeyScript : MonoBehaviour
{

    /*
    * Summary:
    * This script is attatched to a "Key" which only has a public method that plays the sound clip of the attatched audio source
    * Date: 31/01/2019
    * Author: Adam Warkentin
    * Dependencies: Requires an audio source component. If the key is a white key, check the "whiteKey" bool in the editor
    */

    //keymodel is the visual component of this obj
    GameObject keyModel;

    //keyModelRenderer is just the rendered component of keyModel
    Renderer keyModelRenderer;

    //These are the materials for how the key should look when up and down
    Material keyUp;
    Material keyDown;

    //Variable that is set in the editor to determine if the key which this script is attatched to is a whitekey or a black key
    public bool whiteKey;

    void Start()
    {
        keyModel = transform.GetChild(0).gameObject;
        keyModelRenderer = keyModel.GetComponent<Renderer>();

        //Gets the necessary material for the key from the Resources folder
        if (whiteKey)
        {
            keyUp = Resources.Load("Key-Up") as Material;
            keyDown = Resources.Load("Key-Down") as Material;
        }
        else
        {
            keyUp = Resources.Load("KeySharp-Up") as Material;
            keyDown = Resources.Load("KeySharp-Down") as Material;
        }

        keyModelRenderer.material = keyUp;
    }

    //Plays the audio attatched to the key and sets its material to down
    public void PlayNote()
    {
        Debug.Log("NotePlay");
        GetComponent<AudioSource>().Play(); 
        keyModelRenderer.material = keyDown;
    }
    //Stops the audio attatched to the key and sets its material to up
    public void StopNote()
    {
        Debug.Log("NoteEnd");
        GetComponent<AudioSource>().Stop();
        keyModelRenderer.material = keyUp;
    }
}
