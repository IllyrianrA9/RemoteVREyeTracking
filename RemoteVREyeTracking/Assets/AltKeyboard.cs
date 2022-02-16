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
    public GameObject newLowerKeyboard;
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
    public StringBuilder sb;
    public float timeForCSV;

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

    public string file;
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

    //public GameObject endButton;
    public GameObject paypalDistract;
    public GameObject paypalNoDistract;
    public GameObject keyboard;
    //public GameObject canvasKeyboard;

    //public GameObject paypalDistractKeyboard;

    public int InputSelected;

    //public GameObject arrowUpKey;
    //public GameObject arrowDownKey;
    public Button buttonArrowUp;
    public Button buttonArrowDown;

    private string distractionText;
    private string distractionOnScreenText;
    private string difficultyStudyText;

    //public float universalBlockDown = 0;
    //public float universalBlockUp = 0;
    // Start is called before the first frame update


    //public GameObject e;
    //public GameObject q;
    //public GameObject m;
    //public GameObject space;
    //public GameObject ß;
    //public GameObject two;
    //public GameObject three;
    //public GameObject zero;
    //public GameObject seven;
    //public GameObject eight;
    //public GameObject nine;
    //public GameObject deleteOneChar;

    //public GameObject tabulator;
    //public GameObject shift;
    //public GameObject pfeilRechts;
    //public GameObject stern;
    //public GameObject alt;


    public Button eButton;
    public Button mButton;
    public Button qButton;
    public Button twoButton;
    public Button threeButton;
    public Button sevenButton;
    public Button eightButton;
    public Button nineButton;
    public Button zeroButton;
    public Button spaceButton;
    public Button ßButton;
    public Button deleteChar;

    public Button tabButton;
    public Button altButton;
    public Button shiftButton;
    public Button pfeilRechtsButton;
    public Button sternButton;

    public float universalBlock = 0;
    //public float universalBlock = 0;
    //public float universalBlocka = 0;
    //public float universalBlockb = 0;
    //public float universalBlockc = 0;
    //public float universalBlockd = 0;
    //public float universalBlocke = 0;
    //public float universalBlockf = 0;
    //public float universalBlockg = 0;
    //public float universalBlockh = 0;
    //public float universalBlocki = 0;
    //public float universalBlockj = 0;
    //public float universalBlockk = 0;
    //public float universalBlockl = 0;
    //public float universalBlockm = 0;
    //public float universalBlockn = 0;
    //public float universalBlocko = 0;
    //public float universalBlockp = 0;
    //public float universalBlockq = 0;
    //public float universalBlockr = 0;
    //public float universalBlocks = 0;
    //public float universalBlockt = 0;
    //public float universalBlocku = 0;
    //public float universalBlockv = 0;
    //public float universalBlockw = 0;
    //public float universalBlockx = 0;
    //public float universalBlocky = 0;
    //public float universalBlockz = 0;
    //public float universalBlockß = 0;
    //public float universalBlockspace = 0;
    //public float universalBlockone = 0;
    //public float universalBlocktwo = 0;
    //public float universalBlockthree = 0;
    //public float universalBlockfour = 0;
    //public float universalBlockfive = 0;
    //public float universalBlocksix = 0;
    //public float universalBlockseven = 0;
    //public float universalBlockeight = 0;
    //public float universalBlocknine = 0;
    //public float universalBlockzero = 0;

    //public float universalBlocktab = 0;
    //public float universalBlockshift = 0;
    //public float universalBlockpfeilRechts = 0;
    //public float universalBlockö = 0;
    //public float universalBlockä = 0;
    //public float universalBlockü = 0;
    //public float universalBlockStrichPunkt = 0;
    //public float universalBlockDoppelPunkt = 0;
    //public float universalBlockUnterStrich = 0;
    //public float universalBlockAlt = 0;
    //public float universalBlockStern = 0;
    //public float universalBlockHochChar = 0;



    private bool partTrueID = true;

    void Start()
    {
        if ((paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV > paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<LowerKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<LowerKeyboard>().sb;
            InputSelected = GetComponent<LowerKeyboard>().InputSelected;
        }

        if ((paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV < paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<UpperKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<UpperKeyboard>().sb;
            InputSelected = GetComponent<UpperKeyboard>().InputSelected;
        }
        file = paypalNoDistract.GetComponent<LowerKeyboard>().file;
        currentBackgroundScreen.GetComponent<Renderer>().material = currentBackground;
    
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
        //buttonArrowUp = arrowUpKey.GetComponent<Button>();
        //buttonArrowDown = arrowDownKey.GetComponent<Button>();
        //deleteChar = deleteOneChar.GetComponent<Button>();
        //eButton = e.GetComponent<Button>();
        //mButton = m.GetComponent<Button>();
        //qButton = q.GetComponent<Button>();
        //ßButton = ß.GetComponent<Button>();
        //spaceButton = space.GetComponent<Button>();
        //twoButton = two.GetComponent<Button>();
        //threeButton = three.GetComponent<Button>();
        //sevenButton = seven.GetComponent<Button>();
        //eightButton = eight.GetComponent<Button>();
        //nineButton = nine.GetComponent<Button>();
        //zeroButton = zero.GetComponent<Button>();

        //tabButton = tabulator.GetComponent<Button>();
        //shiftButton = shift.GetComponent<Button>();
        //pfeilRechtsButton = pfeilRechts.GetComponent<Button>();
        //sternButton = stern.GetComponent<Button>();
        //altButton = alt.GetComponent<Button>();

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
        if ((paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV > paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<LowerKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<LowerKeyboard>().sb;
            InputSelected = GetComponent<LowerKeyboard>().InputSelected;
        }

        if ((paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<LowerKeyboard>().timeForCSV < paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<UpperKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<UpperKeyboard>().sb;
            InputSelected = GetComponent<UpperKeyboard>().InputSelected;
        }
        universalBlock += Time.deltaTime;
        //universalBlockDown += Time.deltaTime;
        //universalBlockUp += Time.deltaTime;
        //universalBlocka += Time.deltaTime;
        //universalBlockb += Time.deltaTime;
        //universalBlockc += Time.deltaTime;
        //universalBlockd += Time.deltaTime;
        //universalBlocke += Time.deltaTime;
        //universalBlockf += Time.deltaTime;
        //universalBlockg += Time.deltaTime;
        //universalBlockh += Time.deltaTime;
        //universalBlocki += Time.deltaTime;
        //universalBlockj += Time.deltaTime;
        //universalBlockk += Time.deltaTime;
        //universalBlockl += Time.deltaTime;
        //universalBlockm += Time.deltaTime;
        //universalBlockn += Time.deltaTime;
        //universalBlocko += Time.deltaTime;
        //universalBlockp += Time.deltaTime;
        //universalBlockq += Time.deltaTime;
        //universalBlockr += Time.deltaTime;
        //universalBlocks += Time.deltaTime;
        //universalBlockt += Time.deltaTime;
        //universalBlocku += Time.deltaTime;
        //universalBlockv += Time.deltaTime;
        //universalBlockw += Time.deltaTime;
        //universalBlockx += Time.deltaTime;
        //universalBlocky += Time.deltaTime;
        //universalBlockz += Time.deltaTime;
        //universalBlockspace += Time.deltaTime;
        //universalBlockzero += Time.deltaTime;
        //universalBlockone += Time.deltaTime;
        //universalBlocktwo += Time.deltaTime;
        //universalBlockthree += Time.deltaTime;
        //universalBlockfour += Time.deltaTime;
        //universalBlockfive += Time.deltaTime;
        //universalBlocksix += Time.deltaTime;
        //universalBlockseven += Time.deltaTime;
        //universalBlockeight += Time.deltaTime;
        //universalBlocknine += Time.deltaTime;
        //universalBlockß += Time.deltaTime;
        //universalBlock += Time.deltaTime;

        //universalBlockStrichPunkt += Time.deltaTime;
        //universalBlockStern += Time.deltaTime;
        //universalBlocktab += Time.deltaTime;
        //universalBlockshift += Time.deltaTime;
        //universalBlockUnterStrich += Time.deltaTime;
        //universalBlockpfeilRechts += Time.deltaTime;
        //universalBlockä += Time.deltaTime;
        //universalBlockü += Time.deltaTime;
        //universalBlockö += Time.deltaTime;
        //universalBlockHochChar += Time.deltaTime;
        //universalBlockDoppelPunkt += Time.deltaTime;
        //universalBlockAlt += Time.deltaTime;

        timeForCSV += Time.deltaTime * 1000;
        RaycastHit hit;
        
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
                if (hit.collider.gameObject.name == "Canvas" || hit.collider.gameObject.name == "BackgroundScreen")
                {
                    _gazeX = hit.point.x;
                    _gazeY = hit.point.y;
                    _gazeZ = hit.point.z;
                    csvDocumentation = ToCSVPostStudySmallInfo(timeForCSV, _gazeX, _gazeY, _gazeZ);
                }
            }
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
            //lowerKeyboard.SetActive(false);
            //altKeyboard.SetActive(false);
            //upperKeyboard.SetActive(false);
            //paypalDistractKeyboard.SetActive(true);
            //endButton.SetActive(true);
            newLowerKeyboard.SetActive(true);
            altKeyboard.SetActive(false);
            upperKeyboard.SetActive(false);
            lowerKeyboard.SetActive(false);
            csvDocumentation = ToCSVPostStudy(timeForCSV, _gazeX, _gazeY, _gazeZ, _input1_x, _input1_y, _input1_z, _input2_x, _input2_y, _input2_z, _input3_x, _input3_y, _input3_z, preferedTopic.GetComponent<TMP_Text>().text, difficultyStudy.text, distraction.text, theme.name, participantID); ;
            SaveToFile();

        }
    }

    public void upperInputField()
    {
        if (buttonArrowUp.enabled == true)
        {
            if (difficultyStudy.isFocused == true)
            {
                InputSelected = 0;
                InputSelected -= 1;
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

            }
            else if (distraction.isFocused == true)
            {
                InputSelected = 1;
                InputSelected -= 1;
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

            }
            else if (distractionOnScreen.isFocused == true)
            {
                InputSelected = 2;
                InputSelected -= 1;
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

            }
            buttonArrowUp.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            buttonArrowUp.enabled = true;
        }

        buttonArrowUp.interactable = false;
        Invoke("ReActivateArrowUp", 0.5f);
    }

    public void lowerInputField()
    {
        if (buttonArrowDown.enabled == true)
        {
            if (difficultyStudy.isFocused == true)
            {
                InputSelected = 0;
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

            }
            else if (distraction.isFocused == true)
            {
                InputSelected = 1;
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

            }
            else if (distractionOnScreen.isFocused == true)
            {
                InputSelected = 2;
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
            }
            buttonArrowDown.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            buttonArrowDown.enabled = true;
        }

        buttonArrowDown.interactable = false;
        Invoke("ReActivateArrowDown", 0.5f);
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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            eButton.enabled = true;
        }
        eButton.interactable = false;
        Invoke("ReActivateE", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            mButton.enabled = true;
        }
        mButton.interactable = false;
        Invoke("ReActivateM", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            qButton.enabled = true;
        }
        qButton.interactable = false;
        Invoke("ReActivateQ", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            twoButton.enabled = true;
        }
        twoButton.interactable = false;
        Invoke("ReActivateTwo", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            threeButton.enabled = true;
        }
        threeButton.interactable = false;
        Invoke("ReActivateThree", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            sevenButton.enabled = true;
        }
        sevenButton.interactable = false;
        Invoke("ReActivateSeven", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            eightButton.enabled = true;
        }
        eightButton.interactable = false;
        Invoke("ReActivateEight", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            nineButton.enabled = true;
        }
        nineButton.interactable = false;
        Invoke("ReActivateNine", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            zeroButton.enabled = true;
        }
        zeroButton.interactable = false;
        Invoke("ReActivateZero", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            ßButton.enabled = true;
        }
        ßButton.interactable = false;
        Invoke("ReActivateß", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            spaceButton.enabled = true;
        }
        spaceButton.interactable = false;
        Invoke("ReActivateSpace", 0.5f);

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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            pfeilRechtsButton.enabled = true;
        }
        pfeilRechtsButton.interactable = false;
        Invoke("ReActivatePfeilRechts", 0.5f);
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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            sternButton.enabled = true;
        }
        sternButton.interactable = false;
        Invoke("ReActivateStern", 0.5f);
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
                GetComponent<AltKeyboard>().enabled = false;
                GetComponent<LowerKeyboard>().enabled = true;
            }
            altButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            altButton.enabled = true;
        }
        altButton.interactable = false;
        Invoke("ReActivateAlt", 0.5f);
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
                GetComponent<AltKeyboard>().enabled = false;
                GetComponent<LowerKeyboard>().enabled = true;
            }
            shiftButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            shiftButton.enabled = true;
        }
        shiftButton.interactable = false;
        Invoke("ReActivateShift", 0.5f);
    }



    public void writeTabulator()
    {
        if (tabButton.enabled == true)
        {
            if (difficultyStudy.isFocused == true)
            {
                InputSelected = 0;
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

            }
            else if (distraction.isFocused == true)
            {
                InputSelected = 1;
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

            }
            else if (distractionOnScreen.isFocused == true)
            {
                InputSelected = 2;
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

            }
            tabButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            tabButton.enabled = true;
        }
        tabButton.interactable = false;
        Invoke("ReActivateTab", 0.5f);
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
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            deleteChar.enabled = true;
        }
        deleteChar.interactable = false;
        Invoke("ReActivateDelChar", 0.5f);

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

    public string ToCSVPostStudy(float csvTime, double xgaze, double ygaze, double zgaze, double xEmail, double yEmail, double zEmail, double xPw, double yPw, double zPw, double xconfpw, double yconfpw, double zconfpw, string prefTopic, string email, string pw, string backgroundScreenName, string partID)
    {
        //var sb = new StringBuilder("Participant_ID Time Scene X_Gaze Y_Gaze Z_Gaze X_Position_Email Y_Position_Email Z_Position_Email X_Position_PW Y_Position_PW Z_Position_PW X_Position_ConfirmedPW Y_Position_ConfirmedPW Z_Position_ConfirmedPW Prefered_Topic Email Password");
        sb.Append('\n').Append(csvTime.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString()).Append(" ").Append(xEmail.ToString()).Append(" ").Append(yEmail.ToString()).Append(" ").Append(zEmail.ToString()).Append(" ").Append(xPw.ToString()).Append(" ").Append(yPw.ToString()).Append(" ").Append(zPw.ToString()).Append(" ").Append(xconfpw.ToString()).Append(" ").Append(yconfpw.ToString()).Append(" ").Append(zconfpw.ToString()).Append(" ").Append(prefTopic.ToString()).Append(" ").Append(email.ToString()).Append(" ").Append(pw.ToString()).Append(" ").Append(backgroundScreenName.ToString()).Append(" ").Append(partID.ToString());
        return sb.ToString();

    }

    public string ToCSVPostStudyNoEmail(string partID, float csvTime, string backgroundScreenName, double xgaze, double ygaze, double zgaze, double xEmail, double yEmail, double zEmail, double xPw, double yPw, double zPw, double xconfpw, double yconfpw, double zconfpw, string prefTopic)
    {
        sb.Append('\n').Append(partID.ToString()).Append(" ").Append(csvTime.ToString()).Append(" ").Append(backgroundScreenName.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString()).Append(" ").Append(xEmail.ToString()).Append(" ").Append(yEmail.ToString()).Append(" ").Append(zEmail.ToString()).Append(" ").Append(xPw.ToString()).Append(" ").Append(yPw.ToString()).Append(" ").Append(zPw.ToString()).Append(" ").Append(xconfpw.ToString()).Append(" ").Append(yconfpw.ToString()).Append(" ").Append(zconfpw.ToString()).Append(" ").Append(prefTopic.ToString());
        return sb.ToString();
    }

    public string ToCSVPostStudySmallInfo(float csvTime, double xgaze, double ygaze, double zgaze)
    {
        sb.Append('\n').Append(csvTime.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString());
        return sb.ToString();
    }

    public void SaveToFile()
    {
        var content = csvDocumentation;
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(csvDocumentation);
            Debug.Log(" Write CSV");
            Debug.Log("Filepath: " + path);
        }

    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
