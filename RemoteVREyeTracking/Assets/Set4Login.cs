using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set4Login : MonoBehaviour
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

    public GameObject lowerKeyboardDistract;
    public GameObject altKeyboardDistract;
    public GameObject upperKeyboardDistract;

    public GameObject lowerKeyboardNoDistract;
    public GameObject altKeyboardNoDistract;
    public GameObject upperKeyboardNoDistract;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Start4Login()
    {
        thisPage.SetActive(false);
        if (secondRegDone.GetComponent<Set3Registration>().firstScene.name.Equals("9GAGNoDistract"))
        {
            lowerKeyboardNoDistract.SetActive(false);
            altKeyboardNoDistract.SetActive(false);
            upperKeyboardNoDistract.SetActive(false);

            sceneGAGD.SetActive(true);
            currentBackgroundScreen.GetComponent<Renderer>().material = materialGAGD;
            keyboardGAGD.SetActive(true);  
        }
        else if (secondRegDone.GetComponent<Set3Registration>().firstScene.name.Equals("9GAGDistract"))
        {
            lowerKeyboardDistract.SetActive(false);
            altKeyboardDistract.SetActive(false);
            upperKeyboardDistract.SetActive(false);

            sceneGAGDNo.SetActive(true);
            currentBackgroundScreen.GetComponent<Renderer>().material = materialGAGDNo;
            keyboardGAGDNo.SetActive(true);
        }
    }
}
