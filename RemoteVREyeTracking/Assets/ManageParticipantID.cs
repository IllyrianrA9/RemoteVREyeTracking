using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ManageParticipantID : MonoBehaviour
{
    public GameObject participant;
    public int participantNumber;
    // Start is called before the first frame update
    void Start()
    {
        participantNumber = Random.Range(1, 1000);
        participant.GetComponent<Text>().text  = participant.GetComponent<Text>().text + participantNumber.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
