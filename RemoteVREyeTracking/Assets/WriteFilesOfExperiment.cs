using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;
using Tobii.XR;
using System.Text;
using System.IO;
using UnityEngine.UI;

public class WriteFilesOfExperiment : MonoBehaviour
{

    public string csvDocumentation;
    private string file;
    public GameObject undoTenScreen;
    public GameObject myFile;
    // Start is called before the first frame update
    void Start()
    {
        csvDocumentation = undoTenScreen.GetComponent<UndoGaze10>().csvDocumentation;
        file = myFile.GetComponent<calcCorrelation>().file;
        SaveToFile();
    }

    // Update is called once per frame
    void Update()
    {
        
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
