using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;
using Tobii.G2OM;
using Tobii.XR;

public class LowerKeyboard : MonoBehaviour
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
    public GameObject textWithPrefTopic;

    public GameObject currentBackgroundScreen;
    public Material currentBackground;

    public GameObject nextBackgroundScreen;
    public Material nextBackground;

    public string csvDocumentation;
    public StringBuilder sb = new StringBuilder("Participant_ID Time Scene X_Gaze Y_Gaze Z_Gaze X_Position_Email Y_Position_Email Z_Position_Email X_Position_PW Y_Position_PW Z_Position_PW X_Position_ConfirmedPW Y_Position_ConfirmedPW Z_Position_ConfirmedPW Prefered_Topic Email Password");
    public float timeForCSV = 0;


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

    //public GameObject endButton;
    public GameObject paypalDistract;
    public GameObject paypalNoDistract;
    public GameObject keyboard;
    //public GameObject canvasKeyboard;
    //public GameObject paypalDistractKeyboard;

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

    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject i;
    public GameObject j;
    public GameObject k;
    public GameObject l;
    public GameObject m;
    public GameObject n;
    public GameObject o;
    public GameObject p;
    public GameObject q;
    public GameObject r;
    public GameObject s;
    public GameObject t;
    public GameObject u;
    public GameObject v;
    public GameObject w;
    public GameObject x;
    public GameObject y;
    public GameObject z;
    public GameObject space;
    public GameObject ß;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject zero;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject deleteOneChar;

    public GameObject tabulator;
    public GameObject shift;
    public GameObject pfeilRechts;
    public GameObject ö;
    public GameObject ä;
    public GameObject ü;
    public GameObject strichPunkt;
    public GameObject doppelPunkt;
    public GameObject unterStrich;
    public GameObject hochChar;
    public GameObject stern;
    public GameObject alt;


    private Button aButton;
    private Button bButton;
    private Button cButton;
    private Button dButton;
    private Button eButton;
    private Button fButton;
    private Button gButton;
    private Button hButton;
    private Button iButton;
    private Button jButton;
    private Button kButton;
    private Button lButton;
    private Button mButton;
    private Button nButton;
    private Button oButton;
    private Button pButton;
    private Button qButton;
    private Button rButton;
    private Button sButton;
    private Button tButton;
    private Button uButton;
    private Button vButton;
    private Button wButton;
    private Button xButton;
    private Button yButton;
    private Button zButton;
    private Button oneButton;
    private Button twoButton;
    private Button threeButton;
    private Button fourButton;
    private Button fiveButton;
    private Button sixButton;
    private Button sevenButton;
    private Button eightButton;
    private Button nineButton;
    private Button zeroButton;
    private Button spaceButton;
    private Button ßButton;
    private Button deleteChar;

    private Button tabButton;
    private Button öButton;
    private Button äButton;
    private Button üButton;
    private Button strichPunktButton;
    private Button doppelPunktButton;
    private Button altButton;
    private Button shiftButton;
    private Button pfeilRechtsButton;
    private Button unterStrichButton;
    private Button sternButton;
    private Button hochCharButton;


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
        textWithPrefTopic.GetComponent<TMP_Text>().text = "You can use the word \"" + preferedTopic.GetComponent<TMP_Text>().text + "\" to make your password personalized";
        currentBackgroundScreen.GetComponent<Renderer>().material = currentBackground; 
        if ((paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV < paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<AltKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<AltKeyboard>().sb;
            InputSelected = GetComponent<AltKeyboard>().InputSelected;
        }

        if ((paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV < paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<UpperKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<UpperKeyboard>().sb;
            InputSelected = GetComponent<UpperKeyboard>().InputSelected;
        }
        if (GetComponent<AltKeyboard>().wasActive == false && GetComponent<UpperKeyboard>().wasActive == false)
        {
            InputSelected = 0;
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
        aButton = a.GetComponent<Button>();
        bButton = b.GetComponent<Button>();
        cButton = c.GetComponent<Button>();
        dButton = d.GetComponent<Button>();
        eButton = e.GetComponent<Button>();
        fButton = f.GetComponent<Button>();
        gButton = g.GetComponent<Button>();
        hButton = h.GetComponent<Button>();
        iButton = i.GetComponent<Button>();
        jButton = j.GetComponent<Button>();
        kButton = k.GetComponent<Button>();
        lButton = l.GetComponent<Button>();
        mButton = m.GetComponent<Button>();
        nButton = n.GetComponent<Button>();
        oButton = o.GetComponent<Button>();
        pButton = p.GetComponent<Button>();
        qButton = q.GetComponent<Button>();
        rButton = r.GetComponent<Button>();
        sButton = s.GetComponent<Button>();
        tButton = t.GetComponent<Button>();
        uButton = u.GetComponent<Button>();
        vButton = v.GetComponent<Button>();
        wButton = w.GetComponent<Button>();
        xButton = x.GetComponent<Button>();
        yButton = y.GetComponent<Button>();
        zButton = z.GetComponent<Button>();
        ßButton = ß.GetComponent<Button>();
        spaceButton = space.GetComponent<Button>();
        oneButton = one.GetComponent<Button>();
        twoButton = two.GetComponent<Button>();
        threeButton = three.GetComponent<Button>();
        fourButton = four.GetComponent<Button>();
        fiveButton = five.GetComponent<Button>();
        sixButton = six.GetComponent<Button>();
        sevenButton = seven.GetComponent<Button>();
        eightButton = eight.GetComponent<Button>();
        nineButton = nine.GetComponent<Button>();
        zeroButton = zero.GetComponent<Button>();

        tabButton = tabulator.GetComponent<Button>();
        shiftButton = shift.GetComponent<Button>();
        pfeilRechtsButton = pfeilRechts.GetComponent<Button>();
        öButton = ö.GetComponent<Button>();
        äButton = ä.GetComponent<Button>();
        üButton = ü.GetComponent<Button>();
        strichPunktButton = strichPunkt.GetComponent<Button>();
        doppelPunktButton = doppelPunkt.GetComponent<Button>();
        unterStrichButton = unterStrich.GetComponent<Button>();
        hochCharButton = hochChar.GetComponent<Button>();
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
        //textWithPrefTopic.GetComponent<TMP_Text>().text = "You can use the word \"" + preferedTopic.GetComponent<TMP_Text>().text + "\" to make your password personalized";
        //currentBackgroundScreen.GetComponent<Renderer>().material = currentBackground;
        if ((paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV < paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<AltKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<AltKeyboard>().sb;
            InputSelected = GetComponent<AltKeyboard>().InputSelected;
        }

        if ((paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<AltKeyboard>().timeForCSV < paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<UpperKeyboard>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<UpperKeyboard>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<UpperKeyboard>().sb;
            InputSelected = GetComponent<UpperKeyboard>().InputSelected;
        }
        //if (difficultyStudy.isFocused == true)
        //{
            //InputSelected = 0;
          //  difficultyStudy.ActivateInputField();
        //}
        //if (distraction.isFocused == true)
        //{
           // InputSelected = 1;
         //   distraction.ActivateInputField();
        //}
        //if (distractionOnScreen.isFocused == true)
        //{
            //InputSelected = 2;
          //  distractionOnScreen.ActivateInputField();
        //}
        //if (GetComponent<UpperKeyboard>().wasActive == true)
        //{
          //  InputSelected = GetComponent<UpperKeyboard>().InputSelected;
            //GetComponent<UpperKeyboard>().wasActive = false;
        //}
        //if (GetComponent<AltKeyboard>().wasActive == true)
        //{
          //  InputSelected = GetComponent<AltKeyboard>().InputSelected;
            //GetComponent<AltKeyboard>().wasActive = false;
        //}
        //switch (InputSelected)
        //{
         //   case 0:
           //     difficultyStudy.Select();
             //   break;
            //case 1:
              //  distraction.Select();
                //break;
            //case 2:
              //  distractionOnScreen.Select();
                //break;
            
       // }
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
            csvDocumentation = ToCSVPostStudySmallInfo(participantID, timeForCSV, theme.name, _gazeX, _gazeY, _gazeZ);
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
            csvDocumentation = ToCSVPostStudy(participantID, timeForCSV, theme.name, _gazeX, _gazeY, _gazeZ, _input1_x, _input1_y, _input1_z, _input2_x, _input2_y, _input2_z, _input3_x, _input3_y, _input3_z, preferedTopic.GetComponent<TMP_Text>().text, difficultyStudy.text, distraction.text);
            SaveToFile();
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
            lowerKeyboard.SetActive(true);
            altKeyboard.SetActive(false);
            upperKeyboard.SetActive(false);
            //csvDocumentation = ToCSVPostStudy(participantID, timeForCSV, theme.name, _gazeX, _gazeY, _gazeZ, _input1_x, _input1_y, _input1_z, _input2_x, _input2_y, _input2_z, _input3_x, _input3_y, _input3_z, preferedTopic.GetComponent<Text>().text, difficultyStudy.text, distraction.text);
            //SaveToFile();

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
            buttonBlockedDown = 0;
        }
        if (buttonBlockedDown > 1f)
        {
            buttonArrowDown.enabled = true;
        }

        buttonArrowDown.interactable = false;
        Invoke("ReActivateArrowDown", 1f);
    }

    public void writeA()
    {

        if (aButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "a";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "a";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "a";
            }

            aButton.enabled = false;
            buttonBlockeda = 0;
        }
        if (buttonBlockeda > 1f)
        {
            aButton.enabled = true;
        }
        aButton.interactable = false;
        Invoke("ReActivateA", 1f);

    }

    public void writeB()
    {

        if (bButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "b";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "b";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "b";
            }

           
            bButton.enabled = false;
            buttonBlockedb = 0;
        }
        if (buttonBlockedb > 1f)
        {
            bButton.enabled = true;
        }
        bButton.interactable = false;
        Invoke("ReActivateB", 1f);

    }

    public void writeC()
    {

        if (cButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "c";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "c";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "c";
            }

            
            cButton.enabled = false;
            buttonBlockedc = 0;
        }
        if (buttonBlockedc > 1f)
        {
            cButton.enabled = true;
        }
        cButton.interactable = false;
        Invoke("ReActivateC", 1f);

    }

    public void writeD()
    {

        if (dButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "d";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "d";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "d";
            }

           
            dButton.enabled = false;
            buttonBlockedd = 0;
        }
        if (buttonBlockedd > 1f)
        {
            dButton.enabled = true;
        }
        dButton.interactable = false;
        Invoke("ReActivateD", 1f);

    }

    public void writeE()
    {

        if (eButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "e";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "e";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "e";
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

    public void writeF()
    {

        if (fButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "f";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "f";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "f";
            }

            
            fButton.enabled = false;
            buttonBlockedf = 0;
        }
        if (buttonBlockedf > 1f)
        {
            fButton.enabled = true;
        }
        fButton.interactable = false;
        Invoke("ReActivateF", 1f);

    }

    public void writeG()
    {

        if (gButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "g";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "g";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "g";
            }

            
            gButton.enabled = false;
            buttonBlockedg = 0;
        }
        if (buttonBlockedg > 1f)
        {
            gButton.enabled = true;
        }
        gButton.interactable = false;
        Invoke("ReActivateG", 1f);

    }

    public void writeH()
    {

        if (hButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "h";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "h";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "h";
            }

            
            hButton.enabled = false;
            buttonBlockedh = 0;
        }
        if (buttonBlockedh > 1f)
        {
            hButton.enabled = true;
        }
        hButton.interactable = false;
        Invoke("ReActivateH", 1f);

    }

    public void writeI()
    {

        if (iButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "i";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "i";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "i";
            }

            
            iButton.enabled = false;
            buttonBlockedi = 0;
        }
        if (buttonBlockedi > 1f)
        {
            iButton.enabled = true;
        }
        iButton.interactable = false;
        Invoke("ReActivateI", 1f);

    }

    public void writeJ()
    {

        if (jButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "j";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "j";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "j";
            }

           
            jButton.enabled = false;
            buttonBlockedj = 0;
        }
        if (buttonBlockedj > 1f)
        {
            jButton.enabled = true;
        }
        jButton.interactable = false;
        Invoke("ReActivateJ", 1f);

    }

    public void writeK()
    {

        if (kButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "k";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "k";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "k";
            }

            
            kButton.enabled = false;
            buttonBlockedk = 0;
        }
        if (buttonBlockedk > 1f)
        {
            kButton.enabled = true;
        }
        kButton.interactable = false;
        Invoke("ReActivateK", 1f);

    }

    public void writeL()
    {

        if (lButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "l";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "l";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "l";
            }

            
            lButton.enabled = false;
            buttonBlockedl = 0;
        }
        if (buttonBlockedl > 1f)
        {
            lButton.enabled = true;
        }
        lButton.interactable = false;
        Invoke("ReActivateL", 1f);

    }

    public void writeM()
    {

        if (mButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "m";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "m";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "m";
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

    public void writeN()
    {

        if (nButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "n";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "n";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "n";
            }

           
            nButton.enabled = false;
            buttonBlockedn = 0;
        }
        if (buttonBlockedn > 1f)
        {
            nButton.enabled = true;
        }
        nButton.interactable = false;
        Invoke("ReActivateN", 1f);

    }

    public void writeO()
    {

        if (oButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "o";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "o";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "o";
            }

            
            oButton.enabled = false;
            buttonBlockedo = 0;
        }
        if (buttonBlockedo > 1f)
        {
            oButton.enabled = true;
        }
        oButton.interactable = false;
        Invoke("ReActivateO", 1f);

    }

    public void writeP()
    {

        if (pButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "p";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "p";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "p";
            }

           
            pButton.enabled = false;
            buttonBlockedp = 0;
        }
        if (buttonBlockedp > 1f)
        {
            pButton.enabled = true;
        }
        pButton.interactable = false;
        Invoke("ReActivateP", 1f);

    }

    public void writeQ()
    {

        if (qButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "q";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "q";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "q";
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

    public void writeR()
    {

        if (rButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "r";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "r";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "r";
            }

           
            rButton.enabled = false;
            buttonBlockedr = 0;
        }
        if (buttonBlockedr > 1f)
        {
            rButton.enabled = true;
        }
        rButton.interactable = false;
        Invoke("ReActivateR", 1f);

    }

    public void writeS()
    {

        if (sButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "s";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "s";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "s";
            }

            
            sButton.enabled = false;
            buttonBlockeds = 0;
        }
        if (buttonBlockeds > 1f)
        {
            sButton.enabled = true;
        }
        sButton.interactable = false;
        Invoke("ReActivateS", 1f);

    }

    public void writeT()
    {

        if (tButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "t";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "t";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "t";
            }

            
            tButton.enabled = false;
            buttonBlockedt = 0;
        }
        if (buttonBlockedt > 1f)
        {
            tButton.enabled = true;
        }
        tButton.interactable = false;
        Invoke("ReActivateT", 1f);

    }

    public void writeU()
    {

        if (uButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "u";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "u";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "u";
            }

            
            uButton.enabled = false;
            buttonBlockedu = 0;
        }
        if (buttonBlockedu > 1f)
        {
            uButton.enabled = true;
        }
        uButton.interactable = false;
        Invoke("ReActivateU", 1f);

    }

    public void writeV()
    {

        if (vButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "v";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "v";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "v";
            }

            
            vButton.enabled = false;
            buttonBlockedv = 0;
        }
        if (buttonBlockedv > 1f)
        {
            vButton.enabled = true;
        }
        vButton.interactable = false;
        Invoke("ReActivateV", 1f);

    }

    public void writeW()
    {

        if (wButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "w";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "w";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "w";
            }

            
            wButton.enabled = false;
            buttonBlockedw = 0;
        }
        if (buttonBlockedw > 1f)
        {
            wButton.enabled = true;
        }
        wButton.interactable = false;
        Invoke("ReActivateW", 1f);

    }

    public void writeX()
    {

        if (xButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "x";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "x";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "x";
            }

           
            xButton.enabled = false;
            buttonBlockedx = 0;
        }
        if (buttonBlockedx > 1f)
        {
            xButton.enabled = true;
        }
        xButton.interactable = false;
        Invoke("ReActivateX", 1f);

    }

    public void writeY()
    {

        if (yButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "y";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "y";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "y";
            }

            
            yButton.enabled = false;
            buttonBlockedy = 0;
        }
        if (buttonBlockedy > 1f)
        {
            yButton.enabled = true;
        }
        yButton.interactable = false;
        Invoke("ReActivateY", 1f);

    }

    public void writeZ()
    {

        if (zButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "z";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "z";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "z";
            }

           
            zButton.enabled = false;
            buttonBlockedz = 0;
        }
        if (buttonBlockedz > 1f)
        {
            zButton.enabled = true;
        }
        zButton.interactable = false;
        Invoke("ReActivateZ", 1f);

    }

    public void writeOne()
    {

        if (oneButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "1";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "1";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "1";
            }

           
            oneButton.enabled = false;
            buttonBlockedone = 0;
        }
        if (buttonBlockedone > 1f)
        {
            oneButton.enabled = true;
        }
        oneButton.interactable = false;
        Invoke("ReActivateOne", 1f);

    }

    public void writeTwo()
    {

        if (twoButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "2";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "2";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "2";
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
                difficultyStudy.GetComponent<InputField>().text += "3";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "3";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "3";
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

    public void writeFour()
    {

        if (fourButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "4";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "4";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "4";
            }

            
            fourButton.enabled = false;
            buttonBlockedfour = 0;
        }
        if (buttonBlockedfour > 1f)
        {
            fourButton.enabled = true;
        }
        fourButton.interactable = false;
        Invoke("ReActivateFour", 1f);

    }

    public void writeFive()
    {

        if (fiveButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "5";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "5";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "5";
            }

            
            fiveButton.enabled = false;
            buttonBlockedfive = 0;
        }
        if (buttonBlockedfive > 1f)
        {
            fiveButton.enabled = true;
        }
        fiveButton.interactable = false;
        Invoke("ReActivateFive", 1f);

    }

    public void writeSix()
    {

        if (sixButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "6";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "6";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "6";
            }

            
            sixButton.enabled = false;
            buttonBlockedsix = 0;
        }
        if (buttonBlockedsix > 1f)
        {
            sixButton.enabled = true;
        }
        sixButton.interactable = false;
        Invoke("ReActivateSix", 1f);

    }

    public void writeSeven()
    {

        if (sevenButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "7";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "7";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "7";
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
                difficultyStudy.GetComponent<InputField>().text += "8";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "8";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "8";
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
                difficultyStudy.GetComponent<InputField>().text += "9";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "9";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "9";
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
                difficultyStudy.GetComponent<InputField>().text += "0";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "0";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "0";
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
                difficultyStudy.GetComponent<InputField>().text += "ß";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "ß";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "ß";
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
                difficultyStudy.GetComponent<InputField>().text += "<";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "<";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "<";
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

    public void writeStrichPunkt()
    {
        if (strichPunktButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += ",";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += ",";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += ",";
            }

           
            strichPunktButton.enabled = false;
            buttonBlockedStrichPunkt = 0;
        }
        if (buttonBlockedStrichPunkt > 1f)
        {
            strichPunktButton.enabled = true;
        }
        strichPunktButton.interactable = false;
        Invoke("ReActivateStrichPunkt", 1f);
    }

    public void writeDoppelPunkt()
    {
        if (doppelPunktButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += ".";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += ".";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += ".";
            }

            
            doppelPunktButton.enabled = false;
            buttonBlockedDoppelPunkt = 0;
        }
        if (buttonBlockedDoppelPunkt > 1f)
        {
            doppelPunktButton.enabled = true;
        }
        doppelPunktButton.interactable = false;
        Invoke("ReActivateDoppelPunkt", 1f);
    }

    public void writeUnterstrich()
    {
        if (unterStrichButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "-";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "-";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "-";
            }

            
            unterStrichButton.enabled = false;
            buttonBlockedUnterStrich = 0;
        }
        if (buttonBlockedUnterStrich > 1f)
        {
            unterStrichButton.enabled = true;
        }
        unterStrichButton.interactable = false;
        Invoke("ReActivateUnterstrich", 1f);
    }

    public void writeHochStrich()
    {
        if (hochCharButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "#";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "#";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "#";
            }

            
            hochCharButton.enabled = false;
            buttonBlockedHochChar = 0;
        }
        if (buttonBlockedHochChar > 1f)
        {
            hochCharButton.enabled = true;
        }
        hochCharButton.interactable = false;
        Invoke("ReActivateHochChar", 1f);
    }

    public void writeStern()
    {
        if (sternButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "+";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "+";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "+";
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




            if (lowerKeyboard.activeSelf == true)
            {
                lowerKeyboard.SetActive(false);
                altKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<LowerKeyboard>().enabled = false;
                GetComponent<AltKeyboard>().enabled = true;
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

            //if (altKeyboard.activeSelf == true)
            //{
            //   altKeyboard.SetActive(false);
            // lowerKeyboard.SetActive(true);
            //}

            if (lowerKeyboard.activeSelf == true)
            {
                lowerKeyboard.SetActive(false);
                upperKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<LowerKeyboard>().enabled = false;
                GetComponent<UpperKeyboard>().enabled = true;
            }

            //if (upperKeyboard.activeSelf == true)
            //{
            //  upperKeyboard.SetActive(false);
            //lowerKeyboard.SetActive(true);
            //}
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

    public void writeÖ()
    {
        if (öButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "ö";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "ö";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "ö";
            }

            
            öButton.enabled = false;
            buttonBlockedö = 0;
        }
        if (buttonBlockedö > 1f)
        {
            öButton.enabled = true;
        }
        öButton.interactable = false;
        Invoke("ReActivateÖ", 1f);
    }

    public void writeÄ()
    {
        if (äButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "ä";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "ä";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "ä";
            }

            
            äButton.enabled = false;
            buttonBlockedä = 0;
        }
        if (buttonBlockedä > 1f)
        {
            äButton.enabled = true;
        }
        äButton.interactable = false;
        Invoke("ReActivateÄ", 1f);
    }

    public void writeÜ()
    {
        if (üButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "ü";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "ü";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "ü";
            }

            
            üButton.enabled = false;
            buttonBlockedü = 0;
        }
        if (buttonBlockedü > 1f)
        {
            üButton.enabled = true;
        }
        üButton.interactable = false;
        Invoke("ReActivateÜ", 1f);
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

    private void ReActivateArrowDown()
    {
        buttonArrowDown.interactable = true;
    }

    private void ReActivateArrowUp()
    {
        buttonArrowUp.interactable = true;
    }

    private void ReActivateA()
    {
        aButton.interactable = true;
    }

    private void ReActivateB()
    {
        bButton.interactable = true;
    }

    private void ReActivateC()
    {
        cButton.interactable = true;
    }

    private void ReActivateD()
    {
        dButton.interactable = true;
    }

    private void ReActivateE()
    {
        eButton.interactable = true;
    }

    private void ReActivateF()
    {
        fButton.interactable = true;
    }

    private void ReActivateG()
    {
        gButton.interactable = true;
    }

    private void ReActivateH()
    {
        hButton.interactable = true;
    }

    private void ReActivateI()
    {
        iButton.interactable = true;
    }

    private void ReActivateJ()
    {
        jButton.interactable = true;
    }

    private void ReActivateK()
    {
        kButton.interactable = true;
    }

    private void ReActivateL()
    {
        lButton.interactable = true;
    }

    private void ReActivateM()
    {
        mButton.interactable = true;
    }

    private void ReActivateN()
    {
        nButton.interactable = true;
    }

    private void ReActivateO()
    {
        oButton.interactable = true;
    }

    private void ReActivateP()
    {
        pButton.interactable = true;
    }

    private void ReActivateQ()
    {
        qButton.interactable = true;
    }

    private void ReActivateR()
    {
        rButton.interactable = true;
    }

    private void ReActivateS()
    {
        sButton.interactable = true;
    }

    private void ReActivateT()
    {
        tButton.interactable = true;
    }

    private void ReActivateU()
    {
        uButton.interactable = true;
    }

    private void ReActivateV()
    {
        vButton.interactable = true;
    }

    private void ReActivateW()
    {
        wButton.interactable = true;
    }

    private void ReActivateX()
    {
        xButton.interactable = true;
    }

    private void ReActivateY()
    {
        yButton.interactable = true;
    }

    private void ReActivateZ()
    {
        zButton.interactable = true;
    }

    private void ReActivateOne()
    {
        oneButton.interactable = true;
    }

    private void ReActivateTwo()
    {
        twoButton.interactable = true;
    }

    private void ReActivateThree()
    {
        threeButton.interactable = true;
    }

    private void ReActivateFour()
    {
        fourButton.interactable = true;
    }

    private void ReActivateFive()
    {
        fiveButton.interactable = true;
    }

    private void ReActivateSix()
    {
        sixButton.interactable = true;
    }

    private void ReActivateSeven()
    {
        sevenButton.interactable = true;
    }

    private void ReActivateEight()
    {
        eightButton.interactable = true;
    }

    private void ReActivateNine()
    {
        nineButton.interactable = true;
    }

    private void ReActivateZero()
    {
        zeroButton.interactable = true;
    }

    private void ReActivateß()
    {
        ßButton.interactable = true;
    }

    private void ReActivateSpace()
    {
        spaceButton.interactable = true;
    }

    private void ReActivateDelChar()
    {
        deleteChar.interactable = true;
    }

    private void ReActivateÄ()
    {
        äButton.interactable = true;
    }

    private void ReActivateÖ()
    {
        öButton.interactable = true;
    }

    private void ReActivateÜ()
    {
        üButton.interactable = true;
    }

    private void ReActivatePfeilRechts()
    {
        pfeilRechtsButton.interactable = true;
    }

    private void ReActivateStrichPunkt()
    {
        strichPunktButton.interactable = true;
    }

    private void ReActivateShift()
    {
        shiftButton.interactable = true;
    }

    private void ReActivateAlt()
    {
        altButton.interactable = true;
    }

    private void ReActivateDoppelPunkt()
    {
        doppelPunktButton.interactable = true;
    }

    private void ReActivateUnterstrich()
    {
        unterStrichButton.interactable = true;
    }

    private void ReActivateStern()
    {
        sternButton.interactable = true;
    }

    private void ReActivateHochChar()
    {
        hochCharButton.interactable = true;
    }

    private void ReActivateTab()
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

    public string ToCSVPostStudySmallInfo(string partID, float csvTime, string backgroundScreenName, double xgaze, double ygaze, double zgaze)
    {
        sb.Append('\n').Append(partID.ToString()).Append(" ").Append(csvTime.ToString()).Append(" ").Append(backgroundScreenName.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString());
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
