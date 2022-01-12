using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleAppearance : MonoBehaviour
{
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public GameObject circle4;
    public GameObject circle5;
    public GameObject circle6;
    public GameObject circle7;
    public GameObject circle8;
    public GameObject circle9;
    public GameObject circle10;
    public GameObject explanationText;
    public GameObject endExperiment;

    public float timeLeft = 3.0f;
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
        if (circle1.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if(timeLeft <= 0)
            {
                circle1.SetActive(false);
                timeLeft = 3.0f;
                circle2.SetActive(true);
            }
        }
        if (circle2.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle2.SetActive(false);
                timeLeft = 3.0f;
                circle3.SetActive(true);
            }
        }
        if (circle3.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle3.SetActive(false);
                timeLeft = 3.0f;
                circle4.SetActive(true);
            }
        }
        if (circle4.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle4.SetActive(false);
                timeLeft = 3.0f;
                circle5.SetActive(true);
            }
        }
        if (circle5.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle5.SetActive(false);
                timeLeft = 3.0f;
                circle6.SetActive(true);
            }
        }
        if (circle6.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle6.SetActive(false);
                timeLeft = 3.0f;
                circle7.SetActive(true);
            }
        }
        if (circle7.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle7.SetActive(false);
                timeLeft = 3.0f;
                circle8.SetActive(true);
            }
        }
        if (circle8.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle8.SetActive(false);
                timeLeft = 3.0f;
                circle9.SetActive(true);
            }
        }
        if (circle9.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle9.SetActive(false);
                timeLeft = 3.0f;
                circle10.SetActive(true);
            }
        }
        if (circle10.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                circle10.SetActive(false);
                explanationText.SetActive(false);
                endExperiment.SetActive(true);
            }
        }
    }
}