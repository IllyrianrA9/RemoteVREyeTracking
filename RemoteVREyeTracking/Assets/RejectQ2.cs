using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ2 : MonoBehaviour
{
    public GameObject proposedAnswerPresense;
    public GameObject proposedAnswerRemotely;
    public GameObject proposedAnswerIdm;


    public void Reject(){
        if(proposedAnswerPresense.activeSelf){
            proposedAnswerPresense.SetActive(false);
        }
        if(proposedAnswerRemotely.activeSelf){
            proposedAnswerRemotely.SetActive(false);
        }
        if(proposedAnswerIdm.activeSelf){
            proposedAnswerIdm.SetActive(false);
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
