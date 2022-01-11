using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.XR;
using Tobii.G2OM;

public class AccuracyCheck : MonoBehaviour, IGazeFocusable
{

    public GameObject removedGameObject1;
    public GameObject otherCircle1;
    public GameObject otherCircle2;
    public GameObject otherCircle3;
    public GameObject otherCircle4;
    public GameObject endExperiment;


    public float timeLeft = 7.0f;
    private bool _hasFocus;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void GazeFocusChanged(bool hasFocus)
    {
        _hasFocus = hasFocus;
    }

    // Update is called once per frame
    void Update()
    {
        //While this object has focus, start the counter
        if (_hasFocus)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                removedGameObject1.SetActive(false);
            }

            if(otherCircle1.activeSelf == false && otherCircle2.activeSelf == false && otherCircle3.activeSelf == false && otherCircle4.activeSelf == false && removedGameObject1.activeSelf == false)
            {
                endExperiment.SetActive(true);
            }
        }
    }
}
