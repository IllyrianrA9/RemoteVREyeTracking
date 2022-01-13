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
    private GameObject proposedAnswer;


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

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        GameObject desktop = null;
        RaycastHit hit;





        //RETRIEVE CURRENT FOCUSED OBJECT EVERY FRAME!!
        // Check whether TobiiXR has any focused objects.
        if (TobiiXR.FocusedObjects.Count > 0)
        {
            focusedGameObject = TobiiXR.FocusedObjects[0].GameObject;
            // TODO: Do something with the focused game object
            
            
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

            //getting hit point of eye gaze on canvas
            if(Physics.Raycast(rayOrigin, rayDirection, out hit, Mathf.Infinity))
            {
                Debug.Log("Ray hit a collider ");
                desktop = hit.collider.gameObject;
                if(desktop.name == "BackgroundScreen")
                {
                    Debug.Log("The name of the hit object is BackgroundScreen");
                    _gazeX = hit.point.x;
                    _gazeY = hit.point.y;
                    _gazeZ = hit.point.z;
                    Debug.Log("Eye gaze points X,Y,Z are saved");
                }
            }
            //Resize eye gaze arrays
            Array.Resize(ref gaze_x, gaze_x.Length + 1);
            gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

            Array.Resize(ref gaze_y, gaze_y.Length + 1);
            gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

            Array.Resize(ref gaze_z, gaze_z.Length + 1);
            gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;

            Debug.Log("Gaze array is resized");
            //a = rayDirection.X;

            // For social use cases, data in local space may be easier to work with
            var eyeTrackingDataLocal = TobiiXR.GetEyeTrackingData(TobiiXR_TrackingSpace.Local);

            // The EyeBlinking bool is true when the eye is closed
            var isLeftEyeBlinking = eyeTrackingDataLocal.IsLeftEyeBlinking;
            var isRightEyeBlinking = eyeTrackingDataLocal.IsRightEyeBlinking;

            // Using gaze direction in local space makes it easier to apply a local rotation
            // to your virtual eye balls.
            var eyesDirection = eyeTrackingDataLocal.GazeRay.Direction;
        }
        _answerOne_x = answer1.transform.position.x;
        _answerOne_y = answer1.transform.position.y;
        _answerOne_z = answer1.transform.position.z;

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
        Correlation(gaze_x, answerOne_x);
        Correlation(gaze_y, answerOne_y);
        Correlation(gaze_z, answerOne_z);
        Debug.Log("Correlation of AnswerOne and Gaze is done");

        Correlation(gaze_x, answerTwo_x);
        Correlation(gaze_y, answerTwo_y);
        Correlation(gaze_z, answerTwo_z);

        Debug.Log("Correlation of AnswerTwo and Gaze is done");

        Correlation(gaze_x, answerThree_x);
        Correlation(gaze_y, answerThree_y);
        Correlation(gaze_z, answerThree_z);

        Debug.Log("Correlation of AnswerThree and Gaze is done");
        //TODO ADD CORRELATION AND COMPARE AND GIVE NEW VALUE WHICH HAS TO BE ACHIEVED AS A MINIMUM TO ANSWER 

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
}
