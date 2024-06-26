using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.IO;
using UnityEngine.UI;

public class GetEyeGazeInformation : MonoBehaviour
{
    public DataMa dataMa;
    public GameObject circle;
    public float timeLeft = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (circle.activeSelf)
        {
            EyeGazeTxt1 egt = dataMa.eyeGazeData1;
            dataMa.eyeGazeData1.name = circle.name;
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                //Debug.Log("The name of the circle is " + dataMa.eyeGazeData1.name);
                dataMa.Save();
                timeLeft = 0.5f;
            }
        }
    }
}
