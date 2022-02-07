using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;
using Random = UnityEngine.Random;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine.UI;



public class AccuracyCheck : MonoBehaviour
{
    public GameObject canvasForPartID;
    private int participantNumberReal;

    public string file = "Accuracy";
    StringBuilder sb = new StringBuilder("Participant ID, Time, Circle ID, Circle posiion X, Circle position Y, Circle position Z, Gaze position X, Gaze position Y, Gaze position Z, Mean X, Mean Y, MeanZ, Offset, SDPrecision, Validity");
    private float timeForCSV = 0;
    private float offSetGazeToObject;
    private double sdPrecision;
    private string circleID;
    private string csvDocumentation;
    public GameObject participant;
    private string participantID;
    //This objects will either get activated or deactivated regarding the chosen answer by the participant

    public GameObject endExperimentText;
    public GameObject startPostStudy;
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

    //Boolean to enable accuracy and precision calculation (only calculate once)
    private bool isCalculatedCircle1 = false;
    private bool isCalculatedCircle2 = false;
    private bool isCalculatedCircle3 = false;
    private bool isCalculatedCircle4 = false;
    private bool isCalculatedCircle5 = false;
    private bool isCalculatedCircle6 = false;
    private bool isCalculatedCircle7 = false;
    private bool isCalculatedCircle8 = false;
    private bool isCalculatedCircle9 = false;


    private bool isValidOrNotCircle1 = false;
    private bool isValidOrNotCircle2 = false;
    private bool isValidOrNotCircle3 = false;
    private bool isValidOrNotCircle4 = false;
    private bool isValidOrNotCircle5 = false;
    private bool isValidOrNotCircle6 = false;
    private bool isValidOrNotCircle7 = false;
    private bool isValidOrNotCircle8 = false;
    private bool isValidOrNotCircle9 = false;

    Vector3 blackPosition;

    private string validity;
    private double validData; 

    //Counter to see how many eye gaze samples are valid or not
    int validGazeData = 0;
    int invalidGazeData = 0;

    private bool partTrueID = true;
    //waitTime in miliseconds
    //public float showCircle = 2000;

    // Start is called before the first frame update
    void Start()
    {
        participantID = participant.GetComponent<Text>().text;
        if (partTrueID)
        {
            participantNumberReal = canvasForPartID.GetComponent<ManageParticipantID>().participantNumber;
            participantID = participant.GetComponent<Text>().text;
            file = file + participantNumberReal + ".txt";
            partTrueID = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        timeForCSV += Time.deltaTime * 1000;
        msShowCircle += Time.deltaTime * 1000;
        if ((msShowCircle >= 2000) && (msShowCircle < 4000))
        {
            if (msShowCircle >= 2000 && counter == 0)
            {
                current = Random.Range(0, 8);
                listOfCircles2[current].SetActive(true);
                circleID = listOfCircles2[current].name;

            
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
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

                   
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
              

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                   
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                    
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if(msShowCircle >= 2800 && msShowCircle <= 3800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                       
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 2800 && msShowCircle <= 3800)
            {
                invalidGazeData += 1;
            }
            if(invalidGazeData != 0 && validGazeData != 0  && msShowCircle > 3800 && isValidOrNotCircle1 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle1 = true;
            }
            if(validGazeData == 0 && msShowCircle > 3800 && isValidOrNotCircle1 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle1 = true;
            }
            if(invalidGazeData == 0 && msShowCircle > 3800 && isValidOrNotCircle1 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle1 = true;
            }
        }
    
        if (msShowCircle >= 3800 && counter == 1 && isCalculatedCircle1 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
            


            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));

            if(sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }
            //SaveToFileUsingMean();
            csvDocumentation = ToCSVusingOffsetsSDP(sb,participantID,  timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            isCalculatedCircle1 = true;
        }
        if(msShowCircle >= 4000 && counter == 1)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];
           

        }


        if (msShowCircle >= 4000 && msShowCircle < 6000)
        {
            if (msShowCircle >= 4000 && counter == 1)
            {
                current = Random.Range(0, 7);
                //listOfCircles[current].SetActive(true);
                listOfCircles2[current].SetActive(true);
                circleID = listOfCircles2[current].name;

                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
                
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

                   
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                   

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                   
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                    
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 4800 && msShowCircle <= 5800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                        
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 4800 && msShowCircle <= 5800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0 && msShowCircle > 5800 && isValidOrNotCircle2 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle2 = true;
            }
            if (validGazeData == 0 && msShowCircle > 5800 && isValidOrNotCircle2 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle2 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 5800 && isValidOrNotCircle2 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle2 = true;
            }

        }


        if (msShowCircle >= 5800 && counter == 2 && isCalculatedCircle2 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
            


            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));

            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb, participantID,  timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            isCalculatedCircle2 = true;
        }
        if (msShowCircle >= 6000 && counter == 2)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];
           

        }


        if (msShowCircle >= 6000 && msShowCircle < 8000)
        {
            if (msShowCircle >= 6000 && counter == 2)
            {
                current = Random.Range(0, 6);
                //listOfCircles[current].SetActive(true);
                listOfCircles2[current].SetActive(true);
                circleID = listOfCircles2[current].name;

                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
               
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

                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                  

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                  
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                   
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 6800 && msShowCircle <= 7800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                        
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb,participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 6800 && msShowCircle <= 7800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0 && msShowCircle > 7800 &&isValidOrNotCircle3 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle3 = true;
            }
            if (validGazeData == 0 && msShowCircle > 7800 && isValidOrNotCircle3 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle3 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 7800 && isValidOrNotCircle3 == false)
            {
                validData = 1;
                invalidGazeData = 0;
                validGazeData = 0;
                isValidOrNotCircle3 = true;
            }

        }

        if (msShowCircle >= 7800 && counter== 3 && isCalculatedCircle3 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
           


            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));

            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            isCalculatedCircle3 = true;

        }
        if (msShowCircle >= 8000 && counter == 3)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];
            

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
                circleID = listOfCircles2[current].name;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
                
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

                   
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                   
                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                    
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                  
                    //}


                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 8800 && msShowCircle <= 9800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                       
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 8800 && msShowCircle <= 9800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0 && msShowCircle > 9800 && isValidOrNotCircle4 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle4 = true;
            }
            if (validGazeData == 0 && msShowCircle > 9800 && isValidOrNotCircle4 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle4 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 9800 && isValidOrNotCircle4 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle4 = true;
            }

        }

        if (msShowCircle >= 9800 && counter == 4 && isCalculatedCircle4 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
            

            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));

            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);
            isCalculatedCircle4 = true;

        }
        if (msShowCircle >= 10000 && counter == 4)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];

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
                circleID = listOfCircles2[current].name;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;

                counter += 1;
               
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

                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                   

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                    
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                  
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 10800 && msShowCircle <= 11800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                       
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 10800 && msShowCircle <= 11800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0 && msShowCircle > 11800 && isValidOrNotCircle5 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle5 = true;
            }

            if (validGazeData == 0 && msShowCircle > 11800 && isValidOrNotCircle5 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle5 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 11800 && isValidOrNotCircle5 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle5 = true;
            }

        }

        if (msShowCircle >= 11800 && counter == 5 && isCalculatedCircle5 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
           


            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));
            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb,participantID,  timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
          
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);
            isCalculatedCircle5 = true;
        }

        if (msShowCircle >= 12000 && counter == 5)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];
           
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
                circleID = listOfCircles2[current].name;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
                
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

                  
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                   

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                    
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                    
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 12800 && msShowCircle <= 13800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                       
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 12800 && msShowCircle <= 13800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0 && msShowCircle > 13800 && isValidOrNotCircle6 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle6 = true;
            }
            if (validGazeData == 0 && msShowCircle > 13800 && isValidOrNotCircle6 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle6 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 13800 && isValidOrNotCircle6 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle6 = true;
            }

        }

        if (msShowCircle >= 13800 && counter ==6 && isCalculatedCircle6 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
           


            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));

            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb,participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);
            isCalculatedCircle6 = true;

        }
        if (msShowCircle >= 14000 && counter == 6)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];
            

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
                circleID = listOfCircles2[current].name;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
               
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

                   
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                  

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                   
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                 
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 14800 && msShowCircle <= 15800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                        
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 14800 && msShowCircle <= 15800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0  && msShowCircle > 15800 && isValidOrNotCircle7 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle7 = true;
            }
            if (validGazeData == 0 && msShowCircle > 15800 && isValidOrNotCircle7 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle7 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 15800 && isValidOrNotCircle7 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle7 = true;
            }

        }

        if (msShowCircle >= 15800 && counter == 7 && isCalculatedCircle7 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
            


            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));

            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb,participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);
            isCalculatedCircle7 = true;

        }

        if (msShowCircle >=16000 && counter == 7)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];

        }


        if (msShowCircle >= 16000 && msShowCircle < 18000)
        {
            if (msShowCircle >= 16000 &&  counter == 7)
            {
                //current = Random.Range(0, listOfCircles.Length - 1);
              
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;

                current = Random.Range(0, 1);
               
                listOfCircles2[current].SetActive(true);
                circleID = listOfCircles2[current].name;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
               
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

                
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                   

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                  
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                  
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 16800 && msShowCircle <= 17800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                       
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }
            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 16800 && msShowCircle <= 17800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0 && msShowCircle > 17800 && isValidOrNotCircle8 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData);
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle8 = true;
            }
            if (validGazeData == 0 && msShowCircle > 17800 && isValidOrNotCircle8 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle8 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 17800 && isValidOrNotCircle8 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle8 = true;
            }

        }

        if (msShowCircle >= 17800 && counter == 8 && isCalculatedCircle8 == false)
        {
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            
            meanY = meanofArray(gaze_y);
           
            meanZ = meanofArray(gaze_z);
           
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
            


            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));


            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb,participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);
            isCalculatedCircle8 = true;

        }

        if (msShowCircle >= 18000 && counter == 8)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];

        }

        if (msShowCircle >= 18000 && msShowCircle < 20000)
        {
            if (msShowCircle  >= 18000 && counter == 8)
            {
                current = 0;
                
                //listOfCircles[current].SetActive(true);
                //circleX = listOfCircles[current].transform.position.x;
                //circleY = listOfCircles[current].transform.position.y;
                //circleZ = listOfCircles[current].transform.position.z;

                listOfCircles2[current].SetActive(true);
                circleID = listOfCircles2[current].name;
                circleX = blackCircles[current].transform.position.x;
                circleY = blackCircles[current].transform.position.y;
                circleZ = blackCircles[current].transform.position.z;
                blackPosition = blackCircles[current].transform.position;
                counter += 1;
                
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

                  
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                    

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                   
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                    
                    //}

                    //Prerequisite 1: Collect data between 800-1800 ms so user can move his eyes
                    if (msShowCircle >= 18800 && msShowCircle <= 19800)
                    {
                        validGazeData += 1;
                        //Resize eye gaze arrays
                        Array.Resize(ref gaze_x, gaze_x.Length + 1);
                        gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;

                        Array.Resize(ref gaze_y, gaze_y.Length + 1);
                        gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;

                        Array.Resize(ref gaze_z, gaze_z.Length + 1);
                        gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                        
                        //SaveToFileNotUsingMean();
                        csvDocumentation = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
                    }
                }
            }

            //Prerequisite 0: 80% of data should be valid for analysis
            if (!(eyeTrackingData.GazeRay.IsValid) && msShowCircle >= 18800 && msShowCircle <= 19800)
            {
                invalidGazeData += 1;
            }
            if (invalidGazeData != 0 && validGazeData != 0 && msShowCircle > 19800 && isValidOrNotCircle9 == false)
            {
                validData = 1 - (invalidGazeData / validGazeData); ;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle9 = true;
            }
            if (validGazeData == 0 && msShowCircle > 19800 && isValidOrNotCircle9 == false)
            {
                validData = 0;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle9 = true;
            }
            if (invalidGazeData == 0 && msShowCircle > 19800 && isValidOrNotCircle9 == false)
            {
                validData = 1;
                validGazeData = 0;
                invalidGazeData = 0;
                isValidOrNotCircle9 = true;
            }

        }

        if (msShowCircle >= 19800 && counter ==9 && isCalculatedCircle9 == false)
        {
            
            //Prerequisite 2: Mean of Gaze (soll nicht größer 5% sein)
            meanX = meanofArray(gaze_x);
            meanY = meanofArray(gaze_y);
            meanZ = meanofArray(gaze_z);
            Vector3 gazeVector = new Vector3((float)meanX, (float)meanY, (float)meanZ);
            offSetGazeToObject = Vector3.Distance(blackPosition, gazeVector);
           

            //Prerequisite 3: SD Precision (soll nicht größer 1.5% sein)
            double stdGazeX = standardDeviation(gaze_x);
            double stdGazeY = standardDeviation(gaze_y);
            double stdGazeZ = standardDeviation(gaze_z);
            sdPrecision = Math.Sqrt(Math.Pow(stdGazeX, 2) + Math.Pow(stdGazeY, 2) + Math.Pow(stdGazeZ, 2));


            if (sdPrecision < 1 && validData > 0.8)
            {
                validity = "Valid";
            }

            if (sdPrecision > 1 || validData < 0.8)
            {
                validity = "Invalid";
            }

            csvDocumentation = ToCSVusingOffsetsSDP(sb,participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
            //double distance = Math.Sqrt(Math.Pow(meanX, 2) + Math.Pow(meanY, 2) + Math.Pow(meanZ, 2));
            //listOfCircles[current].SetActive(false);
            //RemoveAt(listOfCircles, current);
            isCalculatedCircle9 = true;


         
        }
        if (msShowCircle >= 20000 && counter == 9)
        {
            listOfCircles2[current].SetActive(false);

            listOfCircles2.RemoveAt(current);
            blackCircles.RemoveAt(current);
            //RemoveAt(listOfCircles, current);
            gaze_x = new double[0];
            gaze_y = new double[0];
            gaze_z = new double[0];
            SaveFile();
            accuracyTest.SetActive(false);
            endExperimentText.SetActive(true);
            startPostStudy.SetActive(true);

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

    private double standardDeviation(IEnumerable<double> sequence)
    {
        double result = 0;

        if (sequence.Any())
        {
            double average = sequence.Average();
            double sum = sequence.Sum(d => Math.Pow(d - average, 2));
            result = Math.Sqrt((sum) / (sequence.Count() - 1));
        }
        return result;
    }

    public string ToCSVusingOffsetsSDP(StringBuilder sb, string partID, float time, string circleID, double objX, double objY, double objZ , double gazeX, double gazeY, double gazeZ, double meanX, double meanY, double meanZ, float offset, double sdP, string validity)
    {
        //var sb = new StringBuilder("Difficulty , Wrong answer, More instruction, Distraction overall, Distraction on screen, VR camera");
        sb.Append('\n').Append(partID.ToString()).Append(", ").Append(time.ToString()).Append(", ").Append(circleID.ToString()).Append(", ").Append(objX.ToString()).Append(", ").Append(objY.ToString()).Append(", ").Append(objZ.ToString()).Append(", ").Append(gazeX.ToString()).Append(", ").Append(gazeY.ToString()).Append(", ").Append(gazeZ.ToString()).Append(", ").Append(meanX.ToString()).Append(", ").Append(meanY.ToString()).Append(", ").Append(meanZ.ToString()).Append(", ").Append(offset.ToString()).Append(", ").Append(sdP.ToString()).Append(", ").Append(validity.ToString());
        return sb.ToString();

    }
    public string ToCSVNoOffsetSDP(StringBuilder sb, string partID, float time, string circleID, double objX, double objY, double objZ, double gazeX, double gazeY, double gazeZ)
    {
        //var sb = new StringBuilder("Difficulty , Wrong answer, More instruction, Distraction overall, Distraction on screen, VR camera");
        sb.Append('\n').Append(partID.ToString()).Append(", ").Append(time.ToString()).Append(", ").Append(circleID.ToString()).Append(", ").Append(objX.ToString()).Append(", ").Append(objY.ToString()).Append(", ").Append(objZ.ToString()).Append(", ").Append(gazeX.ToString()).Append(", ").Append(gazeY.ToString()).Append(", ").Append(gazeZ.ToString());
        return sb.ToString();

    }

    public void SaveToFileUsingMean()
    {
        var content = ToCSVusingOffsetsSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ, meanX, meanY, meanZ, offSetGazeToObject, sdPrecision, validity);
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
            
        }

    }

    public void SaveFile()
    {
        var content = csvDocumentation;
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(csvDocumentation);

        }

    }

    public void SaveToFileNotUsingMean()
    {
        var content = ToCSVNoOffsetSDP(sb, participantID, timeForCSV, circleID, circleX, circleY, circleZ, _gazeX, _gazeY, _gazeZ);
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
        }

    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}