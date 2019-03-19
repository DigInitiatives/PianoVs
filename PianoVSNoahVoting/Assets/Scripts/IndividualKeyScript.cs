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

    public int keyNum;

    public bool AI, player3or4, songrecording;

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
    float holdingTimer;

    PlayerDataManager playerData;

    void Start()
    {
        keyPos = transform.position;//Initialize transform.position of the object with this script
        holdingNote = false;
        holdingTimer = 1.0f;
        songrecording = true;
        keyModel = transform.GetChild(0).gameObject;
        keyModelRenderer = keyModel.GetComponent<Renderer>();

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
            keyPos = keyPos + Vector3.down * 2.5f;
        }
        else
        {
            keyPos = keyPos + new Vector3(0, 2.5f, 0);
        }


        if (!whiteKey)
        {
            Debug.DrawRay(keyPos + new Vector3(0, 1.5f, 0), Vector3.up);
        }
        if (AI)
        {
            //if (player3or4)
            //{
            if (whiteKey)
            {
                if (Physics.Raycast(keyPos, transform.up, out hit, 1f) && hit.collider.gameObject.tag == "Note")//Shoots raycast from the tip of note
                {
                    StopNote();
                    PlayNote();
                    AITimer = 0;
                }
                else
                {
                    if (!Physics.Raycast(keyPos, transform.up, out hit, .6f) && AITimer > 5)//Shoots raycast from the tip of note
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
                if (Physics.Raycast(keyPos, transform.up, out hit, .7f) && hit.collider.gameObject.tag == "Note")//Shoots raycast from the tip of note
                {
                    StopNote();
                    PlayNote();
                    AITimer = 0;
                }
                else
                {
                    if (!Physics.Raycast(keyPos, transform.up, out hit, .6f) && AITimer > 5)//Shoots raycast from the tip of note
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
            //}
            //else
            //{
            //	if (whiteKey)
            //{
            //	if (Physics.Raycast(keyPos + transform.up * 2.5f, transform.up, out hit, .5f) && hit.collider.gameObject.tag == "Note")//Shoots raycast from the tip of note
            //	{
            //		StopNote();
            //		PlayNote();
            //		AITimer = 0;
            //	}
            //	else
            //	{
            //		if (!Physics.Raycast(keyPos + transform.up * 2.5f, transform.up, out hit, .6f) && AITimer > 5)//Shoots raycast from the tip of note
            //		{
            //			StopNote();
            //		}
            //		else
            //		{
            //			holdingNote = true;
            //		}
            //	}
            //	AITimer++;
            //}
            //	else
            //{
            //	if (Physics.Raycast(keyPos + transform.up * 1.5f, transform.up, out hit, .7f) && hit.collider.gameObject.tag == "Note")//Shoots raycast from the tip of note
            //	{
            //		StopNote();
            //		PlayNote();
            //		AITimer = 0;
            //	}
            //	else
            //	{
            //		if (!Physics.Raycast(keyPos + transform.up * 1.5f, transform.up, out hit, .6f) && AITimer > 5)//Shoots raycast from the tip of note
            //		{
            //			StopNote();
            //		}
            //		else
            //		{
            //			holdingNote = true;
            //		}
            //	}
            //	AITimer++;
            //}
            //}
        }
        if (stamp)
        {
            TimeStamp();
        }
        if (holdingNote)//If the holding note has been hit
        {
            //if(player3or4)
            //{
            if (whiteKey)
            {
                if (Physics.Raycast(keyPos, transform.up, out hit, heldNotedistance + 1f))//Shoots raycast from the tip of note
                {
                    if (hit.collider.tag == "HeldNote")//If the raycast hits a note that must be held...
                    {
                        //Debug.Log("HELD!!!!!!");

                        playerData.AddHoldingScore(0.3f);

                        holdingNote = true;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
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
                holdingTimer -= Time.deltaTime;
                if (holdingTimer <= 0)//Every frame the timer is lowered, once it hits zero it resets to one and gives points
                {
                    //5 Points
                    holdingTimer = 1.0f;
                }
            }
            else
            {
                if (Physics.Raycast(keyPos, transform.up, out hit, heldNotedistance + 1f))//Shoots raycast from the tip of note
                {
                    if (hit.collider.tag == "HeldNote")//If the raycast hits a note that must be held...
                    {
                        //Debug.Log("HELD!!!!!!");

                        playerData.AddHoldingScore(0.3f);

                        holdingNote = true;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
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
                holdingTimer -= Time.deltaTime;
                if (holdingTimer <= 0)//Every frame the timer is lowered, once it hits zero it resets to one and gives points
                {
                    //5 Points
                    holdingTimer = 1.0f;
                }
            }
            //}
            //else
            //{
            //	if (whiteKey)
            //	{
            //		if (Physics.Raycast(keyPos + new Vector3(0, 2.5f, 0), Vector3.up, out hit, heldNotedistance + 1f))//Shoots raycast from the tip of note
            //		{
            //			if (hit.collider.tag == "HeldNote")//If the raycast hits a note that must be held...
            //			{
            //				//Debug.Log("HELD!!!!!!");

            //				playerData.AddHoldingScore(0.3f);

            //				holdingNote = true;
            //                         hit.transform.position = new Vector3(-1000, -1000, -1000);
            //                         hit.transform.gameObject.SetActive(false);
            //                     }
            //			else
            //			{
            //				holdingNote = false;
            //			}
            //		}
            //		else
            //		{
            //			holdingNote = false;
            //		}
            //		holdingTimer -= Time.deltaTime;
            //		if (holdingTimer <= 0)//Every frame the timer is lowered, once it hits zero it resets to one and gives points
            //		{
            //			//5 Points
            //			holdingTimer = 1.0f;
            //		}
            //	}
            //	else
            //	{
            //		if (Physics.Raycast(keyPos + new Vector3(0, 1.5f, 0), Vector3.up, out hit, heldNotedistance + 1f))//Shoots raycast from the tip of note
            //		{
            //			if (hit.collider.tag == "HeldNote")//If the raycast hits a note that must be held...
            //			{
            //				//Debug.Log("HELD!!!!!!");

            //				playerData.AddHoldingScore(0.3f);

            //				holdingNote = true;
            //                         hit.transform.position = new Vector3(-1000, -1000, -1000);
            //                         hit.transform.gameObject.SetActive(false);
            //                     }
            //			else
            //			{
            //				holdingNote = false;
            //			}
            //		}
            //		else
            //		{
            //			holdingNote = false;
            //		}
            //		holdingTimer -= Time.deltaTime;
            //		if (holdingTimer <= 0)//Every frame the timer is lowered, once it hits zero it resets to one and gives points
            //		{
            //			//5 Points
            //			holdingTimer = 1.0f;
            //		}
            //	}
            //}

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

        heldNotedistance = 0;
        //if(player3or4)
        //{
        if (whiteKey)
        {

            if (Physics.Raycast(keyPos, transform.up, out hit, 1))//Shoots raycast from the tip of note
            {
                if (hit.collider.tag == "Note" || hit.collider.tag == "SharpNote")//If the raycast hits a regular or sharp note...
                {
                    if (hit.distance <= .7f && hit.distance > .45f)//Sweet spot distance
                    {
                        holdingNote = true;
                        //Debug.Log("Sweet Spot");

                        playerData.AddScore(100);//Sweet spot
                        playerData.IncreaseMultiplier(1);//Add to multiplier

                        //Stores the distance hit in order to check forheld notes
                        heldNotedistance = hit.distance;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
                    }
                    else if (hit.distance > .7f)//To far distance
                    {
                        holdingNote = true;
                        //Debug.Log("Too far");
                        playerData.BreakMultiplier();//No score, break multiplier
                        heldNotedistance = hit.distance;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
                    }
                    else//Not to far but not in sweet spot
                    {
                        holdingNote = true;
                        //Debug.Log("Too close");
                        playerData.AddScore(50);//Too Close spot
                        heldNotedistance = hit.distance;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
                    }
                }
            }
        }
        else
        {
            if (Physics.Raycast(keyPos, transform.up, out hit, 1))//Shoots raycast from the tip of note
            {
                if (hit.collider.tag == "Note" || hit.collider.tag == "SharpNote")//If the raycast hits a regular or sharp note...
                {
                    if (hit.distance <= .7f && hit.distance > .45f)//Sweet spot distance
                    {
                        holdingNote = true;
                        //Debug.Log("Sweet Spot");

                        playerData.AddScore(100);//Sweet spot
                        playerData.IncreaseMultiplier(1);//Add to multiplier

                        //Stores the distance hit in order to check forheld notes
                        heldNotedistance = hit.distance;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
                    }
                    else if (hit.distance > .7f)//To far distance
                    {
                        holdingNote = true;
                        //Debug.Log("Too far");
                        playerData.BreakMultiplier();//No score, break multiplier
                        heldNotedistance = hit.distance;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
                    }
                    else//Not to far but not in sweet spot
                    {
                        holdingNote = true;
                        //Debug.Log("Too close");
                        playerData.AddScore(50);//Too Close spot
                        heldNotedistance = hit.distance;
                        hit.transform.position = new Vector3(-1000, -1000, -1000);
                        hit.transform.gameObject.SetActive(false);
                    }
                }
            }
        }
        //}
        //else
        //{

        //	if (whiteKey)
        //	{
        //		if (Physics.Raycast(keyPos + new Vector3(0, 2.5f, 0), Vector3.up, out hit, 1))//Shoots raycast from the tip of note
        //		{
        //			if (hit.collider.tag == "Note" || hit.collider.tag == "SharpNote")//If the raycast hits a regular or sharp note...
        //			{
        //				if (hit.distance <= .7f && hit.distance > .45f)//Sweet spot distance
        //				{
        //					holdingNote = true;
        //					//Debug.Log("Sweet Spot");

        //					playerData.AddScore(100);//Sweet spot
        //					playerData.IncreaseMultiplier(1);//Add to multiplier

        //					//Stores the distance hit in order to check forheld notes
        //					heldNotedistance = hit.distance;
        //                          hit.transform.position = new Vector3(-1000, -1000, -1000);
        //                          hit.transform.gameObject.SetActive(false);
        //                      }
        //				else if (hit.distance > .7f)//To far distance
        //				{
        //					holdingNote = true;
        //					//Debug.Log("Too far");
        //					playerData.BreakMultiplier();//No score, break multiplier
        //					heldNotedistance = hit.distance;
        //                          hit.transform.position = new Vector3(-1000, -1000, -1000);
        //                          hit.transform.gameObject.SetActive(false);
        //                      }
        //				else//Not to far but not in sweet spot
        //				{
        //					holdingNote = true;
        //					//Debug.Log("Too close");
        //					playerData.AddScore(50);//Too Close spot
        //					heldNotedistance = hit.distance;
        //                          hit.transform.position = new Vector3(-1000, -1000, -1000);
        //                          hit.transform.gameObject.SetActive(false);
        //                      }
        //			}
        //		}
        //	}
        //	else
        //	{
        //		if (Physics.Raycast(keyPos + new Vector3(0, 1.5f, 0), Vector3.up, out hit, 1))//Shoots raycast from the tip of note
        //		{
        //			if (hit.collider.tag == "Note" || hit.collider.tag == "SharpNote")//If the raycast hits a regular or sharp note...
        //			{
        //				if (hit.distance <= .7f && hit.distance > .45f)//Sweet spot distance
        //				{
        //					holdingNote = true;
        //					//Debug.Log("Sweet Spot");

        //					playerData.AddScore(100);//Sweet spot
        //					playerData.IncreaseMultiplier(1);//Add to multiplier

        //					//Stores the distance hit in order to check forheld notes
        //					heldNotedistance = hit.distance;
        //                          hit.transform.position = new Vector3(-1000, -1000, -1000);
        //                          hit.transform.gameObject.SetActive(false);
        //                      }
        //				else if (hit.distance > .7f)//To far distance
        //				{
        //					holdingNote = true;
        //					//Debug.Log("Too far");
        //					playerData.BreakMultiplier();//No score, break multiplier
        //					heldNotedistance = hit.distance;
        //                          hit.transform.position = new Vector3(-1000, -1000, -1000);
        //                          hit.transform.gameObject.SetActive(false);
        //                      }
        //				else//Not to far but not in sweet spot
        //				{
        //					holdingNote = true;
        //					//Debug.Log("Too close");
        //					playerData.AddScore(50);//Too Close spot
        //					heldNotedistance = hit.distance;
        //                          hit.transform.position = new Vector3(-1000, -1000, -1000);
        //                          hit.transform.gameObject.SetActive(false);
        //                      }
        //			}
        //		}
        //	}
        //}
        if (songrecording)
        {
            SongRecording.AddNote(keyNum);
        }
    }
    //Stops the audio attatched to the key and sets its material to up
    public void StopNote()
    {
        //Debug.Log("NoteEnd");
        StartCoroutine("SoundStop");
        stamp = true;
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
