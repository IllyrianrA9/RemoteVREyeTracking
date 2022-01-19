using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;
using Random = UnityEngine.Random;


public class AccuracyCheck : MonoBehaviour
{
    //This objects will either get activated or deactivated regarding the chosen answer by the participant

    public GameObject endExperimentText;
    public GameObject[] listOfCircles;
    public List<GameObject> listOfCircles2;
    public List<GameObject> blackCircles;
    public GameObject accuracyTest;

    //x, y and z coordinate of the circle
    private double circleX;
    private double circleY;
    private double circleZ;

    double meanX;
    double meanY;
    double meanZ;

    //x, y and z coordinate of the eye gaze
    private double _gazeX;
    private double _gazeY;
    private double _gazeZ;

    //Arrays of positions of moving eye gaze
    private double[] gaze_x = new double[0];
    private double[] gaze_y = new double[0];
    private double[] gaze_z = new double[0];

    private GameObject focusedGameObject;
    private float msShowCircle = 0;
    private float timeStamps = 0;
    int current = 0;
    int counter = 0;

    //waitTime in miliseconds
    //public float showCircle = 2000;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        msShowCircle += Time.deltaTime * 1000;
        if ((msShowCircle >= 2000) && (msShowCircle < 4000))
        {
            if (msShowCircle >= 2000 && counter == 0)
            {
                current = Random.Range(0, 8);
                listOfCircles2[current].SetActive(true);

            
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }
        }
    
        if (msShowCircle >= 4000 && counter == 1)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            listOfCircles2[current].SetActive(false);
            
            listOfCircles2.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
        }


        if (msShowCircle >= 4000 && msShowCircle < 6000)
        {
            if (msShowCircle >= 4000 && counter == 1)
            {
                current = Random.Range(0, 7);
                //listOfCircles[current].SetActive(true);
                listOfCircles2[current].SetActive(true);

                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }


            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }


        if (msShowCircle >= 6000 && counter == 2 )
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            listOfCircles2[current].SetActive(false);

            //RemoveAt(listOfCircles, current);
            listOfCircles2.RemoveAt(current);
        }


        if (msShowCircle >= 6000 && msShowCircle < 8000)
        {
            if (msShowCircle >= 6000 && counter == 2)
            {
                current = Random.Range(0, 6);
                //listOfCircles[current].SetActive(true);
                listOfCircles2[current].SetActive(true);


                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }

        if (msShowCircle >= 8000 && counter== 3)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            listOfCircles2[current].SetActive(false);

            //RemoveAt(listOfCircles, current);
            listOfCircles2.RemoveAt(current);
        }


        if (msShowCircle >= 8000 && msShowCircle < 10000)
        {
            if (msShowCircle >= 8000 && counter ==3)
            {
                current = Random.Range(0, 5);
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;

                listOfCircles2[current].SetActive(true);
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }

        if (msShowCircle >= 10000 && counter == 4)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);

            listOfCircles2[current].SetActive(false);
            listOfCircles2.RemoveAt(current);
        }


        if (msShowCircle >= 10000 && msShowCircle < 12000)
        {
            if (msShowCircle >= 10000 && counter ==4)
            {
                current = Random.Range(0, 4);
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;

                listOfCircles2[current].SetActive(true);
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;

                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }

        if (msShowCircle >= 12000 && counter == 5)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);

            listOfCircles2[current].SetActive(false);
            listOfCircles2.RemoveAt(current);
        }


        if (msShowCircle >= 12000 && msShowCircle < 14000)
        {
            if (msShowCircle >= 12000 && counter ==5)
            {
                current = Random.Range(0, 3);
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;


                listOfCircles2[current].SetActive(true);
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }

        if (msShowCircle >= 14000 && counter ==6)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);

            listOfCircles2[current].SetActive(false);
            listOfCircles2.RemoveAt(current);
        }


        if (msShowCircle >= 14000 && msShowCircle < 16000)
        {
            if (msShowCircle >= 14000 && counter == 6)
            {
                //current = Random.Range(0, listOfCircles.Length - 1);
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;


                current = Random.Range(0,2);
                listOfCircles2[current].SetActive(true);
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }

        if (msShowCircle >= 16000 && counter == 7)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);

            listOfCircles2[current].SetActive(false);
            listOfCircles2.RemoveAt(current);
        }


        if (msShowCircle >= 16000 && msShowCircle < 18000)
        {
            if (msShowCircle >= 16000 &&  counter == 7)
            {
                //current = Random.Range(0, listOfCircles.Length - 1);
                //Debug.Log("Current" + current);
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;

                current = Random.Range(0, 1);
                Debug.Log("Current" + current);
                listOfCircles2[current].SetActive(true);
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }

        if (msShowCircle >= 18000 && counter == 8)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);

            listOfCircles2[current].SetActive(false);
            listOfCircles2.RemoveAt(current);
        }

        if (msShowCircle >= 18000 && msShowCircle < 20000)
        {
            if (msShowCircle  >= 18000 && counter == 8)
            {
                current = 0;
                foreach(GameObject game in listOfCircles2)
                {

                    Debug.Log("Name: " + game.name);
                }
                Debug.Log("Current" + current);
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;

                listOfCircles2[current].SetActive(true);
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                counter += 1;
                Debug.Log("Counter" + counter);
            }



            GameObject desktop = null;
            RaycastHit hit;

            //This will be for the timestamps
            timeStamps += Time.deltaTime * 1000;



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

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                    Debug.Log("Gaze Z coordinates");
                    Debug.Log("Gaze array is resized");
                }
            }

        }

        if (msShowCircle >= 20000 && counter ==9)
        {
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);

            listOfCircles2[current].SetActive(false);
            listOfCircles2.RemoveAt(current);
            accuracyTest.SetActive(false);
            endExperimentText.SetActive(true);
            Debug.Log("Das spiel lebt");
        }
    }







    private double meanofArray(double[] array)
    {
        double sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        double mean = sum / array.Length;
        return mean;
    }

    private void RemoveAt(GameObject[] arr, int index)
    {
        for(int a = index; a < arr.Length - 1; a++)
        {
            // moving elements downwards, to fill the gap at [index]
            arr[a] = arr[a + 1];
        }
        // finally, let's decrement Array's size by one
        Array.Resize(ref arr, arr.Length - 1);
    }
}