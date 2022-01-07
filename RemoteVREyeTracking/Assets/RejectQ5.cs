using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ5 : MonoBehaviour
{
    public GameObject propWater;
    public GameObject propCoffee;
    public GameObject propTea;


    public void Reject(){
        if(propWater.activeSelf){
            propWater.SetActive(false);
        }
        if(propCoffee.activeSelf){
            propCoffee.SetActive(false);
        }
        if(propTea.activeSelf){
            propTea.SetActive(false);
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

