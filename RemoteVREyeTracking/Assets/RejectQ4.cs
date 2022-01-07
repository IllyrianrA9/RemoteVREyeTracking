using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ4 : MonoBehaviour
{
    public GameObject propNone;
    public GameObject propInsta;
    public GameObject propFacebook;


    public void Reject(){
        if(propNone.activeSelf){
            propNone.SetActive(false);
        }
        if(propInsta.activeSelf){
            propInsta.SetActive(false);
        }
        if(propFacebook.activeSelf){
            propFacebook.SetActive(false);
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

