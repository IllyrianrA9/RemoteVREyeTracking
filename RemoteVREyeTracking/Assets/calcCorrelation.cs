using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;


public class calcCorrelation : MonoBehaviour
{
    //This objects will either get activated or deactivated regarding the chosen answer by the participant
    public GameObject removedGameObject1;
    public GameObject removedGameObject2;
    public GameObject removedGameObject3;
    public GameObject removedGameObject4;
    public GameObject activatedGameObject1;
    public GameObject activatedGameObject2;
    private GameObject proposedAnswer;

    //x and y coordinate of the answer
    double answerOne_x;
    double answerOne_y;

    double answerTwo_x;
    double answerTwo_y;

    double answerThree_x;
    double answerThree_y;

    //x and y coordinate of the eye gaze
    private float[] gaze_x;
    private float[] gaze_y;
    private float[] gaze_z;

    private GameObject focusedGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
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
            // The origin of the gaze ray is a 3D point
            var rayOrigin = eyeTrackingData.GazeRay.Origin;

            // The direction of the gaze ray is a normalized direction vector
            var rayDirection = eyeTrackingData.GazeRay.Direction;
        }

        // For social use cases, data in local space may be easier to work with
        var eyeTrackingDataLocal = TobiiXR.GetEyeTrackingData(TobiiXR_TrackingSpace.Local);

        // The EyeBlinking bool is true when the eye is closed
        var isLeftEyeBlinking = eyeTrackingDataLocal.IsLeftEyeBlinking;
        var isRightEyeBlinking = eyeTrackingDataLocal.IsRightEyeBlinking;

        // Using gaze direction in local space makes it easier to apply a local rotation
        // to your virtual eye balls.
        var eyesDirection = eyeTrackingDataLocal.GazeRay.Direction;

        
        
        //PUSH VALUE TO ARRAY TO THE LAST SPOT IN THE ARRAY

        //TODO resize arrays with new gaze points which get retrieved.
        Array.Resize(ref gaze_x, gaze_x.Length + 1);
        gaze_x[gaze_x.GetUpperBound(0)] = 0;

        Array.Resize(ref gaze_y, gaze_y.Length + 1);
        gaze_y[gaze_y.GetUpperBound(0)] = 0;

        Array.Resize(ref gaze_z, gaze_z.Length + 1);
        gaze_z[gaze_z.GetUpperBound(0)] = 0;

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
