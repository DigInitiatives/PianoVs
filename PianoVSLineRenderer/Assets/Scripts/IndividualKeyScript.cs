///Author: Adam Warkentin
///This script is attatched to a "Key" which only has a public method that plays the sound clip of the attatched audio source
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 19-Mar-2019
///Dependencies: Requires an audio source component.If the key is a white key, check the "whiteKey" bool in the editor
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualKeyScript : MonoBehaviour
{
    float timeStamp;
    float heldNotedistance = 0;
    bool stamp;

    public NoteSpawning noteSpawner;

    private GameObject currentNote;

    public int keyNum;

    public bool AI, player3or4, songrecording;

    int AITimer;
    Vector3 currentHeldNote;

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

    PlayerDataManager playerData;

    void Start()
    {
        keyPos = transform.position;//Initialize transform.position of the object with this script
        holdingNote = false;
        songrecording = true;
        keyModel = transform.GetChild(0).gameObject;
        keyModelRenderer = keyModel.GetComponent<Renderer>();

        currentNote = new GameObject();

        currentHeldNote = Vector3.zero;

        //Gets the necessary material for the key from the Resources folder
        if (whiteKey)
        {
            keyUp = Resources.Load("Images/KeyImages/Materials/Key-Up") as Material;
            keyDown = Resources.Load("Images/KeyImages/Materials/Key-Down") as Material;
        }
        else
        {
            keyUp = Resources.Load("Images/KeyImages/Materials/KeySharp-Up") as Material;
            keyDown = Resources.Load("Images/KeyImages/Materials/KeySharp-Down") as Material;
        }

        keyModelRenderer.material = keyUp;

        playerData = transform.parent.GetComponentInParent<PlayerDataManager>();//Set playerData variable to the keyboards script component

        //keyNum = 
    }

    public void Update()
    {
        if (player3or4)
        {
            if (whiteKey)
            {
                keyPos = transform.position + Vector3.down * 2.5f;
            }
            else
            {
                keyPos = transform.position + Vector3.down * 1.5f;
            }
        }
        else
        {
            if (whiteKey)
            {
                keyPos = transform.position + Vector3.up * 2.5f;
            }
            else
            {
                keyPos = transform.position + Vector3.up * 1.5f;
            }
        }
        if (AI)
        {
            if (!holdingNote)
            {
                if (Physics.Raycast(keyPos, transform.up, out hit, .7f))//Shoots raycast from the tip of note
                {
                    if (hit.collider.gameObject.tag == "Note" && (currentNote != hit.transform.gameObject || currentNote.transform.root != hit.transform.gameObject))
                    {
                        PlayNote(true);
                        AITimer = 0;
                    }
                    else
                    {
                        StopNote();
                    }
                }
            }

        }
        if (holdingNote)//If the holding note has been hit
        {
            if (currentHeldNote == Vector3.zero)
            {
                foreach (Vector3 note in noteSpawner.holdNotes)
                {
                    if (note.x == keyNum)
                    {
                        currentHeldNote = note;
                    }
                }
            }
            else
            {
                if (noteSpawner.beat <= currentHeldNote.z + 38)
                {
                    
                    playerData.AddHoldingScore(0.3f);
                }
                else
                {
                    StopNote();
                }
            }
        }

        if (stamp)
        {
            TimeStamp();
        }
    }

    //Plays the audio attatched to the key and sets its material to down

    public void PlayNote(bool wasAI)
    {
        if (!AI || !wasAI)//If the player presses the key
        {
            playerData.ResetSleepTime();
        }
        StopCoroutine("SoundStop");
        GetComponent<AudioSource>().volume = 1;
        stamp = false;
        GetComponent<AudioSource>().Play();
        keyModelRenderer.material = keyDown;

        heldNotedistance = 0;
        if (Physics.Raycast(keyPos, transform.up, out hit, 1))//Shoots raycast from the tip of note
        {
            if (hit.collider.tag == "Note" && (currentNote != hit.transform.gameObject || currentNote.transform.root != hit.transform.gameObject))//If the raycast hits a regular or sharp note...
            {
                if (hit.distance <= .7f && hit.distance > .45f)//Sweet spot distance
                {
                    playerData.AddScore(100);//Sweet spot
                    playerData.IncreaseMultiplier(.1f);//Add to multiplier
                }
                else if (hit.distance > .7f)//To far distance
                {
                    playerData.BreakMultiplier();//No score, break multiplier
                }
                else//Not to far but not in sweet spot
                {
                    playerData.AddScore(50);//Too Close spot
                }

                if (wasAI)
                {
                    if (currentNote != null)
                    {
                        //StopNote();
                    }

                    currentNote = hit.transform.gameObject;

                    if (currentNote.transform.root.GetComponent<LineRenderer>().enabled == true)
                    {
                        holdingNote = true;
                        heldNotedistance = hit.distance;
                    }
                    else
                    {
                        holdingNote = false;
                        currentNote.transform.position = new Vector3(-1000, -1000, -1000);
                        currentNote.transform.root.gameObject.SetActive(false);
                    }
                }
            }
        }
        if (songrecording)
        {
            SongRecording.AddNote(keyNum);
        }
    }
    //Stops the audio attatched to the key and sets its material to up
    public void StopNote()
    {
        StartCoroutine("SoundStop");
        stamp = true;
        keyModelRenderer.material = keyUp;
        StopHolding();
    }

    public void StopHolding()
    {
        if (holdingNote)//If they were holding a note, destroy the note, stop looping in update, and reset timer
        {
            noteSpawner.holdNotes.Remove(currentHeldNote);
            currentHeldNote = Vector3.zero;
            holdingNote = false;
            currentNote.transform.position = new Vector3(-1000, -1000, -1000);
            currentNote.transform.root.gameObject.SetActive(false);
        }
    }
    public void TimeStamp()
    {
        GetComponent<AudioSource>().volume -= Time.deltaTime * 4;
    }

    IEnumerator SoundStop()
    {
        yield return new WaitForSeconds(1f);

        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().volume = 1;
        stamp = false;
    }
}
