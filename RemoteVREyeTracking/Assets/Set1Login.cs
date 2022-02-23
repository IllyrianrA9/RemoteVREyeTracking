using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set1Login : MonoBehaviour
{
    
    public GameObject nextBackgroundScreen;
    public Material nextBackground;
    public GameObject newLowerKeyboard;
    public GameObject thisPage;
    public GameObject login1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartFirstLogin()
    {
        nextBackgroundScreen.GetComponent<Renderer>().material = nextBackground;
        newLowerKeyboard.SetActive(true);
        thisPage.SetActive(false);
        login1.SetActive(true);
    }
}
