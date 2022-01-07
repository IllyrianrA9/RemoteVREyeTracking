using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ1 : MonoBehaviour
{
    public GameObject proposedAnswerYes;
    public GameObject proposedAnswerNo;
    public GameObject proposedAnswerIdr;


    public void Reject(){
        if(proposedAnswerYes.activeSelf){
            proposedAnswerYes.SetActive(false);
        }
        if(proposedAnswerNo.activeSelf){
            proposedAnswerNo.SetActive(false);
        }
        if(proposedAnswerIdr.activeSelf){
            proposedAnswerIdr.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
