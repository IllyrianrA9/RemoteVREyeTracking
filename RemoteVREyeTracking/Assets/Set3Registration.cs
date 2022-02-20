using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set3Registration : MonoBehaviour
{
    public GameObject lowerKeyboard;
    public GameObject altKeyboard;
    public GameObject upperKeyboard;
    public List<GameObject> remainingScenes;
    public List<Material> remainingMaterial;
    public List<GameObject> remainingKeyboardsLow;
    public List<GameObject> remainingKeyboardsUp;
    public List<GameObject> remainingKeyboardsAlt;
    private int currentRandomNumber;
    public GameObject currentBackgroundScreen;
    public GameObject thisPage;

    public GameObject lowerKey;
    public GameObject upperKey;
    public GameObject altKey;

    //Called by login
    public GameObject firstScene;
    //public GameObject secondScene;

    public Material firstMaterial;
    //public Material secondMaterial;

    public GameObject firstKeyboardLow;
    public GameObject firstKeyboardAlt;
    public GameObject firstKeyboardUp;
    //public GameObject secondKeyboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Start3Registration()
    {
        currentRandomNumber = Random.Range(0, 2);

        if (currentRandomNumber == 1)
        {
            currentBackgroundScreen.GetComponent<Renderer>().material = remainingMaterial[currentRandomNumber];
            firstMaterial = remainingMaterial[currentRandomNumber];
            remainingMaterial.RemoveAt(currentRandomNumber);


            remainingKeyboardsLow[currentRandomNumber].SetActive(true);
            firstKeyboardLow = remainingKeyboardsLow[currentRandomNumber];
            firstKeyboardAlt = remainingKeyboardsAlt[currentRandomNumber];
            firstKeyboardUp = remainingKeyboardsUp[currentRandomNumber];
            lowerKey = remainingKeyboardsLow[currentRandomNumber];
            altKey = remainingKeyboardsAlt[currentRandomNumber];
            upperKey = remainingKeyboardsUp[currentRandomNumber];
            remainingKeyboardsLow.RemoveAt(currentRandomNumber);
            remainingKeyboardsUp.RemoveAt(currentRandomNumber);
            remainingKeyboardsAlt.RemoveAt(currentRandomNumber);

            remainingScenes[currentRandomNumber].SetActive(true);
            firstScene = remainingScenes[currentRandomNumber];
            remainingScenes.RemoveAt(currentRandomNumber);
        }
        else if (currentRandomNumber == 0)
        {
            
            currentBackgroundScreen.GetComponent<Renderer>().material = remainingMaterial[currentRandomNumber];
            
            firstMaterial = remainingMaterial[currentRandomNumber];
            
            remainingMaterial.RemoveAt(currentRandomNumber);

            remainingKeyboardsLow[currentRandomNumber].SetActive(true);

            firstKeyboardLow = remainingKeyboardsLow[currentRandomNumber];
            firstKeyboardAlt = remainingKeyboardsAlt[currentRandomNumber];
            firstKeyboardUp = remainingKeyboardsUp[currentRandomNumber];

            lowerKey = remainingKeyboardsLow[currentRandomNumber];
            altKey = remainingKeyboardsAlt[currentRandomNumber];
            upperKey = remainingKeyboardsUp[currentRandomNumber];
            remainingKeyboardsLow.RemoveAt(currentRandomNumber);
            remainingKeyboardsUp.RemoveAt(currentRandomNumber);
            remainingKeyboardsAlt.RemoveAt(currentRandomNumber);

            remainingScenes[currentRandomNumber].SetActive(true);

            firstScene = remainingScenes[currentRandomNumber];

            remainingScenes.RemoveAt(currentRandomNumber);
        }
        //keyboard.SetActive(false);
        //canvasKeyboard.SetActive(false);
        //lowerKeyboard.SetActive(false);
        //altKeyboard.SetActive(false);
        //upperKeyboard.SetActive(false);
        //paypalDistractKeyboard.SetActive(true);
        //endButton.SetActive(true);
        lowerKeyboard.SetActive(false);
        altKeyboard.SetActive(false);
        upperKeyboard.SetActive(false);

        thisPage.SetActive(false);
    }
}
