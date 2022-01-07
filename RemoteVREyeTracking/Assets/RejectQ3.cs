using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ3 : MonoBehaviour
{
    public GameObject propAction;
    public GameObject propThriller;
    public GameObject propComedy;


    public void Reject(){
        if(propAction.activeSelf){
            propAction.SetActive(false);
        }
        if(propThriller.activeSelf){
            propThriller.SetActive(false);
        }
        if(propComedy.activeSelf){
            propComedy.SetActive(false);
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

