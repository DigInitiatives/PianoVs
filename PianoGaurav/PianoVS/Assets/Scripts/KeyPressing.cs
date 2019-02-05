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
        Debug.Log("PlayKey");
        //GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);

        if (Physics.Raycast(keyPos, Vector3.up, out hit, 3))
        {
            Debug.Log("RayCast");

            Debug.Log("Sweet Spot");
            Debug.DrawLine(keyPos, hit.point, Color.red);
            Time.timeScale = 0;
            if (hit.collider.tag == "BlackNotes")
            {
                if (hit.distance <= 1 && hit.distance > 0.75f)
                {
                    Debug.Log("Sweet Spot");
                    Destroy(hit.collider.gameObject);
                }
                else if(hit.distance > 1 && hit.distance < 3)
                {
                    Debug.Log("Too far but still fair");
                    Destroy(hit.collider.gameObject);
                }
                else
                {
                    Debug.Log("Fuck");
                }
            }
        }
    }
}
