using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ8 : MonoBehaviour
{
    public GameObject propInvis;
    public GameObject propTele;
    public GameObject propRpM;


    public void Reject(){
        if(propInvis.activeSelf){
            propInvis.SetActive(false);
        }
        if(propTele.activeSelf){
            propTele.SetActive(false);
        }
        if(propRpM.activeSelf){
            propRpM.SetActive(false);
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
