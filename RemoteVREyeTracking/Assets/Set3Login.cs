using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set3Login : MonoBehaviour
{
    public GameObject currentBackgroundScreen;
    public GameObject thisPage;
    public GameObject secondRegDone;

    public GameObject sceneGAGD;
    public Material materialGAGD;
    public GameObject keyboardGAGD;

    public GameObject sceneGAGDNo;
    public Material materialGAGDNo;
    public GameObject keyboardGAGDNo;

    public GameObject lowerKeyboard;
    public GameObject altKeyboard;
    public GameObject upperKeyboard;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Start3Login()
    {
        thisPage.SetActive(false);
        if (secondRegDone.GetComponent<Set3Registration>().firstScene.name.Equals("9GAGNoDistract"))
        {
            sceneGAGDNo.SetActive(true);
            currentBackgroundScreen.GetComponent<Renderer>().material = materialGAGDNo;
            keyboardGAGDNo.SetActive(true);
        }
        else if (secondRegDone.GetComponent<Set3Registration>().firstScene.name.Equals("9GAGDistract"))
        {
            sceneGAGD.SetActive(true);
            currentBackgroundScreen.GetComponent<Renderer>().material = materialGAGD;
            keyboardGAGD.SetActive(true);
        }
        lowerKeyboard.SetActive(false);
        altKeyboard.SetActive(false);
        upperKeyboard.SetActive(false);
    }
}
