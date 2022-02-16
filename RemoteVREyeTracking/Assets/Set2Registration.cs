using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set2Registration : MonoBehaviour
{
    public GameObject lowerKeyboard;
    public GameObject altKeyboard;
    public GameObject upperKeyboard;
    public GameObject nextBackgroundScreen;
    public Material nextBackground;
    public GameObject paypalDistract;
    public GameObject paypalNoDistract;
    public GameObject newLowerKeyboard;

    public GameObject thisPage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartSecondRegistration()
    {
        nextBackgroundScreen.GetComponent<Renderer>().material = nextBackground;
        paypalDistract.SetActive(true);
        //paypalNoDistract.SetActive(false);
        newLowerKeyboard.SetActive(true);
        altKeyboard.SetActive(false);
        upperKeyboard.SetActive(false);
        lowerKeyboard.SetActive(false);
        thisPage.SetActive(false);
    }
}
