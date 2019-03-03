using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMode : MonoBehaviour
{
    //Add in all of the pianos
    public GameObject pianoFirst;
    public GameObject pianoSecond;
    public GameObject pianoThird;
    public GameObject pianoFourth;


    // Start is called before the first frame update
    void Start()
    {
        //For battle mode, the pianos will be spawned in these locations
        Instantiate(pianoFirst, new Vector3(-13.55f, -5.7f, 0), Quaternion.identity);
        Instantiate(pianoSecond, new Vector3(0.49f, -5.7f, 0), Quaternion.identity);
        Instantiate(pianoThird, new Vector3(-0.53f, 7.68f, 0), Quaternion.Euler(0, 0, 180));
        Instantiate(pianoFourth, new Vector3(13.56f, 7.68f, 0), Quaternion.Euler(0, 0, 180));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
