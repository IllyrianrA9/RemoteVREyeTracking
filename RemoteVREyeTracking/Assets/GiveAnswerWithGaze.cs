using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.XR;
using Tobii.G2OM;

public class GiveAnswerWithGaze : MonoBehaviour, IGazeFocusable
{
    public GameObject proposedAnswer;
    public GameObject activatedGameObject1;
    public GameObject activatedGameObject2;
    public GameObject removedGameObject1;
    public GameObject removedGameObject2;
    public GameObject removedGameObject3;
    public GameObject removedGameObject4;

    public float timeLeft = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GazeFocusChanged(bool hasFocus)
    {
            //While this object has focus, start the counter
            if(hasFocus){
                timeLeft -= Time.deltaTime;
                if(timeLeft <= 0){
                    proposedAnswer.SetActive(true);
                    activatedGameObject1.SetActive(true);
                    activatedGameObject2.SetActive(true);
                    removedGameObject1.SetActive(false);
                    removedGameObject2.SetActive(false);
                    removedGameObject3.SetActive(false);
                    removedGameObject4.SetActive(false);
                    timeLeft = 7.0f;
                }
            }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
