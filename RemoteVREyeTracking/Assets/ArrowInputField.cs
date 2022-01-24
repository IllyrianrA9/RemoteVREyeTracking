using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArrowInputField : MonoBehaviour
{

    public TMP_InputField age;
    public TMP_InputField gender;
    public TMP_InputField vision;
    public TMP_InputField residency;
    public TMP_InputField origin;
    public TMP_InputField experience;
    public TMP_InputField remoteStudies;

    public int InputSelected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            InputSelected--;
            if(InputSelected < 0)
            {
                InputSelected = 6;
            }
            SelectInputField();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            InputSelected++;
            if(InputSelected > 6)
            {
                InputSelected = 0;
            }
            SelectInputField();
        }

        void SelectInputField()
        {
            switch (InputSelected)
            {
                case 0: age.Select();
                    break;
                case 1: gender.Select();
                    break;
                case 2: vision.Select();
                    break;
                case 3: residency.Select();
                    break;
                case 4: origin.Select();
                    break;
                case 5: experience.Select();
                    break;
                case 6: remoteStudies.Select();
                    break;
            }
        }
    }
}
