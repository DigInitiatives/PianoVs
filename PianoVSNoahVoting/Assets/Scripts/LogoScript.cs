///Author: Noah Rittenhouse
///This script is attatched to a seperate canvas that will show logos that fade and then close
///Last Modified By: Noah Rittenhouse
///Last Modified Date: 9-April-2019
///Dependencies: Requires logos to be selected in editor and the logos MUST be ordered with the bottom logo as the first in the hierarchy but 0 up in the list
///
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoScript : MonoBehaviour
{
    [SerializeField]
    List<GameObject> logos;//A list of gameobjects, each one a different logo, i.e. Nait logo and then game logo
    int currentIndex;
    Color currentColor;
    float fadeSpeed;

    void Start()
    {
        currentIndex = 0;
        fadeSpeed = 0.0075f;

        logos = new List<GameObject>();
        for (int i = transform.childCount - 1; i >= 0; i--)//For every child
        {
            logos.Add(transform.GetChild(i).gameObject);
        }
    }

    void Update()
    {
        currentColor = logos[currentIndex].GetComponent<Image>().color;//Set the color as the logos current
        currentColor.a -= fadeSpeed;//Reduce the alpha of this variable
        logos[currentIndex].GetComponent<Image>().color = currentColor;//Set the logos color as the variable

        if (currentColor.a <= 0)//If the logo is invisible move on
        {
            CloseLogo();
        }
        if (Input.GetKeyDown(KeyCode.Escape))//Close twice to skip past the white fading images
        {
            CloseLogo();
            CloseLogo();
        }
    }

    void CloseLogo()
    {
        if (currentIndex >= logos.Count)
        {
            gameObject.SetActive(false);
        }
        else
        {
            logos[currentIndex].SetActive(false);//Close the logo permanently
            currentIndex++;//Go to next logo
        }
        if (currentIndex >= logos.Count)
        {
            gameObject.SetActive(false);
        }
    }
}
