using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ7 : MonoBehaviour
{
    public GameObject propRarely;
    public GameObject propOften;
    public GameObject propAlmostDaily;


    public void Reject(){
        if(propRarely.activeSelf){
            propRarely.SetActive(false);
        }
        if(propOften.activeSelf){
            propOften.SetActive(false);
        }
        if(propAlmostDaily.activeSelf){
            propAlmostDaily.SetActive(false);
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
