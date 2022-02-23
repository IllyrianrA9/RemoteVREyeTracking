using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set4Registration : MonoBehaviour
{
    public GameObject evaluation;
    private GameObject lowerKeyboard;
    private GameObject altKeyboard;
    private GameObject upperKeyboard;
    private List<GameObject> remainingScenes;
    private List<Material> remainingMaterial;
    private List<GameObject> remainingKeyboardsLow;
    private List<GameObject> remainingKeyboardsUp;
    private List<GameObject> remainingKeyboardsAlt;
    public GameObject currentBackgroundScreen;
    public GameObject thisPage;
    public GameObject secondScene;

    public GameObject secondRegDone;

    // Start is called before the first frame update
    void Start()
    {
        remainingScenes = secondRegDone.GetComponent<Set3Registration>().remainingScenes;
        remainingMaterial = secondRegDone.GetComponent<Set3Registration>().remainingMaterial;
        remainingKeyboardsLow = secondRegDone.GetComponent<Set3Registration>().remainingKeyboardsLow;
    }

    public void Start4Registration()
    {

        currentBackgroundScreen.GetComponent<Renderer>().material = remainingMaterial[0];
        remainingMaterial.RemoveAt(0);

        remainingKeyboardsLow[0].SetActive(true);
        remainingKeyboardsLow.RemoveAt(0);
        secondScene = remainingScenes[0];
        remainingScenes[0].SetActive(true);
        secondRegDone.GetComponent<Set3Registration>().remainingScenes.RemoveAt(0);
        //remainingScenes.RemoveAt(0);

        secondRegDone.GetComponent<Set3Registration>().lowerKey.SetActive(false);
        secondRegDone.GetComponent<Set3Registration>().upperKey.SetActive(false);
        secondRegDone.GetComponent<Set3Registration>().altKey.SetActive(false);

        evaluation.SetActive(false);
        thisPage.SetActive(false);
    }
}
