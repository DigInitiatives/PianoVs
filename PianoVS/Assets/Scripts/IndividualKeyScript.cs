///Author: Adam Warkentin
///This script is attatched to a "Key" and controls note hitting, sounds, and score provision
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 14-Feb-2019
///Dependencies: If the key is a white key, check the "whiteKey" bool in the editor

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IndividualKeyScript : MonoBehaviour
{
    float timeStamp;
    float heldNoteDistance = 0;
    bool stamp;

    public bool AI;
    int AITimer;

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
    //bool holdingScoring;//Variable that alternates if the held notes give points

    PlayerDataManager playerData;

    void Start()
    {
        keyPos = transform.position;//Initialize transform.position of the object with this script
        holdingNote = false;

        keyModel = transform.GetChild(0).gameObject;
        keyModelRenderer = keyModel.GetComponent<Renderer>();

        //Gets the necessary material for the key from the Resources folder
        if (whiteKey)
        {
<<<<<<< HEAD
            keyUp = Resources.Load("Material/Key-Up") as Material;
            keyDown = Resources.Load("Material/Key-Down") as Material;
=======
            keyUp = Resources.Load("Key-Up") as Material;
            keyDown = Resources.Load("Key-Down") as Material;
>>>>>>> parent of 1543517... Crap
        }
        else
        {
            keyUp = Resources.Load("Material/KeySharp-Up") as Material;
            keyDown = Resources.Load("Material/KeySharp-Down") as Material;
        }

        keyModelRenderer.material = keyUp;

        playerData = transform.parent.GetComponentInParent<PlayerDataManager>();//Set playerData variable to the keyboards script component
    }

    public void Update()
    {
        if (!whiteKey)
            Debug.DrawRay(keyPos + new Vector3(0, 1.5f, 0), Vector3.up);
        if (AI)
        {
            if (whiteKey)
            {
                if (Physics.Raycast(keyPos + new Vector3(0, 2.5f, 0), Vector3.up, out hit, .5f) && hit.collider.gameObject.tag == "Note")//Shoots raycast from the tip of note
                {
                    StopNote();
                    PlayNote();
                    AITimer = 0;
                }
                else
                {
                    if (!Physics.Raycast(keyPos + new Vector3(0, 2.5f, 0), Vector3.up, out hit, .6f) && AITimer > 5)//Shoots raycast from the tip of note
                    {
                        StopNote();
                    }
                    else
                    {
                        holdingNote = true;
                    }
                }
                AITimer++;
            }
            else
            {
                if (Physics.Raycast(keyPos + new Vector3(0, 1.5f, 0), Vector3.up, out hit, .6f) && hit.collider.gameObject.tag == "Note")//Shoots raycast from the tip of note
                {
                    StopNote();
                    PlayNote();
                    AITimer = 0;
                }
                else
                {
                    if (!Physics.Raycast(keyPos + new Vector3(0, 1.5f, 0), Vector3.up, out hit, .6f) && AITimer > 5)//Shoots raycast from the tip of note
                    {
                        StopNote();
                    }
                    else
                    {
                        holdingNote = true;
                    }
                }
                AITimer++;
            }
        }
        if (stamp)
        {
            TimeStamp();
        }
        if (holdingNote)//If the holding note has been hit
        {
            if (whiteKey)
            {
                if (Physics.Raycast(keyPos + new Vector3(0, 2.5f, 0), Vector3.up, out hit, heldNoteDistance + 1f))//Shoots raycast from the tip of note
                {
                    if (hit.collider.tag == "HeldNote")//If the raycast hits a note that must be held...
                    {
                        Debug.Log("HELD!!!!!!");

                        playerData.AddHoldingScore(0.3f);

                        holdingNote = true;
                        Destroy(hit.collider.gameObject);
                    }
                    else
                    {
                        holdingNote = false;
                    }
                }
                else
                {
                    holdingNote = false;
                }
            }
            else
            {
                if (Physics.Raycast(keyPos + new Vector3(0, 1.5f, 0), Vector3.up, out hit, heldNoteDistance + 1f))//Shoots raycast from the tip of note
                {
                    if (hit.collider.tag == "HeldNote")//If the raycast hits a note that must be held...
                    {
                        Debug.Log("HELD!!!!!!");

                        playerData.AddHoldingScore(0.3f);

                        holdingNote = true;
                        Destroy(hit.collider.gameObject);
                    }
                    else
                    {
                        holdingNote = false;
                    }
                }
                else
                {
                    holdingNote = false;
                }
            }
        }
    }

    //Plays the audio attatched to the key and sets its material to down
    public void PlayNote()
    {
        StopCoroutine("SoundStop");
        GetComponent<AudioSource>().volume = 1;
        stamp = false;
        //Debug.Log("NotePlay");
        GetComponent<AudioSource>().Play();
        keyModelRenderer.material = keyDown;

        heldNoteDistance = 0;

        if (whiteKey)
        {
            if (Physics.Raycast(keyPos + new Vector3(0, 2.3f, 0), Vector3.up, out hit, 1))//Shoots raycast from the tip of note
            {
                if (hit.collider.tag == "Note" || hit.collider.tag == "SharpNote")//If the raycast hits a regular or sharp note...
                {
                    if (hit.distance <= .7f && hit.distance > .45f)//Sweet spot distance
                    {
                        holdingNote = true;
                        playerData.AddScore(100);//Sweet spot
                        playerData.IncreaseMultiplier(1);//Add to multiplier

                        heldNoteDistance = hit.distance;//Stores the distance hit in order to check for held notes
                        Destroy(hit.collider.gameObject);
                    }
                    else if (hit.distance > .7f)//To far distance
                    {
                        holdingNote = true;
                        playerData.BreakMultiplier();//No score, break multiplier

                        heldNoteDistance = hit.distance;
                        Destroy(hit.collider.gameObject);
                    }
                    else//Not to far but not in sweet spot
                    {
                        holdingNote = true;
                        playerData.AddScore(50);//Sweet spot
                        heldNoteDistance = hit.distance;
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
        else
        {
            if (Physics.Raycast(keyPos + new Vector3(0, 1.5f, 0), Vector3.up, out hit, 1))//Shoots raycast from the tip of note
            {
                if (hit.collider.tag == "Note" || hit.collider.tag == "SharpNote")//If the raycast hits a regular or sharp note...
                {
                    if (hit.distance <= .7f && hit.distance > .45f)//Sweet spot distance
                    {
                        holdingNote = true;
                        Debug.Log("Super Sweet Spot");
                        //Stores the distance hit in order to check forheld notes
                        heldNoteDistance = hit.distance;
                        Destroy(hit.collider.gameObject);
                    }
                    else if (hit.distance > .7f)//To far distance
                    {
                        holdingNote = true;
                        Debug.Log("Too far");
                        heldNoteDistance = hit.distance;
                        Destroy(hit.collider.gameObject);
                    }
                    else//Not to far but not in sweet spot
                    {
                        holdingNote = true;
                        Debug.Log("Too close");
                        heldNoteDistance = hit.distance;
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }
    //Stops the audio attatched to the key and sets its material to up
    public void StopNote()
    {
        Debug.Log("NoteEnd");
        StartCoroutine("SoundStop");
        stamp = true;
        keyModelRenderer.material = keyUp;
        StopHolding();
    }

    public void StopHolding()
    {
        if (holdingNote)//If they were holding a note, destroy the note, stop looping in update, and reset timer
        {
            holdingNote = false;
        }
    }
    public void TimeStamp()
    {
        GetComponent<AudioSource>().volume -= Time.deltaTime * 8;
    }

    IEnumerator SoundStop()
    {
        yield return new WaitForSeconds(.5f);

        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 1;
        stamp = false;
    }
}
