using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RejectQ10 : MonoBehaviour
{
    public GameObject propFruity;
    public GameObject propBubbleG;
    public GameObject propPeppermint;


    public void Reject(){
        if(propFruity.activeSelf){
            propFruity.SetActive(false);
        }
        if(propBubbleG.activeSelf){
            propBubbleG.SetActive(false);
        }
        if(propPeppermint.activeSelf){
            propPeppermint.SetActive(false);
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
