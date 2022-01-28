using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArrowInputFieldPostStudy : MonoBehaviour
{

    public TMP_InputField distraction;
    public TMP_InputField distractionOnScreen;
    public TMP_InputField difficultyStudy;
    public TMP_InputField answerWrong;
    public TMP_InputField moreInstruction;
    public TMP_InputField vrCamera;
    public GameObject objectButton;
    private Button button;

    public GameObject distractionObject;
    public GameObject distractionOnSObject;
    public GameObject difficultyStudyObject;
    public GameObject answerWrongObject;
    public GameObject moreInstructionObject;
    public GameObject vrCameraObject;

    public GameObject lastText;
    public GameObject postStudy;
    public GameObject keyboard;
    public GameObject canvasKeyboard;

    public int InputSelected;

    public GameObject arrowUpKey;
    public GameObject arrowDownKey;
    private Button  buttonArrowUp;
    private Button  buttonArrowDown;

    private string distractionText;
    private string distractionOnScreenText;
    private string difficultyStudyText;
    private string answerWrongText;
    private string moreInstructionText;
    private string vrCameraText;

    public float buttonBlockedDown = 0;
    public float buttonBlockedUp = 0;
    // Start is called before the first frame update
    void Start()
    {
        button = objectButton.GetComponent<Button>();
        distractionText = distraction.GetComponent<TMP_InputField>().text;
        distractionOnScreenText = distractionOnScreen.GetComponent<TMP_InputField>().text;
        difficultyStudyText = difficultyStudy.GetComponent<TMP_InputField>().text;
        answerWrongText = answerWrong.GetComponent<TMP_InputField>().text;
        moreInstructionText = moreInstruction.GetComponent<TMP_InputField>().text;
        vrCameraText = vrCamera.GetComponent<TMP_InputField>().text;
        buttonArrowUp = arrowUpKey.GetComponent<Button>();
        buttonArrowDown = arrowDownKey.GetComponent<Button>();


    }

    // Update is called once per frame
    void Update()
    {
        buttonBlockedDown += Time.deltaTime;
        buttonBlockedUp += Time.deltaTime;

    }

    public void filledIn()
    {
        if (distraction.text.Trim().Length == 0)
        {
            distractionObject.SetActive(true);
        }

        if (distractionOnScreen.text.Trim().Length == 0)
        {
            distractionOnSObject.SetActive(true);
        }

        if (difficultyStudy.text.Trim().Length == 0)
        {
            difficultyStudyObject.SetActive(true);
        }

        if (answerWrong.text.Trim().Length == 0)
        {
            answerWrongObject.SetActive(true);
        }

        if (moreInstruction.text.Trim().Length == 0)
        {
            moreInstructionObject.SetActive(true);
        }

        if (vrCamera.text.Trim().Length == 0)
        {
            vrCameraObject.SetActive(true);
        }



        if (!(distraction.text.Trim().Length == 0))
        {
            distractionObject.SetActive(false);
        }

        if (!(distractionOnScreen.text.Trim().Length == 0))
        {
            distractionOnSObject.SetActive(false);
        }

        if (!(difficultyStudy.text.Trim().Length == 0))
        {
            difficultyStudyObject.SetActive(false);
        }

        if (!(answerWrong.text.Trim().Length == 0))
        {
            answerWrongObject.SetActive(false);
        }

        if (!(moreInstruction.text.Trim().Length == 0))
        {
            moreInstructionObject.SetActive(false);
        }

        if (!(vrCamera.text.Trim().Length == 0))
        {
            vrCameraObject.SetActive(false);
        }
        if (!(distraction.text.Trim().Length == 0) && !(distractionOnScreen.text.Trim().Length == 0) && !(difficultyStudy.text.Trim().Length == 0) && !(answerWrong.text.Trim().Length == 0) && !(moreInstruction.text.Trim().Length == 0) && !(vrCamera.text.Trim().Length == 0))
        {
            if (distractionObject.activeSelf == true)
            {
                distractionObject.SetActive(false);
            }
            if (distractionOnSObject.activeSelf == true)
            {
                distractionOnSObject.SetActive(false);
            }
            if (difficultyStudyObject.activeSelf == true)
            {
                difficultyStudyObject.SetActive(false);
            }
            if (answerWrongObject.activeSelf == true)
            {
                answerWrongObject.SetActive(false);
            }
            if (moreInstructionObject.activeSelf == true)
            {
                moreInstructionObject.SetActive(false);
            }
            if (vrCameraObject.activeSelf == true)
            {
                vrCameraObject.SetActive(false);
            }

            //Hier kommen die zu nutzenden Objekte
            lastText.SetActive(true);
            postStudy.SetActive(false);
            keyboard.SetActive(false);
            canvasKeyboard.SetActive(false);


        }
    }

    public void upperInputField()
    {
        if(buttonArrowUp.enabled == true)
        {
            InputSelected--;
            if (InputSelected < 0)
            {
                InputSelected = 5;
            }
            switch (InputSelected)
            {
                case 0:
                    difficultyStudy.Select();
                    break;
                case 1:
                    answerWrong.Select();
                    break;
                case 2:
                    moreInstruction.Select();
                    break;
                case 3:
                    distraction.Select();
                    break;
                case 4:
                    distractionOnScreen.Select();
                    break;
                case 5:
                    vrCamera.Select();
                    break;
            }
            buttonArrowUp.enabled = false;
        }
        if(buttonBlockedUp > 1f)
        {
            buttonArrowUp.enabled = true;
            buttonBlockedUp = 0;
        }
           
        buttonArrowUp.interactable = false;
        Invoke("ReActivateArrowUp", 1);
    }

    public void lowerInputField()
    { 
      if (buttonArrowDown.enabled == true)
      {
            InputSelected++;
            if (InputSelected > 5)
            {
                InputSelected = 0;
            }

            switch (InputSelected)
            {
                case 0:
                    difficultyStudy.Select();
                    break;
                case 1:
                    answerWrong.Select();
                    break;
                case 2:
                    moreInstruction.Select();
                    break;
                case 3:
                    distraction.Select();
                    break;
                case 4:
                    distractionOnScreen.Select();
                    break;
                case 5:
                    vrCamera.Select();
                    break;
            }
            buttonArrowDown.enabled = false;
      }
      if(buttonBlockedDown > 1f)
        {
            buttonArrowDown.enabled = true;
            buttonBlockedDown  = 0;
            
        }
      
        buttonArrowDown.interactable = false;
        Invoke("ReActivateArrowDown", 1);
    }

    public void ReActivateArrowDown()
    {
        buttonArrowDown.interactable = true;
    }

    public void ReActivateArrowUp()
    {
        buttonArrowUp.interactable = true;
    }
}
