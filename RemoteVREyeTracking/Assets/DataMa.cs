using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataMa : MonoBehaviour
{
    public EyeGazeTxt1 eyeGazeData1 = new EyeGazeTxt1();

    public string file = "eyeGazeData.txt";

    public void Save()
    {
        string json = JsonUtility.ToJson(eyeGazeData1, true);
        WriteToFile(file, json);
    }

    private void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
            Debug.Log(" Write to JSON");
        }
    }
    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}