using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;

public class CollectAnswers : MonoBehaviour
{
    public GameObject firstReg;
    public GameObject secondReg;
    public GameObject thirdReg;
    public GameObject fourthReg;
    public GameObject firstScene;
    public GameObject secondScene;
    public StringBuilder sb;
    public string file = "PwEval_";
    // Start is called before the first frame update
    void Start()
    {
        firstScene = secondReg.GetComponent<Set3Registration>().firstScene;
        secondScene = thirdReg.GetComponent<Set4Registration>().secondScene;
        sb = new StringBuilder("PaypalNoDistract_Memory PaypalNoDistract_HowStrong PaypalDistract_Memory PaypalDistract_HowStrong " + firstScene.name + "_Memory " + firstScene.name + "_HowStrong " + secondScene.name + "_Memory " + secondScene.name + "_HowStrong");
        var a = firstReg.GetComponent<PwEvaluation>().memory;
        var b = firstReg.GetComponent<PwEvaluation>().strongPW;
        var c = secondReg.GetComponent<PwEvaluation>().memory;
        var d = secondReg.GetComponent<PwEvaluation>().strongPW;
        var e = thirdReg.GetComponent<PwEvaluation>().memory;
        var f = thirdReg.GetComponent<PwEvaluation>().strongPW;
        var g = fourthReg.GetComponent<PwEvaluation>().memory;
        var h = fourthReg.GetComponent<PwEvaluation>().strongPW;
        ToCSVPostStudy(a, b, c, d, e, f, g, h);
        SaveToFile();
    }
    public string ToCSVPostStudy(string a, string b, string c, string d, string e, string f, string g, string h)
    {
        //var sb = new StringBuilder("Participant_ID Time Scene X_Gaze Y_Gaze Z_Gaze X_Position_Email Y_Position_Email Z_Position_Email X_Position_PW Y_Position_PW Z_Position_PW X_Position_ConfirmedPW Y_Position_ConfirmedPW Z_Position_ConfirmedPW Prefered_Topic Email Password");
        sb.Append('\n').Append(a.ToString()).Append(" ").Append(b.ToString()).Append(" ").Append(c.ToString()).Append(" ").Append(d.ToString()).Append(" ").Append(e.ToString()).Append(" ").Append(f.ToString()).Append(" ").Append(g.ToString()).Append(" ").Append(h.ToString());
        return sb.ToString();

    } 

    public void SaveToFile()
    {
        var content = sb;
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(sb);
        }

    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

}
