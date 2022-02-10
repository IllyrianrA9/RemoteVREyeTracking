using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;
using System.Text;
using System.IO;
using UnityEngine.UI;

public class UndoGaze : MonoBehaviour
{
    public float timeForCSV;
    public StringBuilder sb;
    public string  csvDocumentation;
    private string file;
    public GameObject user;
    public GameObject undoQuestion;
    public int undoAmount;
    //This objects will either get activated or deactivated regarding the chosen answer by the participant
    //SetActive False
    public GameObject change;
    public GameObject next;
    private double corChange;
    private double corNext;
    //Next Screen appearance
    public GameObject questionNext;
    public GameObject answer1Next;
    public GameObject answer2Next;
    public GameObject answer3Next;

    public GameObject questionChange;
    public GameObject answer1Change;
    public GameObject answer2Change;
    public GameObject answer3Change;

    //SetActive False if activeSelf
    public GameObject proposedAnswer1;
    public GameObject proposedAnswer2;
    public GameObject proposedAnswer3;


    //x, y and z coordinate of the answer
    private double _changeX;
    private double _changeY;
    private double _changeZ;

    private double _nextX;
    private double _nextY;
    private double _nextZ;


    //Arrays of positions of the moving answers
    private double[] changeX = new double[0];
    private double[] changeY = new double[0];
    private double[] changeZ = new double[0];

    private double[] nextX = new double[0];
    private double[] nextY = new double[0];
    private double[] nextZ = new double[0];



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
    public float waitTime = 2000;

    private bool hitGivenMS = false;

    // Start is called before the first frame update
    void Start()
    {
        if (questionChange.GetComponent<calcCorrelation>().timeForCSV > timeForCSV)
        {
            timeForCSV = questionChange.GetComponent<calcCorrelation>().timeForCSV;
            csvDocumentation = questionChange.GetComponent<calcCorrelation>().csvDocumentation;
            sb = questionChange.GetComponent<calcCorrelation>().sb;
            undoAmount = questionChange.GetComponent<calcCorrelation>().undoAmount;
        }

         file = questionChange.GetComponent<calcCorrelation>().file;
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
                    
                    // (var item in gaze_x)
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

                    _changeX = change.transform.position.x;
                    _changeY = change.transform.position.y;
                    _changeZ = change.transform.position.z;
                    //Debug.Log("Anser X " + _answerOne_x);
                    //Debug.Log("Anser Y " + _answerOne_y);
                    //Debug.Log("Anser Z " + _answerOne_z);


                    _nextX = next.transform.position.x;
                    _nextY = next.transform.position.y;
                    _nextZ = next.transform.position.z;

                   
                    //PUSH VALUE TO ARRAY TO THE LAST SPOT IN THE ARRAY
                    //resize arrays with new gaze points which get retrieved.

                    //Resize answerOne array
                    Array.Resize(ref nextX, nextX.Length + 1);
                    nextX[nextX.GetUpperBound(0)] = _nextX;
                    Array.Resize(ref nextY, nextY.Length + 1);
                    nextY[nextY.GetUpperBound(0)] = _nextY;
                    //foreach(var item in answerOne_y)
                    //{
                    //    Debug.Log("Value of Array: " + item);
                    //}
                    Array.Resize(ref nextZ, nextZ.Length + 1);
                    nextZ[nextZ.GetUpperBound(0)] = _nextZ;


                  

                    //Resize answerTwo array
                    Array.Resize(ref changeX, changeX.Length + 1);
                    changeX[changeX.GetUpperBound(0)] = _changeX;
                    Array.Resize(ref changeY, changeY.Length + 1);
                    changeY[changeY.GetUpperBound(0)] = _changeY;
                    Array.Resize(ref changeZ, changeZ.Length + 1);
                    changeZ[changeZ.GetUpperBound(0)] = _changeZ;
                    
                    csvDocumentation = ToCSVCorrelationNoUndoCor(user.GetComponent<Text>().text, timeForCSV, "Undo_Screen", _changeX, _changeY, _changeZ, _nextX, _nextY, _nextZ, _gazeX, _gazeY, _gazeZ);
                }


                if (ms >= waitTime && hitGivenMS == false)
                {
               


                    var corNextX = Correlation2(gaze_x, nextX);
                 
                    var corNextY = Correlation2(gaze_y, nextY);
               
                    var corNextZ = Correlation2(gaze_z, nextZ);
                  

                    var corChangeX = Correlation2(gaze_x, changeZ);
                    var corChangeY = Correlation2(gaze_y, changeZ);
                    var corChangeZ = Correlation2(gaze_z, changeZ);

                  

                    //Correlation to the answers 
                    corNext = corNextX + corNextY + corNextZ;
                    corChange = corChangeX + corChangeY + corChangeZ;

                    csvDocumentation = ToCSVCorrelationNoUndoAnswer(user.GetComponent<Text>().text, timeForCSV, "Undo_Screen", _changeX, _changeY, _changeZ, _nextX, _nextY, _nextZ, _gazeX, _gazeY, _gazeZ, corChange, corNext);

                    if ((corNextX >= 0.9) && (corNextY >= 0.9) && (corNextZ >= 0.9) && (corNext > corChange))
                    {
                        csvDocumentation = ToCSVCorrelation(user.GetComponent<Text>().text, timeForCSV, "Undo_Screen", _changeX, _changeY, _changeZ, _nextX, _nextY, _nextZ, _gazeX, _gazeY, _gazeZ, corChange, corNext, next.name, undoAmount);
                        changeX = new double[0];
                        changeY = new double[0];
                        changeZ = new double[0];

                        nextX = new double[0];
                        nextY = new double[0];
                        nextZ = new double[0];

                        gaze_x = new double[0];
                        gaze_y = new double[0];
                        gaze_z = new double[0];
                        hitGivenMS = false;
                        ms = 0;

                       
                        questionNext.SetActive(true);
                        answer1Next.SetActive(true);
                        answer2Next.SetActive(true);
                        answer3Next.SetActive(true);
                        change.SetActive(false);
                        next.SetActive(false);
                        if (proposedAnswer1.activeSelf)
                        {
                            proposedAnswer1.SetActive(false);
                        }
                        if (proposedAnswer2.activeSelf)
                        {
                            proposedAnswer2.SetActive(false);
                        }
                        if (proposedAnswer3.activeSelf)
                        {
                            proposedAnswer3.SetActive(false);
                        }

                    }

                    if ((corChangeX >= 0.9) && (corChangeY >= 0.9) && (corChangeZ >= 0.9) && (corChange > corNext))
                    {
                        undoAmount += 1;
                        csvDocumentation = ToCSVCorrelation(user.GetComponent<Text>().text, timeForCSV, "Undo_Screen", _changeX, _changeY, _changeZ, _nextX, _nextY, _nextZ, _gazeX, _gazeY, _gazeZ, corChange, corNext, change.name, undoAmount);
                        changeX = new double[0];
                        changeY = new double[0];
                        changeZ = new double[0];

                        nextX = new double[0];
                        nextY = new double[0];
                        nextZ = new double[0];

                        gaze_x = new double[0];
                        gaze_y = new double[0];
                        gaze_z = new double[0];
                        hitGivenMS = false;
                        ms = 0;

                        
                        questionChange.SetActive(true);
                        answer1Change.SetActive(true);
                        answer2Change.SetActive(true);
                        answer3Change.SetActive(true);
                        change.SetActive(false);
                        next.SetActive(false);
                        if (proposedAnswer1.activeSelf)
                        {
                            proposedAnswer1.SetActive(false);
                        }
                        if (proposedAnswer2.activeSelf)
                        {
                            proposedAnswer2.SetActive(false);
                        }
                        if (proposedAnswer3.activeSelf)
                        {
                            proposedAnswer3.SetActive(false);
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



                    _changeX = change.transform.position.x;
                    _changeY = change.transform.position.y;
                    _changeZ = change.transform.position.z;
                    //Debug.Log("Anser X " + _answerOne_x);
                    //Debug.Log("Anser Y " + _answerOne_y);
                    //Debug.Log("Anser Z " + _answerOne_z);


                    _nextX = next.transform.position.x;
                    _nextY = next.transform.position.y;
                    _nextZ = next.transform.position.z;

                 




                    // ADD 1, REMOVE FIRST OF POSITION
                    changeX = dropValuesOfArray(changeX, _changeX);
                    changeY = dropValuesOfArray(changeY, _changeY);
                    changeZ = dropValuesOfArray(changeZ, _changeZ);

                    nextX = dropValuesOfArray(nextX, _nextX);
                    nextY = dropValuesOfArray(nextY, _nextY);
                    nextZ = dropValuesOfArray(nextZ, _nextZ);

                    var corNextX = Correlation2(gaze_x, nextX);
                    
                    var corNextY = Correlation2(gaze_y, nextY);
                    
                    var corNextZ = Correlation2(gaze_z, nextZ);
                   

                    var corChangeX = Correlation2(gaze_x, changeZ);
                    var corChangeY = Correlation2(gaze_y, changeZ);
                    var corChangeZ = Correlation2(gaze_z, changeZ);


                    

                    //Correlation to the answers 
                    corNext = corNextX + corNextY + corNextZ;
                    
                    corChange = corChangeX + corChangeY + corChangeZ;
                  
                    csvDocumentation = ToCSVCorrelationNoUndoAnswer(user.GetComponent<Text>().text, timeForCSV, "Undo_Screen", _changeX, _changeY, _changeZ, _nextX, _nextY, _nextZ, _gazeX, _gazeY, _gazeZ, corChange, corNext);


                    if ((corNextX >= 0.9) && (corNextY >= 0.9) && (corNextZ >= 0.9) && (corNext > corChange))
                    {
                        csvDocumentation = ToCSVCorrelation(user.GetComponent<Text>().text, timeForCSV, "Undo_Screen", _changeX, _changeY, _changeZ, _nextX, _nextY, _nextZ, _gazeX, _gazeY, _gazeZ, corChange, corNext, next.name, undoAmount);
                        changeX = new double[0];
                        changeY = new double[0];
                        changeZ = new double[0];

                        nextX = new double[0];
                        nextY = new double[0];
                        nextZ = new double[0];

                        gaze_x = new double[0];
                        gaze_y = new double[0];
                        gaze_z = new double[0];
                        hitGivenMS = false;
                        ms = 0;

                      
                        questionNext.SetActive(true);
                        answer1Next.SetActive(true);
                        answer2Next.SetActive(true);
                        answer3Next.SetActive(true);
                        change.SetActive(false);
                        next.SetActive(false);
                        if (proposedAnswer1.activeSelf)
                        {
                            proposedAnswer1.SetActive(false);
                        }
                        if (proposedAnswer2.activeSelf)
                        {
                            proposedAnswer2.SetActive(false);
                        }
                        if (proposedAnswer3.activeSelf)
                        {
                            proposedAnswer3.SetActive(false);
                        }
                    }

                    if ((corChangeX >= 0.9) && (corChangeY >= 0.9) && (corChangeZ >= 0.9) && (corChange > corNext))
                    {
                        undoAmount += 1;
                        csvDocumentation = ToCSVCorrelation(user.GetComponent<Text>().text, timeForCSV, "Undo_Screen", _changeX, _changeY, _changeZ, _nextX, _nextY, _nextZ, _gazeX, _gazeY, _gazeZ, corChange, corNext, change.name, undoAmount);
                        changeX = new double[0];
                        changeY = new double[0];
                        changeZ = new double[0];

                        nextX = new double[0];
                        nextY = new double[0];
                        nextZ = new double[0];

                        gaze_x = new double[0];
                        gaze_y = new double[0];
                        gaze_z = new double[0];
                        hitGivenMS = false;
                        ms = 0;

                   
                        questionChange.SetActive(true);
                        answer1Change.SetActive(true);
                        answer2Change.SetActive(true);
                        answer3Change.SetActive(true);
                        change.SetActive(false);
                        next.SetActive(false);
                        if (proposedAnswer1.activeSelf)
                        {
                            proposedAnswer1.SetActive(false);
                        }
                        if (proposedAnswer2.activeSelf)
                        {
                            proposedAnswer2.SetActive(false);
                        }
                        if (proposedAnswer3.activeSelf)
                        {
                            proposedAnswer3.SetActive(false);
                        }
                    }
                }
                if (ms >= waitTime && hitGivenMS == false)
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

    private double[] dropValuesOfArray(double[] arr, double lastValue)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1)
            {
                arr[i] = arr[i + 1];
            }
            if (i == arr.Length - 1)
            {
                arr[i] = lastValue;
            }
        }
        return arr;
    }

    public string ToCSVCorrelation(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double gazeX, double gazeY, double gazeZ, double corAnswer1, double corAnswer2, string answer, int undo)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(" ").Append(time.ToString()).Append(" ").Append(questionID.ToString()).Append(" ").Append(obj1X.ToString()).Append(" ").Append(obj1Y.ToString()).Append(" ").Append(obj1Z.ToString()).Append(" ").Append(obj2X.ToString()).Append(" ").Append(obj2Y.ToString()).Append(" ").Append(obj2Z.ToString()).Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append(gazeX.ToString()).Append(" ").Append(gazeY.ToString()).Append(" ").Append(gazeZ.ToString()).Append(" ").Append(corAnswer1.ToString()).Append(" ").Append(corAnswer2.ToString()).Append(" ").Append("----").Append(" ").Append(answer.ToString()).Append(" ").Append(undo.ToString());
        return sb.ToString();

    }

    public string ToCSVCorrelationNoUndoCor(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double gazeX, double gazeY, double gazeZ)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(" ").Append(time.ToString()).Append(" ").Append(questionID.ToString()).Append(" ").Append(obj1X.ToString()).Append(" ").Append(obj1Y.ToString()).Append(" ").Append(obj1Z.ToString()).Append(" ").Append(obj2X.ToString()).Append(" ").Append(obj2Y.ToString()).Append(" ").Append(obj2Z.ToString()).Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append(gazeX.ToString()).Append(" ").Append(gazeY.ToString()).Append(" ").Append(gazeZ.ToString());
        return sb.ToString();

    }

    public string ToCSVCorrelationNoUndo(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double gazeX, double gazeY, double gazeZ, double corAnswer1, double corAnswer2, string answer)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(" ").Append(time.ToString()).Append(" ").Append(questionID.ToString()).Append(" ").Append(obj1X.ToString()).Append(" ").Append(obj1Y.ToString()).Append(" ").Append(obj1Z.ToString()).Append(" ").Append(obj2X.ToString()).Append(" ").Append(obj2Y.ToString()).Append(" ").Append(obj2Z.ToString()).Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append(gazeX.ToString()).Append(" ").Append(gazeY.ToString()).Append(" ").Append(gazeZ.ToString()).Append(" ").Append(corAnswer1.ToString()).Append(" ").Append(corAnswer2.ToString()).Append(" ").Append("----").Append(" ").Append(answer.ToString());
        return sb.ToString();

    }

    public string ToCSVCorrelationNoUndoAnswer(string userID, float time, string questionID, double obj1X, double obj1Y, double obj1Z, double obj2X, double obj2Y, double obj2Z, double gazeX, double gazeY, double gazeZ, double corAnswer1, double corAnswer2)
    {
        //var sb = new StringBuilder("Answer 1 Correlation, Answer 2 Correlation, Answer 3 Correlation");
        sb.Append('\n').Append(userID.ToString()).Append(" ").Append(time.ToString()).Append(" ").Append(questionID.ToString()).Append(" ").Append(obj1X.ToString()).Append(" ").Append(obj1Y.ToString()).Append(" ").Append(obj1Z.ToString()).Append(" ").Append(obj2X.ToString()).Append(" ").Append(obj2Y.ToString()).Append(" ").Append(obj2Z.ToString()).Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append("----").Append(" ").Append(gazeX.ToString()).Append(" ").Append(gazeY.ToString()).Append(" ").Append(gazeZ.ToString()).Append(" ").Append(corAnswer1.ToString()).Append(" ").Append(corAnswer2.ToString()).Append(" ").Append("----");
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
}