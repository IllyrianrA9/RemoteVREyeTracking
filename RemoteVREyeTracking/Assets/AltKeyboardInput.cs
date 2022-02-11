using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;

public class AltKeyboardInput : MonoBehaviour
{
    public bool wasActive = false;
    public GameObject lowerKeyboard;
    public GameObject altKeyboard;
    public GameObject upperKeyboard;
    public GameObject canvasForPartID;
    private int participantNumberReal;

    public string file = "postStudy";
    public GameObject participant;
    private string participantID;

    public TMP_InputField distraction;
    public TMP_InputField distractionOnScreen;
    public TMP_InputField difficultyStudy;
    public TMP_InputField answerWrong;
    public GameObject moreInstruction;
    public TMP_InputField vrCamera;
    public GameObject objectButton;
    private Button button;

    public GameObject distractionObject;
    public GameObject distractionOnSObject;
    public GameObject difficultyStudyObject;
    public GameObject answerWrongObject;
    public GameObject moreInstructionObject;
    public GameObject vrCameraObject;

    public GameObject endButton;
    public GameObject lastText;
    public GameObject postStudy;
    public GameObject keyboard;
    public GameObject canvasKeyboard;

    public int InputSelected;

    public GameObject arrowUpKey;
    public GameObject arrowDownKey;
    private Button buttonArrowUp;
    private Button buttonArrowDown;

    private string distractionText;
    private string distractionOnScreenText;
    private string difficultyStudyText;
    private string answerWrongText;
    private string moreInstructionText;
    private string vrCameraText;

    public float buttonBlockedDown = 0;
    public float buttonBlockedUp = 0;
    // Start is called before the first frame update

   
    public GameObject e;
    public GameObject q;
    public GameObject m;
    public GameObject space;
    public GameObject ß;
    public GameObject two;
    public GameObject three;
    public GameObject zero;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject deleteOneChar;

    public GameObject tabulator;
    public GameObject shift;
    public GameObject pfeilRechts;
    public GameObject stern;
    public GameObject alt;


    private Button eButton;
    private Button mButton;
    private Button qButton;
    private Button twoButton;
    private Button threeButton;
    private Button sevenButton;
    private Button eightButton;
    private Button nineButton;
    private Button zeroButton;
    private Button spaceButton;
    private Button ßButton;
    private Button deleteChar;

    private Button tabButton;
    private Button altButton;
    private Button shiftButton;
    private Button pfeilRechtsButton;
    private Button sternButton;


    public float buttonBlockeddel = 0;
    public float buttonBlockeda = 0;
    public float buttonBlockedb = 0;
    public float buttonBlockedc = 0;
    public float buttonBlockedd = 0;
    public float buttonBlockede = 0;
    public float buttonBlockedf = 0;
    public float buttonBlockedg = 0;
    public float buttonBlockedh = 0;
    public float buttonBlockedi = 0;
    public float buttonBlockedj = 0;
    public float buttonBlockedk = 0;
    public float buttonBlockedl = 0;
    public float buttonBlockedm = 0;
    public float buttonBlockedn = 0;
    public float buttonBlockedo = 0;
    public float buttonBlockedp = 0;
    public float buttonBlockedq = 0;
    public float buttonBlockedr = 0;
    public float buttonBlockeds = 0;
    public float buttonBlockedt = 0;
    public float buttonBlockedu = 0;
    public float buttonBlockedv = 0;
    public float buttonBlockedw = 0;
    public float buttonBlockedx = 0;
    public float buttonBlockedy = 0;
    public float buttonBlockedz = 0;
    public float buttonBlockedß = 0;
    public float buttonBlockedspace = 0;
    public float buttonBlockedone = 0;
    public float buttonBlockedtwo = 0;
    public float buttonBlockedthree = 0;
    public float buttonBlockedfour = 0;
    public float buttonBlockedfive = 0;
    public float buttonBlockedsix = 0;
    public float buttonBlockedseven = 0;
    public float buttonBlockedeight = 0;
    public float buttonBlockednine = 0;
    public float buttonBlockedzero = 0;

    public float buttonBlockedtab = 0;
    public float buttonBlockedshift = 0;
    public float buttonBlockedpfeilRechts = 0;
    public float buttonBlockedö = 0;
    public float buttonBlockedä = 0;
    public float buttonBlockedü = 0;
    public float buttonBlockedStrichPunkt = 0;
    public float buttonBlockedDoppelPunkt = 0;
    public float buttonBlockedUnterStrich = 0;
    public float buttonBlockedAlt = 0;
    public float buttonBlockedStern = 0;
    public float buttonBlockedHochChar = 0;



    private bool partTrueID = true;

    void Start()
    {
        if(GetComponent<ArrowInputFieldPostStudy>().wasActive == true)
        {
            InputSelected = GetComponent<ArrowInputFieldPostStudy>().InputSelected;
            GetComponent<ArrowInputFieldPostStudy>().wasActive = false;
        }
        if(GetComponent<LowerKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<LowerKeyboardInput>().InputSelected;
            GetComponent<LowerKeyboardInput>().wasActive = false;
        }
        participantID = participant.GetComponent<Text>().text;
        if (partTrueID)
        {
            participantNumberReal = canvasForPartID.GetComponent<ManageParticipantID>().participantNumber;
            participantID = participant.GetComponent<Text>().text;
            file = file + participantNumberReal + ".txt";
            partTrueID = false;
        }

        button = objectButton.GetComponent<Button>();
        distractionText = distraction.GetComponent<TMP_InputField>().text;
        distractionOnScreenText = distractionOnScreen.GetComponent<TMP_InputField>().text;
        difficultyStudyText = difficultyStudy.GetComponent<TMP_InputField>().text;
        answerWrongText = answerWrong.GetComponent<TMP_InputField>().text;
        moreInstructionText = moreInstruction.GetComponent<TMP_InputField>().text;
        vrCameraText = vrCamera.GetComponent<TMP_InputField>().text;

        switch (InputSelected)
        {
            case 0:
                difficultyStudy.Select();
                break;
            case 1:
                answerWrong.Select();
                break;
            case 2:
                moreInstruction.GetComponent<TMP_InputField>().Select();
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
        buttonArrowUp = arrowUpKey.GetComponent<Button>();
        buttonArrowDown = arrowDownKey.GetComponent<Button>();
        deleteChar = deleteOneChar.GetComponent<Button>();
        eButton = e.GetComponent<Button>();
        mButton = m.GetComponent<Button>();
        qButton = q.GetComponent<Button>();
        ßButton = ß.GetComponent<Button>();
        spaceButton = space.GetComponent<Button>();
        twoButton = two.GetComponent<Button>();
        threeButton = three.GetComponent<Button>();
        sevenButton = seven.GetComponent<Button>();
        eightButton = eight.GetComponent<Button>();
        nineButton = nine.GetComponent<Button>();
        zeroButton = zero.GetComponent<Button>();

        tabButton = tabulator.GetComponent<Button>();
        shiftButton = shift.GetComponent<Button>();
        pfeilRechtsButton = pfeilRechts.GetComponent<Button>();
        sternButton = stern.GetComponent<Button>();
        altButton = alt.GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<ArrowInputFieldPostStudy>().wasActive == true)
        {
            InputSelected = GetComponent<ArrowInputFieldPostStudy>().InputSelected;
            GetComponent<ArrowInputFieldPostStudy>().wasActive = false;
        }
        if (GetComponent<LowerKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<LowerKeyboardInput>().InputSelected;
            GetComponent<LowerKeyboardInput>().wasActive = false;
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
                moreInstruction.GetComponent<TMP_InputField>().Select();
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
        buttonBlockedDown += Time.deltaTime;
        buttonBlockedUp += Time.deltaTime;
        buttonBlockeda += Time.deltaTime;
        buttonBlockedb += Time.deltaTime;
        buttonBlockedc += Time.deltaTime;
        buttonBlockedd += Time.deltaTime;
        buttonBlockede += Time.deltaTime;
        buttonBlockedf += Time.deltaTime;
        buttonBlockedg += Time.deltaTime;
        buttonBlockedh += Time.deltaTime;
        buttonBlockedi += Time.deltaTime;
        buttonBlockedj += Time.deltaTime;
        buttonBlockedk += Time.deltaTime;
        buttonBlockedl += Time.deltaTime;
        buttonBlockedm += Time.deltaTime;
        buttonBlockedn += Time.deltaTime;
        buttonBlockedo += Time.deltaTime;
        buttonBlockedp += Time.deltaTime;
        buttonBlockedq += Time.deltaTime;
        buttonBlockedr += Time.deltaTime;
        buttonBlockeds += Time.deltaTime;
        buttonBlockedt += Time.deltaTime;
        buttonBlockedu += Time.deltaTime;
        buttonBlockedv += Time.deltaTime;
        buttonBlockedw += Time.deltaTime;
        buttonBlockedx += Time.deltaTime;
        buttonBlockedy += Time.deltaTime;
        buttonBlockedz += Time.deltaTime;
        buttonBlockedspace += Time.deltaTime;
        buttonBlockedzero += Time.deltaTime;
        buttonBlockedone += Time.deltaTime;
        buttonBlockedtwo += Time.deltaTime;
        buttonBlockedthree += Time.deltaTime;
        buttonBlockedfour += Time.deltaTime;
        buttonBlockedfive += Time.deltaTime;
        buttonBlockedsix += Time.deltaTime;
        buttonBlockedseven += Time.deltaTime;
        buttonBlockedeight += Time.deltaTime;
        buttonBlockednine += Time.deltaTime;
        buttonBlockedß += Time.deltaTime;
        buttonBlockeddel += Time.deltaTime;

        buttonBlockedStrichPunkt += Time.deltaTime;
        buttonBlockedStern += Time.deltaTime;
        buttonBlockedtab += Time.deltaTime;
        buttonBlockedshift += Time.deltaTime;
        buttonBlockedUnterStrich += Time.deltaTime;
        buttonBlockedpfeilRechts += Time.deltaTime;
        buttonBlockedä += Time.deltaTime;
        buttonBlockedü += Time.deltaTime;
        buttonBlockedö += Time.deltaTime;
        buttonBlockedHochChar += Time.deltaTime;
        buttonBlockedDoppelPunkt += Time.deltaTime;
        buttonBlockedAlt += Time.deltaTime;

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

        if (moreInstruction.GetComponent<TMP_InputField>().text.Trim().Length == 0)
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

        if (!(moreInstruction.GetComponent<TMP_InputField>().text.Trim().Length == 0))
        {
            moreInstructionObject.SetActive(false);
        }

        if (!(vrCamera.text.Trim().Length == 0))
        {
            vrCameraObject.SetActive(false);
        }
        if (!(distraction.text.Trim().Length == 0) && !(distractionOnScreen.text.Trim().Length == 0) && !(difficultyStudy.text.Trim().Length == 0) && !(answerWrong.text.Trim().Length == 0) && !(moreInstruction.GetComponent<TMP_InputField>().text.Trim().Length == 0) && !(vrCamera.text.Trim().Length == 0))
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
            lowerKeyboard.SetActive(false);
            altKeyboard.SetActive(false);
            upperKeyboard.SetActive(false);
            endButton.SetActive(true);
            SaveToFile();

        }
    }

    public void upperInputField()
    {
        if (buttonArrowUp.enabled == true)
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
                    moreInstruction.GetComponent<TMP_InputField>().Select();
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
            buttonBlockedUp = 0;
        }
        if (buttonBlockedUp > 1f)
        {
            buttonArrowUp.enabled = true;
        }

        buttonArrowUp.interactable = false;
        Invoke("ReActivateArrowUp", 1f);
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
                    moreInstruction.GetComponent<TMP_InputField>().Select();
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
            buttonBlockedDown = 0;
        }
        if (buttonBlockedDown > 1f)
        {
            buttonArrowDown.enabled = true;
        }

        buttonArrowDown.interactable = false;
        Invoke("ReActivateArrowDown", 1f);
    }

    public void writeE()
    {

        if (eButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "€";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "€";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "€";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "€";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "€";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "€";
            }
            eButton.enabled = false;
            buttonBlockede = 0;
        }
        if (buttonBlockede > 1f)
        {
            eButton.enabled = true;
        }
        eButton.interactable = false;
        Invoke("ReActivateE", 1f);

    } 

    public void writeM()
    {

        if (mButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "µ";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "µ";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "µ";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "µ";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "µ";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "µ";
            }
            mButton.enabled = false;
            buttonBlockedm = 0;
        }
        if (buttonBlockedm > 1f)
        {
            mButton.enabled = true;
        }
        mButton.interactable = false;
        Invoke("ReActivateM", 1f);

    }

   

    public void writeQ()
    {

        if (qButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "@";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "@";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "@";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "@";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "@";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "@";
            }
            qButton.enabled = false;
            buttonBlockedq = 0;
        }
        if (buttonBlockedq > 1f)
        {
            qButton.enabled = true;
        }
        qButton.interactable = false;
        Invoke("ReActivateQ", 1f);

    }


    public void writeTwo()
    {

        if (twoButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "²";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "²";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "²";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "²";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "²";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "²";
            }
            twoButton.enabled = false;
            buttonBlockedtwo = 0;
        }
        if (buttonBlockedtwo > 1f)
        {
            twoButton.enabled = true;
        }
        twoButton.interactable = false;
        Invoke("ReActivateTwo", 1f);

    }

    public void writeThree()
    {

        if (threeButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "³";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "³";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "³";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "³";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "³";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "³";
            }
            threeButton.enabled = false;
            buttonBlockedthree = 0;
        }
        if (buttonBlockedthree > 1f)
        {
            threeButton.enabled = true;
        }
        threeButton.interactable = false;
        Invoke("ReActivateThree", 1f);

    }

    

    public void writeSeven()
    {

        if (sevenButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "{";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "{";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "{";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "{";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "{";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "{";
            }
            sevenButton.enabled = false;
            buttonBlockedseven = 0;
        }
        if (buttonBlockedseven > 1f)
        {
            sevenButton.enabled = true;
        }
        sevenButton.interactable = false;
        Invoke("ReActivateSeven", 1f);

    }

    public void writeEight()
    {

        if (eightButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "[";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "[";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "[";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "[";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "[";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "[";
            }
            eightButton.enabled = false;
            buttonBlockedeight = 0;
        }
        if (buttonBlockedeight > 1f)
        {
            eightButton.enabled = true;
        }
        eightButton.interactable = false;
        Invoke("ReActivateEight", 1f);

    }

    public void writeNine()
    {

        if (nineButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "]";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "]";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "]";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "]";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "]";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "]";
            }
            nineButton.enabled = false;
            buttonBlockednine = 0;
        }
        if (buttonBlockednine > 1f)
        {
            nineButton.enabled = true;
        }
        nineButton.interactable = false;
        Invoke("ReActivateNine", 1f);

    }

    public void writeZero()
    {

        if (zeroButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "}";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "}";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "}";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "}";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "}";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "}";
            }
            zeroButton.enabled = false;
            buttonBlockedzero = 0;
        }
        if (buttonBlockedzero > 1f)
        {
            zeroButton.enabled = true;
        }
        zeroButton.interactable = false;
        Invoke("ReActivateZero", 1f);

    }

    public void writeß()
    {

        if (ßButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "\\";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "\\";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "\\";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "\\";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "\\";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "\\";
            }
            ßButton.enabled = false;
            buttonBlockedß = 0;
        }
        if (buttonBlockedß > 1f)
        {
            ßButton.enabled = true;
        }
        ßButton.interactable = false;
        Invoke("ReActivateß", 1f);

    }

    public void writeSpace()
    {

        if (spaceButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += " ";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += " ";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += " ";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += " ";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += " ";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += " ";
            }
            spaceButton.enabled = false;
            buttonBlockedspace = 0;
        }
        if (buttonBlockedspace > 1f)
        {
            spaceButton.enabled = true;
        }
        spaceButton.interactable = false;
        Invoke("ReActivateSpace", 1f);

    }

    public void writePfeilRechts()
    {
        if (pfeilRechtsButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "|";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "|";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "|";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "|";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "|";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "|";
            }
            pfeilRechtsButton.enabled = false;
            buttonBlockedpfeilRechts = 0;
        }
        if (buttonBlockedpfeilRechts > 1f)
        {
            pfeilRechtsButton.enabled = true;
        }
        pfeilRechtsButton.interactable = false;
        Invoke("ReActivatePfeilRechts", 1f);
    }

   

    public void writeStern()
    {
        if (sternButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "~";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "~";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "~";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "~";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "~";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "~";
            }
            sternButton.enabled = false;
            buttonBlockedStern = 0;
        }
        if (buttonBlockedStern > 1f)
        {
            sternButton.enabled = true;
        }
        sternButton.interactable = false;
        Invoke("ReActivateStern", 1f);
    }

    public void writeAlt()
    {
        if (altButton.enabled == true)
        {


            if (altKeyboard.activeSelf)
            {
                altKeyboard.SetActive(false);
                lowerKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<AltKeyboardInput>().enabled = false;
                GetComponent<LowerKeyboardInput>().enabled = true;
            }
            altButton.enabled = false;
            buttonBlockedAlt = 0;
        }
        if (buttonBlockedAlt > 1f)
        {
            altButton.enabled = true;
        }
        altButton.interactable = false;
        Invoke("ReActivateAlt", 1f);
    }

    public void writeShift()
    {
        if (shiftButton.enabled == true)
        {

            if (altKeyboard.activeSelf)
            {
                altKeyboard.SetActive(false);
                lowerKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<AltKeyboardInput>().enabled = false;
                GetComponent<LowerKeyboardInput>().enabled = true;
            }
            shiftButton.enabled = false;
            buttonBlockedshift = 0;
        }
        if (buttonBlockedshift > 1f)
        {
            shiftButton.enabled = true;
        }
        shiftButton.interactable = false;
        Invoke("ReActivateShift", 1f);
    }

   

    public void writeTabulator()
    {
        if (tabButton.enabled == true)
        {
            InputSelected += 1;
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
                    moreInstruction.GetComponent<TMP_InputField>().Select();
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
            tabButton.enabled = false;
            buttonBlockedtab = 0;
        }
        if (buttonBlockedtab > 1f)
        {
            tabButton.enabled = true;
        }
        tabButton.interactable = false;
        Invoke("ReActivateTab", 1f);
    }


    public void deleteOneCharacter()
    {

        if (deleteChar.enabled == true)
        {
            if (difficultyStudy.isFocused && (difficultyStudy.GetComponent<TMP_InputField>().text.Length > 0))
            {
                difficultyStudy.GetComponent<TMP_InputField>().text = difficultyStudy.GetComponent<TMP_InputField>().text.Substring(0, difficultyStudy.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (distraction.isFocused && (distraction.GetComponent<TMP_InputField>().text.Length > 0))
            {
                distraction.GetComponent<TMP_InputField>().text = distraction.GetComponent<TMP_InputField>().text.Substring(0, distraction.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (distractionOnScreen.isFocused && (distractionOnScreen.GetComponent<TMP_InputField>().text.Length > 0))
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text = distractionOnScreen.GetComponent<TMP_InputField>().text.Substring(0, distractionOnScreen.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (answerWrong.isFocused && (answerWrong.GetComponent<TMP_InputField>().text.Length > 0))
            {
                answerWrong.GetComponent<TMP_InputField>().text = answerWrong.GetComponent<TMP_InputField>().text.Substring(0, answerWrong.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused && (moreInstruction.GetComponent<TMP_InputField>().text.Length > 0))
            {
                moreInstruction.GetComponent<TMP_InputField>().text = moreInstruction.GetComponent<TMP_InputField>().text.Substring(0, moreInstruction.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (vrCamera.isFocused && (vrCamera.GetComponent<TMP_InputField>().text.Length > 0))
            {
                vrCamera.GetComponent<TMP_InputField>().text = vrCamera.GetComponent<TMP_InputField>().text.Substring(0, vrCamera.GetComponent<TMP_InputField>().text.Length - 1);
            }
            deleteChar.enabled = false;
            buttonBlockeddel = 0;
        }
        if (buttonBlockeddel > 1f)
        {
            deleteChar.enabled = true;
        }
        deleteChar.interactable = false;
        Invoke("ReActivateDelChar", 1f);

    }

    public void ReActivateArrowDown()
    {
        buttonArrowDown.interactable = true;
    }

    public void ReActivateArrowUp()
    {
        buttonArrowUp.interactable = true;
    }

   
    public void ReActivateE()
    {
        eButton.interactable = true;
    }

   
    public void ReActivateM()
    {
        mButton.interactable = true;
    }


    public void ReActivateQ()
    {
        qButton.interactable = true;
    }


    public void ReActivateTwo()
    {
        twoButton.interactable = true;
    }

    public void ReActivateThree()
    {
        threeButton.interactable = true;
    }

    public void ReActivateSeven()
    {
        sevenButton.interactable = true;
    }

    public void ReActivateEight()
    {
        eightButton.interactable = true;
    }

    public void ReActivateNine()
    {
        nineButton.interactable = true;
    }

    public void ReActivateZero()
    {
        zeroButton.interactable = true;
    }

    public void ReActivateß()
    {
        ßButton.interactable = true;
    }

    public void ReActivateSpace()
    {
        spaceButton.interactable = true;
    }

    public void ReActivateDelChar()
    {
        deleteChar.interactable = true;
    }

    public void ReActivatePfeilRechts()
    {
        pfeilRechtsButton.interactable = true;
    }

    public void ReActivateShift()
    {
        shiftButton.interactable = true;
    }

    public void ReActivateAlt()
    {
        altButton.interactable = true;
    }

    public void ReActivateStern()
    {
        sternButton.interactable = true;
    }

    public void ReActivateTab()
    {
        tabButton.interactable = true;
    }

    public string ToCSVPostStudy(string partID, string difficulty, string wrongAnser, string moreInstruction, string distraction, string distractionOnScreen, string cameraVR)
    {
        var sb = new StringBuilder("Participant_ID, Difficulty, Wrong_answer, More_instruction, Distraction_overall, Distraction_on_screen, VR_camera");
        sb.Append('\n').Append(partID.ToString()).Append(" ").Append(difficulty.ToString()).Append(" ").Append(wrongAnser.ToString()).Append(" ").Append(moreInstruction.ToString()).Append(" ").Append(distraction.ToString()).Append(" ").Append(distractionOnScreen.ToString()).Append(" ").Append(cameraVR.ToString());
        return sb.ToString();

    }

    public void SaveToFile()
    {
        var content = ToCSVPostStudy(participantID, difficultyStudy.GetComponent<TMP_InputField>().text, answerWrong.GetComponent<TMP_InputField>().text, moreInstruction.GetComponent<TMP_InputField>().text, distraction.GetComponent<TMP_InputField>().text, distractionOnScreen.GetComponent<TMP_InputField>().text, vrCamera.GetComponent<TMP_InputField>().text);
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
            Debug.Log(" Write CSV");
            Debug.Log("Filepath: " + path);
        }

    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
