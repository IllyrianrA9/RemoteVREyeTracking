using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;
using System.Text;
using System.IO;
using UnityEngine.UI;


public class calcCorrelation : MonoBehaviour
{
    public DataMa dataMa;

    public GameObject participant;
    public GameObject canvasForPartID;
    private int participantNumberReal;
    public string file = "Quiz";
    public string csvDocumentation;
    public StringBuilder sb = new StringBuilder("Participant ID, Time, Question ID, Answer 1 position X, Answer 1 position Y, Answer 1 position Z, Answer 2 position X, Answer 2 position Y, Answer 2 Position Z, Answer 3 position X, Answer 3 position Y, Answer 3 Position Z, Gaze position X, Gaze position Y, Gaze position Z, Correlation 1, Correlation 2, Correlation 3, Chosen Answer, Amount of Undo");
    private string participantID;
    public float timeForCSV = 0;
    public GameObject previousUndo;
    public int undoAmount = 0;

    public GameObject undoScreen;
    //This objects will either get activated or deactivated regarding the chosen answer by the participant
    public GameObject question;
    private string questionID;
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

    private double corAnswer1;
    private double corAnswer2;
    private double corAnswer3;

    private GameObject focusedGameObject;
    private float ms = 0;
    private float timeStamps = 0;

    //waitTime in miliseconds
    public float waitTime = 500;

    //boolean , which shows if we reached the given ms the first time
    private bool hitGivenMS = false;
    private bool partTrueID = true;
    // Start is called before the first frame update
    void Start()
    {
        if (partTrueID)
        {
            participantNumberReal = canvasForPartID.GetComponent<ManageParticipantID>().participantNumber;
            participantID = participant.GetComponent<Text>().text;
            file = file + participantNumberReal + ".txt";
            partTrueID = false;
        }
        
        questionID = question.GetComponent<Text>().text;
        if(question.name != "Question10")
        {
            if (undoScreen.GetComponent<UndoGaze>().timeForCSV > timeForCSV)
            {
                timeForCSV = undoScreen.GetComponent<UndoGaze>().timeForCSV;
                csvDocumentation = undoScreen.GetComponent<UndoGaze>().csvDocumentation;
                sb = undoScreen.GetComponent<UndoGaze>().sb;
                undoAmount = undoScreen.GetComponent<UndoGaze>().undoAmount;
            }
        }
            
        if(question.name != "Question1")
        {
            if (previousUndo.GetComponent<UndoGaze>().timeForCSV > timeForCSV)
            {
                timeForCSV = previousUndo.GetComponent<UndoGaze>().timeForCSV;
                csvDocumentation = previousUndo.GetComponent<UndoGaze>().csvDocumentation;
                sb = previousUndo.GetComponent<UndoGaze>().sb;
                undoAmount = previousUndo.GetComponent<UndoGaze>().undoAmount;
            }
        }
        if(question.name == "Question10")
        {
            if (undoScreen.GetComponent<UndoGaze10>().timeForCSV > timeForCSV)
            {
                timeForCSV = undoScreen.GetComponent<UndoGaze>().timeForCSV;
                csvDocumentation = undoScreen.GetComponent<UndoGaze>().csvDocumentation;
                sb = undoScreen.GetComponent<UndoGaze>().sb;
                undoAmount = undoScreen.GetComponent<UndoGaze>().undoAmount;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        timeForCSV += Time.deltaTime * 1000;
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
                if (hitGivenMS == false)
                {
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                    //}

                    //Resize eye gaze arrays
                    Array.Resize(ref gaze_x, gaze_x.Length + 1);
                    gaze_x[gaze_x.GetUpperBound(0)] = _gazeX;
                    
                    //foreach (var item in gaze_x)
                    //{
                    //    Debug.Log(item);
                    //}

                    Array.Resize(ref gaze_y, gaze_y.Length + 1);
                    gaze_y[gaze_y.GetUpperBound(0)] = _gazeY;
                    
                    //foreach( var item in gaze_y)
                    //{
                    //    Debug.Log("Value of Array: " + item);
                    //}


                    Array.Resize(ref gaze_z, gaze_z.Length + 1);
                    gaze_z[gaze_z.GetUpperBound(0)] = _gazeZ;
                   


                    
                    //a = rayDirection.X;

                    _answerOne_x = answer1.transform.position.x;
                    _answerOne_y = answer1.transform.position.y;
                    _answerOne_z = answer1.transform.position.z;
                    


                    _answerTwo_x = answer2.transform.position.x;
                    _answerTwo_y = answer2.transform.position.y;
                    _answerTwo_z = answer2.transform.position.z;

                    _answerThree_x = answer3.transform.position.x;
                    _answerThree_y = answer3.transform.position.y;
                    _answerThree_z = answer3.transform.position.z;
                    

                    //PUSH VALUE TO ARRAY TO THE LAST SPOT IN THE ARRAY
                    //resize arrays with new gaze points which get retrieved.

                    //Resize answerOne array
                    Array.Resize(ref answerOne_x, answerOne_x.Length + 1);
                    answerOne_x[answerOne_x.GetUpperBound(0)] = _answerOne_x;
                    Array.Resize(ref answerOne_y, answerOne_y.Length + 1);
                    answerOne_y[answerOne_y.GetUpperBound(0)] = _answerOne_y;
                    //foreach(var item in answerOne_y)
                    //{
                    //    Debug.Log("Value of Array: " + item);
                    //}
                    Array.Resize(ref answerOne_z, answerOne_z.Length + 1);
                    answerOne_z[answerOne_z.GetUpperBound(0)] = _answerOne_z;


                   

                    //Resize answerTwo array
                    Array.Resize(ref answerTwo_x, answerTwo_x.Length + 1);
                    answerTwo_x[answerTwo_x.GetUpperBound(0)] = _answerTwo_x;
                    Array.Resize(ref answerTwo_y, answerTwo_y.Length + 1);
                    answerTwo_y[answerTwo_y.GetUpperBound(0)] = _answerTwo_y;
                    Array.Resize(ref answerTwo_z, answerTwo_z.Length + 1);
                    answerTwo_z[answerTwo_z.GetUpperBound(0)] = _answerTwo_z;


                   
                    //Resize answerThree array
                    Array.Resize(ref answerThree_x, answerThree_x.Length + 1);
                    answerThree_x[answerThree_x.GetUpperBound(0)] = _answerThree_x;
                    Array.Resize(ref answerThree_y, answerThree_y.Length + 1);
                    answerThree_y[answerThree_y.GetUpperBound(0)] = _answerThree_y;
                    Array.Resize(ref answerThree_z, answerThree_z.Length + 1);
                    answerThree_z[answerThree_z.GetUpperBound(0)] = _answerThree_z;
                    csvDocumentation = ToCSVCorrelationNoUndoCor(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ);
                    if(ms >= waitTime && hitGivenMS == false)
                    {
                        
                        var corAnswer1X = Correlation2(gaze_x, answerOne_x);
                        
                        var corAnswer1Y = Correlation2(gaze_y, answerOne_y);
                        
                        var corAnswer1Z = Correlation2(gaze_z, answerOne_z);
                        

                        var corAnswer2X = Correlation2(gaze_x, answerTwo_x);
                        var corAnswer2Y = Correlation2(gaze_y, answerTwo_y);
                        var corAnswer2Z = Correlation2(gaze_z, answerTwo_z);

                      

                        var corAnswer3X = Correlation2(gaze_x, answerThree_x);
                        var corAnswer3Y = Correlation2(gaze_y, answerThree_y);
                        var corAnswer3Z = Correlation2(gaze_z, answerThree_z);
                        

                        //Correlation to the answers 
                        corAnswer1 = corAnswer1X + corAnswer1Y + corAnswer1Z;
                        corAnswer2 = corAnswer2X + corAnswer2Y + corAnswer2Z;
                        corAnswer3 = corAnswer3X + corAnswer3Y + corAnswer3Z;
                        ToCSVCorrelationNoUndoAnswer(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3);

                        //EyeGazeTxt1 egt = dataMa.eyeGazeData1;
                        //dataMa.eyeGazeData1.correA1 = corAnswer1;
                        //dataMa.eyeGazeData1.correA2 = corAnswer2;
                        //dataMa.eyeGazeData1.correA3 = corAnswer3;
                        //dataMa.Save();

                        if ((corAnswer1X >= 0.9) && (corAnswer1Y > 0.9) && (corAnswer1Z > 0.9) && (corAnswer1 > corAnswer2) && (corAnswer1 > corAnswer3))
                        {
                            answerOne_x = new double[0];
                            answerOne_y = new double[0];
                            answerOne_z = new double[0];

                            answerTwo_x = new double[0];
                            answerTwo_y = new double[0];
                            answerTwo_z = new double[0];

                            answerThree_x = new double[0];
                            answerThree_y = new double[0];
                            answerThree_z = new double[0];

                            gaze_x = new double[0];
                            gaze_y = new double[0];
                            gaze_z = new double[0];
                            hitGivenMS = false;
                            ms = 0;

                            
                            csvDocumentation = ToCSVCorrelationNoUndo(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3, answer1.GetComponent<Text>().text);
                            question.SetActive(false);
                            answer1.SetActive(false);
                            answer2.SetActive(false);
                            answer3.SetActive(false);
                            activatedGameObject1.SetActive(true);
                            activatedGameObject2.SetActive(true);
                            proposedAnswer1.SetActive(true);
                            
                        }

                        if ((corAnswer2X >= 0.9) && (corAnswer2Y > 0.9) && (corAnswer2Y > 0.9) && (corAnswer2 > corAnswer1) && (corAnswer2 > corAnswer3))
                        {
                            answerOne_x = new double[0];
                            answerOne_y = new double[0];
                            answerOne_z = new double[0];

                            answerTwo_x = new double[0];
                            answerTwo_y = new double[0];
                            answerTwo_z = new double[0];

                            answerThree_x = new double[0];
                            answerThree_y = new double[0];
                            answerThree_z = new double[0];

                            gaze_x = new double[0];
                            gaze_y = new double[0];
                            gaze_z = new double[0];
                            hitGivenMS = false;
                            ms = 0;

                           
                            csvDocumentation = ToCSVCorrelationNoUndo(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3, answer2.GetComponent<Text>().text);
                            question.SetActive(false);
                            answer1.SetActive(false);
                            answer2.SetActive(false);
                            answer3.SetActive(false);
                            activatedGameObject1.SetActive(true);
                            activatedGameObject2.SetActive(true);
                            proposedAnswer2.SetActive(true);
                            
                        }

                        if ((corAnswer3X >= 0.9) && (corAnswer3Y > 0.9) && (corAnswer3Z > 0.9) && (corAnswer3 > corAnswer2) && (corAnswer3 > corAnswer1))
                        {
                            answerOne_x = new double[0];
                            answerOne_y = new double[0];
                            answerOne_z = new double[0];

                            answerTwo_x = new double[0];
                            answerTwo_y = new double[0];
                            answerTwo_z = new double[0];

                            answerThree_x = new double[0];
                            answerThree_y = new double[0];
                            answerThree_z = new double[0];

                            gaze_x = new double[0];
                            gaze_y = new double[0];
                            gaze_z = new double[0];

                            hitGivenMS = false;
                            ms = 0;
                            
                            csvDocumentation = ToCSVCorrelationNoUndo(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3, answer3.GetComponent<Text>().text);
                            question.SetActive(false);
                            answer1.SetActive(false);
                            answer2.SetActive(false);
                            answer3.SetActive(false);
                            activatedGameObject1.SetActive(true);
                            activatedGameObject2.SetActive(true);
                            proposedAnswer3.SetActive(true);
                            
                        }
                    }

                }

                else if (ms >= waitTime && hitGivenMS)
                {
                    
                    
                    desktop = hit.collider.gameObject;

                    //_gazeX = transform.InverseTransformPoint(hit.point).x;
                    _gazeX = hit.point.x;
                    

                    //_gazeY = transform.InverseTransformPoint(hit.point).y;
                    _gazeY = hit.point.y;
                    
                    //_gazeZ = transform.InverseTransformPoint(hit.point).z;
                    _gazeZ = hit.point.z;
                    

                    
                    gaze_x = dropValuesOfArray(gaze_x, _gazeX);
                    gaze_y = dropValuesOfArray(gaze_y, _gazeY);
                    gaze_z = dropValuesOfArray(gaze_z, _gazeZ);


                    _answerOne_x = answer1.transform.position.x;
                    _answerOne_y = answer1.transform.position.y;
                    _answerOne_z = answer1.transform.position.z;


                    _answerTwo_x = answer2.transform.position.x;
                    _answerTwo_y = answer2.transform.position.y;
                    _answerTwo_z = answer2.transform.position.z;

                    _answerThree_x = answer3.transform.position.x;
                    _answerThree_y = answer3.transform.position.y;
                    _answerThree_z = answer3.transform.position.z;


                    // ADD 1, REMOVE FIRST OF POSITION
                    answerOne_x = dropValuesOfArray(answerOne_x, _answerOne_x);
                    answerOne_y = dropValuesOfArray(answerOne_y, _answerOne_y);
                    answerOne_z = dropValuesOfArray(answerOne_z, _answerOne_z);

                    answerTwo_x =dropValuesOfArray(answerTwo_x, _answerTwo_x);
                    answerTwo_y = dropValuesOfArray(answerTwo_y, _answerTwo_y);
                    answerTwo_z = dropValuesOfArray(answerTwo_z, _answerTwo_z);

                    answerThree_x = dropValuesOfArray(answerThree_x, _answerThree_x);
                    answerThree_y = dropValuesOfArray(answerThree_y, _answerThree_y);
                    answerThree_z = dropValuesOfArray(answerThree_z, _answerThree_z);


                    var corAnswer1X = Correlation2(gaze_x, answerOne_x);
                   
                    var corAnswer1Y = Correlation2(gaze_y, answerOne_y);
                   
                    var corAnswer1Z = Correlation2(gaze_z, answerOne_z);
                   

                    var corAnswer2X = Correlation2(gaze_x, answerTwo_x);
                    var corAnswer2Y = Correlation2(gaze_y, answerTwo_y);
                    var corAnswer2Z = Correlation2(gaze_z, answerTwo_z);

                   

                    var corAnswer3X = Correlation2(gaze_x, answerThree_x);
                    var corAnswer3Y = Correlation2(gaze_y, answerThree_y);
                    var corAnswer3Z = Correlation2(gaze_z, answerThree_z);

                    

                    //Correlation to the answers 
                    corAnswer1 = corAnswer1X + corAnswer1Y + corAnswer1Z;
                    
                    corAnswer2 = corAnswer2X + corAnswer2Y + corAnswer2Z;
                    
                    corAnswer3 = corAnswer3X + corAnswer3Y + corAnswer3Z;
                 
                    csvDocumentation = ToCSVCorrelationNoUndoAnswer(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3);
                    //EyeGazeTxt1 egt = dataMa.eyeGazeData1;
                    //dataMa.eyeGazeData1.correA1 = corAnswer1;
                    //dataMa.eyeGazeData1.correA2 = corAnswer2;
                    //dataMa.eyeGazeData1.correA3 = corAnswer3;
                    //dataMa.Save();

                    if ((corAnswer1X >= 0.9) && (corAnswer1Y > 0.9) && (corAnswer1Z > 0.9)  && (corAnswer1 > corAnswer2) && (corAnswer1 > corAnswer3))
                    {
                        answerOne_x = new double[0];
                        answerOne_y = new double[0];
                        answerOne_z = new double[0];

                        answerTwo_x = new double[0];
                        answerTwo_y = new double[0];
                        answerTwo_z = new double[0];

                        answerThree_x = new double[0];
                        answerThree_y = new double[0];
                        answerThree_z = new double[0];

                        gaze_x = new double[0];
                        gaze_y = new double[0];
                        gaze_z = new double[0];
                        hitGivenMS = false;
                        ms = 0;

                        csvDocumentation = ToCSVCorrelationNoUndo(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3, answer1.GetComponent<Text>().text);
                        question.SetActive(false);
                        answer1.SetActive(false);
                        answer2.SetActive(false);
                        answer3.SetActive(false);
                        activatedGameObject1.SetActive(true);
                        activatedGameObject2.SetActive(true);
                        proposedAnswer1.SetActive(true);
                    }

                    if ((corAnswer2X >= 0.9) && (corAnswer2Y > 0.9) && (corAnswer2Y > 0.9) &&  (corAnswer2 > corAnswer1) && (corAnswer2 > corAnswer3))
                    {
                        answerOne_x = new double[0];
                        answerOne_y = new double[0];
                        answerOne_z = new double[0];

                        answerTwo_x = new double[0];
                        answerTwo_y = new double[0];
                        answerTwo_z = new double[0];

                        answerThree_x = new double[0];
                        answerThree_y = new double[0];
                        answerThree_z = new double[0];

                        gaze_x = new double[0];
                        gaze_y = new double[0];
                        gaze_z = new double[0];
                        hitGivenMS = false;
                        ms = 0;

                      
                        csvDocumentation = ToCSVCorrelationNoUndo(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3, answer2.GetComponent<Text>().text);
                        question.SetActive(false);
                        answer1.SetActive(false);
                        answer2.SetActive(false);
                        answer3.SetActive(false);
                        activatedGameObject1.SetActive(true);
                        activatedGameObject2.SetActive(true);
                        proposedAnswer2.SetActive(true);
                    }

                    if ((corAnswer3X >= 0.9) && (corAnswer3Y > 0.9) && (corAnswer3Z > 0.9)  && (corAnswer3 > corAnswer2) && (corAnswer3 > corAnswer1))
                    {
                        answerOne_x = new double[0];
                        answerOne_y = new double[0];
                        answerOne_z = new double[0];

                        answerTwo_x = new double[0];
                        answerTwo_y = new double[0];
                        answerTwo_z = new double[0];

                        answerThree_x = new double[0];
                        answerThree_y = new double[0];
                        answerThree_z = new double[0];

                        gaze_x = new double[0];
                        gaze_y = new double[0];
                        gaze_z = new double[0];

                        hitGivenMS = false;
                        ms = 0;

                  
                        csvDocumentation = ToCSVCorrelationNoUndo(participantID, timeForCSV, questionID, _answerOne_x, _answerOne_y, _answerOne_z, _answerTwo_x, _answerTwo_y, _answerTwo_z, _answerThree_x, _answerThree_y, _answerThree_z, _gazeX, _gazeY, _gazeZ, corAnswer1, corAnswer2, corAnswer3, answer3.GetComponent<Text>().text);
                        question.SetActive(false);
                        answer1.SetActive(false);
                        answer2.SetActive(false);
                        answer3.SetActive(false);
                        activatedGameObject1.SetActive(true);
                        activatedGameObject2.SetActive(true);
                        proposedAnswer3.SetActive(true);
                    }
                }

                if(ms >= waitTime  && hitGivenMS == false)
                {
                    hitGivenMS = true;
                }
            }
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

    





    public string ToCSVCorrelation(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double obj3X, double obj3Y, double obj3Z, double gazeX, double gazeY, double gazeZ, double corAnswer1, double corAnswer2, double corAnswer3, string answer, int undo)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(", ").Append(time.ToString()).Append(", ").Append(questionID.ToString()).Append(", ").Append(obj1X.ToString()).Append(", ").Append(obj1Y.ToString()).Append(", ").Append(obj1Z.ToString()).Append(", ").Append(obj2X.ToString()).Append(", ").Append(obj2Y.ToString()).Append(", ").Append(obj2Z.ToString()).Append(", ").Append(obj3X.ToString()).Append(", ").Append(obj3Y.ToString()).Append(", ").Append(obj3Z.ToString()).Append(", ").Append(gazeX.ToString()).Append(", ").Append(gazeY.ToString()).Append(", ").Append(gazeZ.ToString()).Append(", ").Append(corAnswer1.ToString()).Append(", ").Append(corAnswer2.ToString()).Append(", ").Append(corAnswer3.ToString()).Append(", ").Append(answer.ToString()).Append(", ").Append(undo.ToString());
        return sb.ToString();

    }

    public string ToCSVCorrelationNoUndoCor(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double obj3X, double obj3Y, double obj3Z, double gazeX, double gazeY, double gazeZ)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(", ").Append(time.ToString()).Append(", ").Append(questionID.ToString()).Append(", ").Append(obj1X.ToString()).Append(", ").Append(obj1Y.ToString()).Append(", ").Append(obj1Z.ToString()).Append(", ").Append(obj2X.ToString()).Append(", ").Append(obj2Y.ToString()).Append(", ").Append(obj2Z.ToString()).Append(", ").Append(obj3X.ToString()).Append(", ").Append(obj3Y.ToString()).Append(", ").Append(obj3Z.ToString()).Append(", ").Append(gazeX.ToString()).Append(", ").Append(gazeY.ToString()).Append(", ").Append(gazeZ.ToString());
        return sb.ToString();

    }

    public string ToCSVCorrelationNoUndo(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double obj3X, double obj3Y, double obj3Z, double gazeX, double gazeY, double gazeZ, double corAnswer1, double corAnswer2, double corAnswer3, string answer)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(", ").Append(time.ToString()).Append(", ").Append(questionID.ToString()).Append(", ").Append(obj1X.ToString()).Append(", ").Append(obj1Y.ToString()).Append(", ").Append(obj1Z.ToString()).Append(", ").Append(obj2X.ToString()).Append(", ").Append(obj2Y.ToString()).Append(", ").Append(obj2Z.ToString()).Append(", ").Append(obj3X.ToString()).Append(", ").Append(obj3Y.ToString()).Append(", ").Append(obj3Z.ToString()).Append(", ").Append(gazeX.ToString()).Append(", ").Append(gazeY.ToString()).Append(", ").Append(gazeZ.ToString()).Append(", ").Append(corAnswer1.ToString()).Append(", ").Append(corAnswer2.ToString()).Append(", ").Append(corAnswer3.ToString()).Append(", ").Append(answer.ToString());
        return sb.ToString();

    }

    public string ToCSVCorrelationNoUndoAnswer(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double obj3X, double obj3Y, double obj3Z, double gazeX, double gazeY, double gazeZ, double corAnswer1, double corAnswer2, double corAnswer3)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(", ").Append(time.ToString()).Append(", ").Append(questionID.ToString()).Append(", ").Append(obj1X.ToString()).Append(", ").Append(obj1Y.ToString()).Append(", ").Append(obj1Z.ToString()).Append(", ").Append(obj2X.ToString()).Append(", ").Append(obj2Y.ToString()).Append(", ").Append(obj2Z.ToString()).Append(", ").Append(obj3X.ToString()).Append(", ").Append(obj3Y.ToString()).Append(", ").Append(obj3Z.ToString()).Append(", ").Append(gazeX.ToString()).Append(", ").Append(gazeY.ToString()).Append(", ").Append(gazeZ.ToString()).Append(", ").Append(corAnswer1.ToString()).Append(", ").Append(corAnswer2.ToString()).Append(", ").Append(corAnswer3.ToString());
        return sb.ToString();

    }


    public void SaveToFile()
    {
        var content = csvDocumentation;
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

    private double[] dropValuesOfArray(double[] arr, double lastValue)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if(i <arr.Length - 1)
            {
                arr[i] = arr[i + 1];
            }
            if(i == arr.Length - 1)
            {
                arr[i] = lastValue;
            }
        }
        return arr;
    }
}
