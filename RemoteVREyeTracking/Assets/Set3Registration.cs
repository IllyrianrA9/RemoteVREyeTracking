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
    public List<GameObject> remainingKeyboards;
    private int currentRandomNumber;
    public GameObject currentBackgroundScreen;
    public GameObject thisPage;

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
            remainingMaterial.RemoveAt(currentRandomNumber);

            //remainingKeyboards[currentRandomNumber].SetActive(true);
            //remainingKeyboards.RemoveAt(currentRandomNumber);

            remainingScenes[currentRandomNumber].SetActive(true);
            remainingScenes.RemoveAt(currentRandomNumber);
        }
        else if (currentRandomNumber == 0)
        {
            
            currentBackgroundScreen.GetComponent<Renderer>().material = remainingMaterial[currentRandomNumber];
            remainingMaterial.RemoveAt(currentRandomNumber);

            //remainingKeyboards[currentRandomNumber].SetActive(true);
            //remainingKeyboards.RemoveAt(currentRandomNumber);

            remainingScenes[currentRandomNumber].SetActive(true);
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
