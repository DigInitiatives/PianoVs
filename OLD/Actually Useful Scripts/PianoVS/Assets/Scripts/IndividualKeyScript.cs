﻿///Author: Adam Warkentin
///This script is attatched to a "Key" which only has a public method that plays the sound clip of the attatched audio source
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 5-Feb-2019
///Dependencies: Requires an audio source component.If the key is a white key, check the "whiteKey" bool in the editor

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualKeyScript : MonoBehaviour
{
    //keymodel is the visual component of this obj
    GameObject keyModel;

    //keyModelRenderer is just the rendered component of keyModel
    Renderer keyModelRenderer;

    //These are the materials for how the key should look when up and down
    Material keyUp;
    Material keyDown;

    //Variable that is set in the editor to determine if the key which this script is attatched to is a whitekey or a black key
    public bool whiteKey;


    RaycastHit hit;//The raycast collision data
    Vector3 keyPos;//The position of the key, just short form for the transform.position because I am lazy
    bool holdingNote;//Variable for looping the code involving held notes
    GameObject heldNote;//Variable to store the held notes gameobject so it can be destroyed after use
    float holdingTimer;

    void Start()
    {
        keyPos = transform.position;//Initialize transform.position of the object with this script
        holdingNote = false;
        holdingTimer = 1.0f;

        keyModel = transform.GetChild(0).gameObject;
        keyModelRenderer = keyModel.GetComponent<Renderer>();

        //Gets the necessary material for the key from the Resources folder
        if (whiteKey)
        {
            keyUp = Resources.Load("Material/Key-Up") as Material;
            keyDown = Resources.Load("Material/Key-Down") as Material;
        }
        else
        {
            keyUp = Resources.Load("Material/KeySharp-Up") as Material;
            keyDown = Resources.Load("Material/KeySharp-Down") as Material;
        }

        keyModelRenderer.material = keyUp;
    }

    public void Update()
    {
        if (holdingNote)//If the holding note has been hit
        {
            if (Physics.Raycast(keyPos, Vector3.up, out hit, 4))//Shoots raycast from center of note to check if the holding note is gone yet
            {
                if (hit.collider.tag == "HeldNote")
                {
                    Destroy(hit.collider.gameObject);
                }
                if (hit.collider.tag != "HeldNote")//If the raycast stops hitting the held note stop giving points
                {
                    StopHolding();
                }
            }
            else//If the raycast simply doesnt hit anything...
            {
                StopHolding();
            }
            if (holdingNote)
            {
                holdingTimer -= Time.deltaTime;
                if (holdingTimer <= 0)//Every frame the timer is lowered, once it hits zero it resets to one and gives points
                {
                    //5 Points
                    holdingTimer = 1.0f;
                }
            }
        }
    }

    //Plays the audio attatched to the key and sets its material to down
    public void PlayNote()
    {
        GetComponent<AudioSource>().Play();
        keyModelRenderer.material = keyDown;

        if (Physics.Raycast(keyPos, Vector3.up, out hit, 8))//If a raycast shot from the key hits something...
        {
            if (hit.collider.tag == "Note" || hit.collider.tag == "SharpNote" || hit.collider.tag == "HeldNote")//If the raycast hits a note...
            {
                if (hit.distance <= 4 && hit.distance > 2)//Sweet spot distance
                {
                    if (hit.collider.tag == "HeldNote")//If the raycast hits a note that must be held...
                    {
                        //100 points
                        holdingNote = true;
                        Destroy(hit.collider.gameObject);
                    }
                    else//If it hits any note that isnt a hold note
                    {
                        Debug.Log("Sweet Spot");
                        //100 points
                        Destroy(hit.collider.gameObject);
                    }
                }
                else if (hit.distance > 4 && hit.distance <= 6)//Far but still good
                {
                    //50 points
                }
                else if (hit.distance > 6)//To far nibba
                {
                    //25 points
                }
                else//Too close
                {

                }
            }
        }
    }

    //Stops the audio attatched to the key and sets its material to up
    public void StopNote()
    {
        //Debug.Log("NoteEnd");
        GetComponent<AudioSource>().Stop();
        keyModelRenderer.material = keyUp;

        StopHolding();
    }

    public void StopHolding()
    {
        if (holdingNote)//If they were holding a note, destroy the note, stop looping in update, and reset timer
        {
            holdingTimer = 1.0f;
            holdingNote = false;
        }
    }
}
