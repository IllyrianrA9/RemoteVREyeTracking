using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;


public class accuracyAndPrecision : MonoBehaviour
{
    //This objects will either get activated or deactivated regarding the chosen answer by the participant
    public GameObject question;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject activatedGameObject1;
    public GameObject activatedGameObject2;
    public GameObject proposedAnswer1;
    public GameObject proposedAnswer2;
    public GameObject proposedAnswer3;


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
    private float timeStamps = 0;

    //waitTime in miliseconds
    public float waitTime = 500;

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
        timeStamps += Time.deltaTime * 1000;

        //Miliseconds ms updated from start of this update which is used for clearing of arrays ONLY
        ms += Time.deltaTime * 1000;



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

                Debug.Log(hit.transform.name);
                desktop = hit.collider.gameObject;

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
                //foreach( var item in gaze_y)
                //{
                //    Debug.Log("Value of Array: " + item);
                //}


                Array.Resize(ref gaze_z, gaze_z.Length + 1);
                gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                Debug.Log("Gaze Z coordinates");


                Debug.Log("Gaze array is resized");
                //a = rayDirection.X;

            }
        }
    }
}