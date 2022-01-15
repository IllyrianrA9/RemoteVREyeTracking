using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;


public class calcCorrelation : MonoBehaviour
{
    //This objects will either get activated or deactivated regarding the chosen answer by the participant
    public GameObject question;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject activatedGameObject1;
    public GameObject activatedGameObject2;
    public GameObject proposedAnswer;


    //x, y and z coordinate of the answer
    private double _answerOne_x;
    private double _answerOne_y;
    private double _answerOne_z;

    private double _answerTwo_x;
    private double _answerTwo_y;
    private double _answerTwo_z;

    private double _answerThree_x;
    private double _answerThree_y;
    private double _answerThree_z;

    //Arrays of positions of the moving answers
    private double[] answerOne_x = new double[0]; 
    private double[] answerOne_y = new double[0];
    private double[] answerOne_z = new double[0];

    private double[] answerTwo_x = new double[0];
    private double[] answerTwo_y = new double[0];
    private double[] answerTwo_z = new double[0];

    private double[] answerThree_x = new double[0];
    private double[] answerThree_y = new double[0];
    private double[] answerThree_z = new double[0];


    //x, y and z coordinate of the eye gaze
    private double _gazeX;
    private double _gazeY;
    private double _gazeZ;

    //Arrays of positions of moving eye gaze
    private double[] gaze_x = new double[0];
    private double[] gaze_y = new double[0];
    private double[] gaze_z = new double[0];

    private GameObject focusedGameObject;
    private float ms = 0;
    private float time = 0;

    //waitTime in miliseconds
    public float waitTime = 5;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        GameObject desktop = null;
        RaycastHit hit;

        //This will be for the timestamps
        time += Time.deltaTime * 1000;

        //Miliseconds ms updated from start of this update which is used for clearing of arrays ONLY
        ms += Time.deltaTime * 1000;
       
        if(ms >= waitTime)
        {
            ms = 0;
            Debug.Log("5 miliseconds passed");
            Array.Clear(gaze_x, 0, gaze_x.Length);
            Array.Clear(gaze_y, 0, gaze_y.Length);
            Array.Clear(gaze_z, 0, gaze_z.Length);

            Array.Clear(answerOne_x, 0, answerOne_x.Length);
            Array.Clear(answerOne_y, 0, answerOne_y.Length);
            Array.Clear(answerOne_z, 0, answerOne_z.Length);

            Array.Clear(answerTwo_x, 0, answerTwo_x.Length);
            Array.Clear(answerTwo_y, 0, answerTwo_y.Length);
            Array.Clear(answerTwo_z, 0, answerTwo_z.Length);

            Array.Clear(answerThree_x, 0, answerThree_x.Length);
            Array.Clear(answerThree_y, 0, answerThree_y.Length);
            Array.Clear(answerThree_z, 0, answerThree_z.Length);

            Debug.Log("All arrays have been cleared");
        }

        // RECEIVE EYE TRACKING DATA!!
        // Get eye tracking data in world space
        var eyeTrackingData = TobiiXR.GetEyeTrackingData(TobiiXR_TrackingSpace.World);

        // Check if gaze ray is valid
        if (eyeTrackingData.GazeRay.IsValid)
        {
            Debug.Log("Eye gaze ray is valid");
            // The origin of the gaze ray is a 3D point
            var rayOrigin = eyeTrackingData.GazeRay.Origin;

            // The direction of the gaze ray is a normalized direction Vector3
            var rayDirection = eyeTrackingData.GazeRay.Direction;

            // For social use cases, data in local space may be easier to work with
            var eyeTrackingDataLocal = TobiiXR.GetEyeTrackingData(TobiiXR_TrackingSpace.Local);
            var rayOriginLocal = eyeTrackingDataLocal.GazeRay.Origin;
            var rayDirectionLocal = eyeTrackingDataLocal.GazeRay.Direction;

            //getting hit point of eye gaze on Background Screen
            if (Physics.Raycast(rayOrigin, rayDirection, out hit, Mathf.Infinity))
            {

                Debug.Log("Ray hit a collider ");
                desktop = hit.collider.gameObject;

                if (desktop.name == "BackgroundScreen")
                {
                    Debug.Log("Hit Background Screen");
                }
                //_gazeX = transform.InverseTransformPoint(hit.point).x;
                _gazeX = hit.point.x;
                Debug.Log("X Gaze " + _gazeX);

                //_gazeY = transform.InverseTransformPoint(hit.point).y;
                _gazeY = hit.point.y;
                Debug.Log("Y Gaze " + _gazeY);
                //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                _gazeZ = hit.point.z;
                Debug.Log("Z Gaze " + _gazeZ);
                Debug.Log("Eye gaze points X,Y,Z are saved");
                //}

                //Resize eye gaze arrays
                Array.Resize(ref gaze_x, gaze_x.Length + 1);
                gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;
                Debug.Log("Gaze X coordinates");
                // (var item in gaze_x)
                //{
                //    Debug.Log(item);
                //}

                Array.Resize(ref gaze_y, gaze_y.Length + 1);
                gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;
                Debug.Log("Gaze Y coordinates");


                Array.Resize(ref gaze_z, gaze_z.Length + 1);
                gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                Debug.Log("Gaze Z coordinates");


                Debug.Log("Gaze array is resized");
                //a = rayDirection.X;
            }
        }
      
        _answerOne_x = answer1.transform.position.x;
        _answerOne_y = answer1.transform.position.y;
        _answerOne_z = answer1.transform.position.z;
        Debug.Log("Anser X " + _answerOne_x);
        Debug.Log("Anser Y " + _answerOne_y);
        Debug.Log("Anser Z " + _answerOne_z);


        _answerTwo_x = answer2.transform.position.x;
        _answerTwo_y = answer2.transform.position.y;
        _answerTwo_z = answer2.transform.position.z;

        _answerThree_x = answer3.transform.position.x;
        _answerThree_y = answer3.transform.position.y;
        _answerThree_z = answer3.transform.position.z;
        Debug.Log("Positions of the answers X,Y,Z are saved in a variable");

        //PUSH VALUE TO ARRAY TO THE LAST SPOT IN THE ARRAY
        //resize arrays with new gaze points which get retrieved.

        //Resize answerOne array
        Array.Resize(ref answerOne_x, answerOne_x.Length + 1);
        answerOne_x[answerOne_x.GetUpperBound(0)] = _answerOne_x;
        Array.Resize(ref answerOne_y, answerOne_y.Length + 1);
        answerOne_y[answerOne_y.GetUpperBound(0)] = _answerOne_y;
        Array.Resize(ref answerOne_z, answerOne_z.Length + 1);
        answerOne_z[answerOne_z.GetUpperBound(0)] = _answerOne_z;


        Debug.Log("AnswerOne array is resized");

        //Resize answerTwo array
        Array.Resize(ref answerTwo_x, answerTwo_x.Length + 1);
        answerTwo_x[answerTwo_x.GetUpperBound(0)] = _answerTwo_x;
        Array.Resize(ref answerTwo_y, answerTwo_y.Length + 1);
        answerTwo_y[answerTwo_y.GetUpperBound(0)] = _answerTwo_y;
        Array.Resize(ref answerTwo_z, answerTwo_z.Length + 1);
        answerTwo_z[answerTwo_z.GetUpperBound(0)] = _answerTwo_z;


        Debug.Log("AnswerTwo array is resized");

        //Resize answerThree array
        Array.Resize(ref answerThree_x, answerThree_x.Length + 1);
        answerThree_x[answerThree_x.GetUpperBound(0)] = _answerThree_x;
        Array.Resize(ref answerThree_y, answerThree_y.Length + 1);
        answerThree_y[answerThree_y.GetUpperBound(0)] = _answerThree_y;
        Array.Resize(ref answerThree_z, answerThree_z.Length + 1);
        answerThree_z[answerThree_z.GetUpperBound(0)] = _answerThree_z;


        Debug.Log("AnswerThree array is resized");


        //Correlation between eye gaze and answer
        var corAnswer1X = Correlation2(gaze_x, answerOne_x);
        Debug.Log("X Correlation " + corAnswer1X);
        var corAnswer1Y = Correlation2(gaze_y, answerOne_y);
        Debug.Log("Y Correlation " + corAnswer1Y);
        var corAnswer1Z = Correlation2(gaze_z, answerOne_z);
        Debug.Log("Z Correlation " + corAnswer1Z);

        var corAnswer2X = Correlation2(gaze_x, answerTwo_x);
        var corAnswer2Y = Correlation2(gaze_y, answerTwo_y);
        var corAnswer2Z = Correlation2(gaze_z, answerTwo_z);

        Debug.Log("Correlation of AnswerTwo and Gaze is done");

        var corAnswer3X = Correlation2(gaze_x, answerThree_x);
        var corAnswer3Y = Correlation2(gaze_y, answerThree_y);
        var corAnswer3Z = Correlation2(gaze_z, answerThree_z);

        Debug.Log("Correlation of AnswerThree and Gaze is done");

        //Correlation to the answers 
        var corAnswer1 = corAnswer1X + corAnswer1Y + corAnswer1Z;
        Debug.Log("Correlation of Answer 1 is: " + corAnswer1);
        var corAnswer2 = corAnswer2X + corAnswer2Y + corAnswer2Z;
        Debug.Log("Correlation of Answer 2 is: " + corAnswer2);
        var corAnswer3 = corAnswer3X + corAnswer3Y + corAnswer3Z;
        Debug.Log("Correlation of Answer 3 is: " + corAnswer3);

        if ((corAnswer1 >= 2.1) && (corAnswer1 > corAnswer2) && (corAnswer1 > corAnswer3))
        {
            Debug.Log("Answer 1 got chosen");
            question.SetActive(false);
            answer1.SetActive(false);
            answer2.SetActive(false);
            answer3.SetActive(false);
            activatedGameObject1.SetActive(true);
            activatedGameObject2.SetActive(true);
            proposedAnswer.SetActive(true);
        }
    }




    public double Correlation(double[] array1, double[] array2)
    {
        double[] array_xy = new double[array1.Length];
        double[] array_xp2 = new double[array1.Length];
        double[] array_yp2 = new double[array1.Length];
        
        for (int i = 0; i < array1.Length; i++)
            array_xy[i] = array1[i] * array2[i];
        
        for (int i = 0; i < array1.Length; i++)
            array_xp2[i] = Math.Pow(array1[i], 2.0);
        
        for (int i = 0; i < array1.Length; i++)
            array_yp2[i] = Math.Pow(array2[i], 2.0);
        double sum_x = 0;
        double sum_y = 0;
        foreach (double n in array1)
            sum_x += n;
        foreach (double n in array2)
            sum_y += n;
        double sum_xy = 0;
        foreach (double n in array_xy)
            sum_xy += n;
        double sum_xpow2 = 0;
        foreach (double n in array_xp2)
            sum_xpow2 += n;
        double sum_ypow2 = 0;
        foreach (double n in array_yp2)
            sum_ypow2 += n;
        double Ex2 = Math.Pow(sum_x, 2.00);
        double Ey2 = Math.Pow(sum_y, 2.00);

        return (array1.Length * sum_xy - sum_x * sum_y) /
               Math.Sqrt((array1.Length * sum_xpow2 - Ex2) * (array1.Length * sum_ypow2 - Ey2));
    }

    public double Correlation2(double[] array1, double[] array2)
    {
        double[] array_xy = new double[array1.Length];
        double[] array_xp2 = new double[array1.Length];
        double[] array_yp2 = new double[array1.Length];
        for (int i = 0; i < array1.Length; i++)
            array_xy[i] = array1[i] * array2[i];
        for (int i = 0; i < array1.Length; i++)
            array_xp2[i] = Math.Pow(array1[i], 2.0);
        for (int i = 0; i < array1.Length; i++)
            array_yp2[i] = Math.Pow(array2[i], 2.0);
        double sum_x = 0;
        double sum_y = 0;
        foreach (double n in array1)
            sum_x += n;
        foreach (double n in array2)
            sum_y += n;
        double sum_xy = 0;
        foreach (double n in array_xy)
            sum_xy += n;
        double sum_xpow2 = 0;
        foreach (double n in array_xp2)
            sum_xpow2 += n;
        double sum_ypow2 = 0;
        foreach (double n in array_yp2)
            sum_ypow2 += n;
        double Ex2 = Math.Pow(sum_x, 2.00);
        double Ey2 = Math.Pow(sum_y, 2.00);

        return (array1.Length * sum_xy - sum_x * sum_y) /
               Math.Sqrt((array1.Length * sum_xpow2 - Ex2) * (array1.Length * sum_ypow2 - Ey2));
    }
}
