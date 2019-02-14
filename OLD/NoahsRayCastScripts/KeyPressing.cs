///Author: Noah Rittenhouse
///Purpose of Script: Detect when a note is hit and how far
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 31-Jan-2019
using UnityEngine;

public class KeyPressing : MonoBehaviour
{
    RaycastHit hit;//The raycast collision data
    Vector3 keyPos;//The position of the key, just short form for the transform.position because I am lazy

    void Start()
    {
        keyPos = transform.position;//Initialize transform.position of the object with this script
    }

    /// <summary>
    /// This method is called by the Key/Button in the scene when its clicked. 
    /// This script will:
    ///  - Play the keys sound chosen in the editor.
    ///  - Shoot a raycast up and determine if and how far away a collided note is
    /// </summary>
    public void PlayKey()
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);

        if (Physics.Raycast(keyPos, Vector3.up, out hit))
        {
            if (hit.collider.tag == "WhiteNote")
            {
                if (hit.distance < 2 && hit.distance > 1)
                {
                    Debug.Log("Sweet Spot");
                    Destroy(hit.collider.gameObject);
                }
                else if(hit.distance > 2)
                {
                    Debug.Log("Too far");
                }
                else
                {
                    Debug.Log("Fuck");
                }
            }
        }
    }
}
