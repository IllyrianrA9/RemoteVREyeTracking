using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ9 : MonoBehaviour
{
    public GameObject propPool;
    public GameObject propIdls;
    public GameObject propBeach;


    public void Reject(){
        if(propPool.activeSelf){
            propPool.SetActive(false);
        }
        if(propIdls.activeSelf){
            propIdls.SetActive(false);
        }
        if(propBeach.activeSelf){
            propBeach.SetActive(false);
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

