using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ6 : MonoBehaviour
{
    public GameObject propChoco;
    public GameObject propMango;
    public GameObject propVanilla;


    public void Reject(){
        if(propChoco.activeSelf){
            propChoco.SetActive(false);
        }
        if(propMango.activeSelf){
            propMango.SetActive(false);
        }
        if(propVanilla.activeSelf){
            propVanilla.SetActive(false);
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

