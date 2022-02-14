using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;
using Tobii.G2OM;
using Tobii.XR;

public class AltKeyboard : MonoBehaviour
{
    public GameObject theme;
    private double _input1_x;
    private double _input1_y;
    private double _input1_z;

    private double _input2_x;
    private double _input2_y;
    private double _input2_z;

    private double _input3_x;
    private double _input3_y;
    private double _input3_z;
    //x, y and z coordinate of the eye gaze
    private double _gazeX;
    private double _gazeY;
    private double _gazeZ;

    public GameObject preferedTopic;


    public string csvDocumentation;
    public StringBuilder sb = new StringBuilder("Participant_ID Time Scene X_Gaze Y_Gaze Z_Gaze X_Position_Email Y_Position_Email Z_Position_Email X_Position_PW Y_Position_PW Z_Position_PW X_Position_ConfirmedPW Y_Position_ConfirmedPW Z_Position_ConfirmedPW Prefered_Topic Email Password");
    public float timeForCSV = 0;

    //public GameObject showPreference1;
    public GameObject currentBackgroundScreen;
    public Material currentBackground;

    public GameObject nextBackgroundScreen;
    public Material nextBackground;

    public bool wasActive = false;
    public GameObject lowerKeyboard;
    public GameObject altKeyboard;
    public GameObject upperKeyboard;
    public GameObject canvasForPartID;
    private int participantNumberReal;

    public string file = "Registration";
    public GameObject participant;
    private string participantID;

    public GameObject input1;
    public GameObject input2;
    public GameObject input3;

    public InputField distraction;
    public InputField distractionOnScreen;
    public InputField difficultyStudy;
    public GameObject objectButton;
    private Button button;

    //public GameObject distractionObject;
    //public GameObject distractionOnSObject;
    //public GameObject difficultyStudyObject;

    public GameObject endButton;
    public GameObject paypalDistract;
    public GameObject paypalNoDistract;
    public GameObject keyboard;
    public GameObject canvasKeyboard;

    public GameObject paypalDistractKeyboard;

    public int InputSelected;

    public GameObject arrowUpKey;
    public GameObject arrowDownKey;
    private Button buttonArrowUp;
    private Button buttonArrowDown;

    private string distractionText;
    private string distractionOnScreenText;
    private string difficultyStudyText;

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
        currentBackgroundScreen.GetComponent<Renderer>().material = currentBackground;
        if (GetComponent<UpperKeyboard>().wasActive == true)
        {
            InputSelected = GetComponent<UpperKeyboard>().InputSelected;
            GetComponent<UpperKeyboard>().wasActive = false;
        }
        if (GetComponent<LowerKeyboard>().wasActive == true)
        {
            InputSelected = GetComponent<LowerKeyboard>().InputSelected;
            GetComponent<LowerKeyboard>().wasActive = false;
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
        distractionText = distraction.GetComponent<InputField>().text;
        distractionOnScreenText = distractionOnScreen.GetComponent<InputField>().text;
        difficultyStudyText = difficultyStudy.GetComponent<InputField>().text;

        switch (InputSelected)
        {
            case 0:
                difficultyStudy.Select();
                break;
            case 1:
                distraction.Select();
                break;
            case 2:
                distractionOnScreen.Select();
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

        _input1_x = input1.transform.position.x;
        _input1_y = input1.transform.position.y;
        _input1_z = input1.transform.position.z;

        _input2_x = input2.transform.position.x;
        _input2_y = input2.transform.position.y;
        _input2_z = input2.transform.position.z;

        _input3_x = input3.transform.position.x;
        _input3_y = input3.transform.position.y;
        _input3_z = input3.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        if (difficultyStudy.isFocused == true)
        {
            InputSelected = 0;
        }
        if (distraction.isFocused == true)
        {
            InputSelected = 1;
        }
        if (distractionOnScreen.isFocused == true)
        {
            InputSelected = 2;
        }
        if (GetComponent<UpperKeyboard>().wasActive == true)
        {
            InputSelected = GetComponent<UpperKeyboard>().InputSelected;
            GetComponent<UpperKeyboard>().wasActive = false;
        }
        if (GetComponent<LowerKeyboard>().wasActive == true)
        {
            InputSelected = GetComponent<LowerKeyboard>().InputSelected;
            GetComponent<LowerKeyboard>().wasActive = false;
        }
        switch (InputSelected)
        {
            case 0:
                difficultyStudy.Select();
                break;
            case 1:
                distraction.Select();
                break;
            case 2:
                distractionOnScreen.Select();
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

        timeForCSV += Time.deltaTime * 1000;
        RaycastHit hit;
        GameObject desktop = null;
        var eyeTrackingData = TobiiXR.GetEyeTrackingData(TobiiXR_TrackingSpace.World);

        // Check if gaze ray is valid
        if (eyeTrackingData.GazeRay.IsValid)
        {
            // The origin of the gaze ray is a 3D point
            var rayOrigin = eyeTrackingData.GazeRay.Origin;

            // The direction of the gaze ray is a normalized direction Vector3
            var rayDirection = eyeTrackingData.GazeRay.Direction;

            // For social use cases, data in local space may be easier to work with
            var eyeTrackingDataLocal = TobiiXR.GetEyeTrackingData(TobiiXR_TrackingSpace.Local);
            var rayOriginLocal = eyeTrackingDataLocal.GazeRay.Origin;
            var rayDirectionLocal = eyeTrackingDataLocal.GazeRay.Direction;

            //getting hit point of eye gaze on Background Screen
            if (Physics.Raycast(rayOrigin, rayDirection, out hit, Mathf.Infinity))
            {
                desktop = hit.collider.gameObject;
                _gazeX = hit.point.x;
                _gazeY = hit.point.y;
                _gazeZ = hit.point.z;
            }
            csvDocumentation = ToCSVPostStudyNoEmail(participantID, timeForCSV, theme.name, _gazeX, _gazeY, _gazeZ, _input1_x, _input1_y, _input1_z, _input2_x, _input2_y, _input2_z, _input3_x, _input3_y, _input3_z, preferedTopic.GetComponent<Text>().text);
        }
    }

    public void filledIn()
    {
        if (distraction.text.Trim().Length < 8)
        {

        }

        if (distractionOnScreen.text.Trim().Length == 0)
        {
            
        }

        if (difficultyStudy.text.Trim().Length == 0)
        {
            
        }

        if (!(distraction.text.Trim().Length == 0))
        {

        }

        if (!(distractionOnScreen.text.Trim().Length == 0))
        {
            
        }

        if (!(difficultyStudy.text.Trim().Length == 0))
        {
           
        }
        if (!(distraction.text.Trim().Length == 0) && !(distractionOnScreen.text.Trim().Length == 0) && !(difficultyStudy.text.Trim().Length == 0))
        {
            nextBackgroundScreen.GetComponent<Renderer>().material = nextBackground;
            //Hier kommen die zu nutzenden Objekte
            paypalDistract.SetActive(true);
            paypalNoDistract.SetActive(false);
            //keyboard.SetActive(false);
            //canvasKeyboard.SetActive(false);
            lowerKeyboard.SetActive(false);
            altKeyboard.SetActive(false);
            upperKeyboard.SetActive(false);
            paypalDistractKeyboard.SetActive(true);
            //endButton.SetActive(true);
            csvDocumentation = ToCSVPostStudy(participantID, timeForCSV, theme.name, _gazeX, _gazeY, _gazeZ, _input1_x, _input1_y, _input1_z, _input2_x, _input2_y, _input2_z, _input3_x, _input3_y, _input3_z, preferedTopic.GetComponent<Text>().text, difficultyStudy.text, distraction.text);
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
                InputSelected = 2;
            }
            switch (InputSelected)
            {
                case 0:
                    difficultyStudy.Select();
                    break;
                case 1:
                    distraction.Select();
                    break;
                case 2:
                    distractionOnScreen.Select();
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
            if (InputSelected > 2)
            {
                InputSelected = 0;
            }

            switch (InputSelected)
            {
                case 0:
                    difficultyStudy.Select();
                    break;
                case 1:
                    distraction.Select();
                    break;
                case 2:
                    distractionOnScreen.Select();
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
                difficultyStudy.GetComponent<InputField>().text += "€";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "€";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "€";
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
                difficultyStudy.GetComponent<InputField>().text += "µ";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "µ";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "µ";
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
                difficultyStudy.GetComponent<InputField>().text += "@";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "@";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "@";
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
                difficultyStudy.GetComponent<InputField>().text += "²";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "²";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "²";
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
                difficultyStudy.GetComponent<InputField>().text += "³";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "³";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "³";
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
                difficultyStudy.GetComponent<InputField>().text += "{";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "{";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "{";
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
                difficultyStudy.GetComponent<InputField>().text += "[";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "[";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "[";
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
                difficultyStudy.GetComponent<InputField>().text += "]";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "]";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "]";
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
                difficultyStudy.GetComponent<InputField>().text += "}";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "}";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "}";
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
                difficultyStudy.GetComponent<InputField>().text += "\\";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "\\";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "\\";
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
                difficultyStudy.GetComponent<InputField>().text += " ";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += " ";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += " ";
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
                difficultyStudy.GetComponent<InputField>().text += "|";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "|";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "|";
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
                difficultyStudy.GetComponent<InputField>().text += "~";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "~";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "~";
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
            if (InputSelected > 2)
            {
                InputSelected = 0;
            }
            switch (InputSelected)
            {
                case 0:
                    difficultyStudy.Select();
                    break;
                case 1:
                    distraction.Select();
                    break;
                case 2:
                    distractionOnScreen.Select();
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
            if (difficultyStudy.isFocused && (difficultyStudy.GetComponent<InputField>().text.Length > 0))
            {
                difficultyStudy.GetComponent<InputField>().text = difficultyStudy.GetComponent<InputField>().text.Substring(0, difficultyStudy.GetComponent<InputField>().text.Length - 1);
            }

            if (distraction.isFocused && (distraction.GetComponent<InputField>().text.Length > 0))
            {
                distraction.GetComponent<InputField>().text = distraction.GetComponent<InputField>().text.Substring(0, distraction.GetComponent<InputField>().text.Length - 1);
            }

            if (distractionOnScreen.isFocused && (distractionOnScreen.GetComponent<InputField>().text.Length > 0))
            {
                distractionOnScreen.GetComponent<InputField>().text = distractionOnScreen.GetComponent<InputField>().text.Substring(0, distractionOnScreen.GetComponent<InputField>().text.Length - 1);
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

    public string ToCSVPostStudy(string partID, float csvTime, string backgroundScreenName, double xgaze, double ygaze, double zgaze, double xEmail, double yEmail, double zEmail, double xPw, double yPw, double zPw, double xconfpw, double yconfpw, double zconfpw, string prefTopic, string email, string pw)
    {
        //var sb = new StringBuilder("Participant_ID Time Scene X_Gaze Y_Gaze Z_Gaze X_Position_Email Y_Position_Email Z_Position_Email X_Position_PW Y_Position_PW Z_Position_PW X_Position_ConfirmedPW Y_Position_ConfirmedPW Z_Position_ConfirmedPW Prefered_Topic Email Password");
        sb.Append('\n').Append(partID.ToString()).Append(" ").Append(csvTime.ToString()).Append(" ").Append(backgroundScreenName.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString()).Append(" ").Append(xEmail.ToString()).Append(" ").Append(yEmail.ToString()).Append(" ").Append(zEmail.ToString()).Append(" ").Append(xPw.ToString()).Append(" ").Append(yPw.ToString()).Append(" ").Append(zPw.ToString()).Append(" ").Append(xconfpw.ToString()).Append(" ").Append(yconfpw.ToString()).Append(" ").Append(zconfpw.ToString()).Append(" ").Append(prefTopic.ToString()).Append(" ").Append(email.ToString()).Append(" ").Append(pw.ToString());
        return sb.ToString();

    }

    public string ToCSVPostStudyNoEmail(string partID, float csvTime, string backgroundScreenName, double xgaze, double ygaze, double zgaze, double xEmail, double yEmail, double zEmail, double xPw, double yPw, double zPw, double xconfpw, double yconfpw, double zconfpw, string prefTopic)
    {
        sb.Append('\n').Append(partID.ToString()).Append(" ").Append(csvTime.ToString()).Append(" ").Append(backgroundScreenName.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString()).Append(" ").Append(xEmail.ToString()).Append(" ").Append(yEmail.ToString()).Append(" ").Append(zEmail.ToString()).Append(" ").Append(xPw.ToString()).Append(" ").Append(yPw.ToString()).Append(" ").Append(zPw.ToString()).Append(" ").Append(xconfpw.ToString()).Append(" ").Append(yconfpw.ToString()).Append(" ").Append(zconfpw.ToString()).Append(" ").Append(prefTopic.ToString());
        return sb.ToString();
    }

    public void SaveToFile()
    {
        var content = csvDocumentation;
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write("");
            Debug.Log(" Write CSV");
            Debug.Log("Filepath: " + path);
        }

    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
