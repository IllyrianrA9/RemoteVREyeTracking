using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;
using Tobii.G2OM;
using Tobii.XR;
using Random = UnityEngine.Random;

public class UpperKeyboardDistract : MonoBehaviour
{
    public List<GameObject> remainingScenes;
    private int currentRandomNumber;
    public List<Material> remainingMaterial;
    public List<GameObject> remainingKeyboards;
    public GameObject pwWarning;
    public GameObject confirmPwWarning;

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

  

    public GameObject currentBackgroundScreen;
    public Material currentBackground;

    public GameObject nextBackgroundScreen;
    public Material nextBackground;

    public string csvDocumentation;
    public StringBuilder sb;
    public float timeForCSV;


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

    //public float buttonBlockedDown = 0;
    //public float buttonBlockedUp = 0;
    // Start is called before the first frame update

    //public GameObject a;
    //public GameObject b;
    //public GameObject c;
    //public GameObject d;
    //public GameObject e;
    //public GameObject f;
    //public GameObject g;
    //public GameObject h;
    //public GameObject i;
    //public GameObject j;
    //public GameObject k;
    //public GameObject l;
    //public GameObject m;
    //public GameObject n;
    //public GameObject o;
    //public GameObject p;
    //public GameObject q;
    //public GameObject r;
    //public GameObject s;
    //public GameObject t;
    //public GameObject u;
    //public GameObject v;
    //public GameObject w;
    //public GameObject x;
    //public GameObject y;
    //public GameObject z;
    //public GameObject space;
    //public GameObject ß;
    //public GameObject one;
    //public GameObject two;
    //public GameObject three;
    //public GameObject zero;
    //public GameObject four;
    //public GameObject five;
    //public GameObject six;
    //public GameObject seven;
    //public GameObject eight;
    //public GameObject nine;
    //public GameObject deleteOneChar;

    //public GameObject tabulator;
    //public GameObject shift;
    //public GameObject pfeilRechts;
    //public GameObject ö;
    //public GameObject ä;
    //public GameObject ü;
    //public GameObject strichPunkt;
    //public GameObject doppelPunkt;
    //public GameObject unterStrich;
    //public GameObject hochChar;
    //public GameObject stern;
    //public GameObject alt;


    public Button aButton;
    public Button bButton;
    public Button cButton;
    public Button dButton;
    public Button eButton;
    public Button fButton;
    public Button gButton;
    public Button hButton;
    public Button iButton;
    public Button jButton;
    public Button kButton;
    public Button lButton;
    public Button mButton;
    public Button nButton;
    public Button oButton;
    public Button pButton;
    public Button qButton;
    public Button rButton;
    public Button sButton;
    public Button tButton;
    public Button uButton;
    public Button vButton;
    public Button wButton;
    public Button xButton;
    public Button yButton;
    public Button zButton;
    public Button oneButton;
    public Button twoButton;
    public Button threeButton;
    public Button fourButton;
    public Button fiveButton;
    public Button sixButton;
    public Button sevenButton;
    public Button eightButton;
    public Button nineButton;
    public Button zeroButton;
    public Button spaceButton;
    public Button ßButton;
    public Button deleteChar;

    public Button tabButton;
    public Button öButton;
    public Button äButton;
    public Button üButton;
    public Button strichPunktButton;
    public Button doppelPunktButton;
    public Button altButton;
    public Button shiftButton;
    public Button pfeilRechtsButton;
    public Button unterStrichButton;
    public Button sternButton;
    public Button hochCharButton;


    //public float buttonBlockeddel = 0;
    //public float buttonBlockeda = 0;
    //public float buttonBlockedb = 0;
    //public float buttonBlockedc = 0;
    //public float buttonBlockedd = 0;
    //public float buttonBlockede = 0;
    //public float buttonBlockedf = 0;
    //public float buttonBlockedg = 0;
    //public float buttonBlockedh = 0;
    //public float buttonBlockedi = 0;
    //public float buttonBlockedj = 0;
    //public float buttonBlockedk = 0;
    //public float buttonBlockedl = 0;
    //public float buttonBlockedm = 0;
    //public float buttonBlockedn = 0;
    //public float buttonBlockedo = 0;
    //public float buttonBlockedp = 0;
    //public float buttonBlockedq = 0;
    //public float buttonBlockedr = 0;
    //public float buttonBlockeds = 0;
    //public float buttonBlockedt = 0;
    //public float buttonBlockedu = 0;
    //public float buttonBlockedv = 0;
    //public float buttonBlockedw = 0;
    //public float buttonBlockedx = 0;
    //public float buttonBlockedy = 0;
    //public float buttonBlockedz = 0;
    //public float buttonBlockedß = 0;
    //public float buttonBlockedspace = 0;
    //public float buttonBlockedone = 0;
    //public float buttonBlockedtwo = 0;
    //public float buttonBlockedthree = 0;
    //public float buttonBlockedfour = 0;
    //public float buttonBlockedfive = 0;
    //public float buttonBlockedsix = 0;
    //public float buttonBlockedseven = 0;
    //public float buttonBlockedeight = 0;
    //public float buttonBlockednine = 0;
    //public float buttonBlockedzero = 0;

    //public float buttonBlockedtab = 0;
    //public float buttonBlockedshift = 0;
    //public float buttonBlockedpfeilRechts = 0;
    //public float buttonBlockedö = 0;
    //public float buttonBlockedä = 0;
    //public float buttonBlockedü = 0;
    //public float buttonBlockedStrichPunkt = 0;
    //public float buttonBlockedDoppelPunkt = 0;
    //public float buttonBlockedUnterStrich = 0;
    //public float buttonBlockedAlt = 0;
    //public float buttonBlockedStern = 0;
    //public float buttonBlockedHochChar = 0;
    public float universalBlock = 0;



    private bool partTrueID = true;

    void Start()
    {
        if ((paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV < paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<LowerKeyboardDistract>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<LowerKeyboardDistract>().sb;
            InputSelected = GetComponent<LowerKeyboardDistract>().InputSelected;
        }

        if ((paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV < paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<AltKeyboardDistract>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<AltKeyboardDistract>().sb;
            InputSelected = GetComponent<AltKeyboardDistract>().InputSelected;
        }

        file = paypalNoDistract.GetComponent<LowerKeyboardDistract>().file;
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
        //aButton = a.GetComponent<Button>();
        //bButton = b.GetComponent<Button>();
        //cButton = c.GetComponent<Button>();
        //dButton = d.GetComponent<Button>();
        //eButton = e.GetComponent<Button>();
        //fButton = f.GetComponent<Button>();
        //gButton = g.GetComponent<Button>();
        //hButton = h.GetComponent<Button>();
        //iButton = i.GetComponent<Button>();
        //jButton = j.GetComponent<Button>();
        //kButton = k.GetComponent<Button>();
        //lButton = l.GetComponent<Button>();
        //mButton = m.GetComponent<Button>();
        //nButton = n.GetComponent<Button>();
        //oButton = o.GetComponent<Button>();
        //pButton = p.GetComponent<Button>();
        //qButton = q.GetComponent<Button>();
        //rButton = r.GetComponent<Button>();
        //sButton = s.GetComponent<Button>();
        //tButton = t.GetComponent<Button>();
        //uButton = u.GetComponent<Button>();
        //vButton = v.GetComponent<Button>();
        //wButton = w.GetComponent<Button>();
        //xButton = x.GetComponent<Button>();
        //yButton = y.GetComponent<Button>();
        //zButton = z.GetComponent<Button>();
        //ßButton = ß.GetComponent<Button>();
        //spaceButton = space.GetComponent<Button>();
        //oneButton = one.GetComponent<Button>();
        //twoButton = two.GetComponent<Button>();
        //threeButton = three.GetComponent<Button>();
        //fourButton = four.GetComponent<Button>();
        //fiveButton = five.GetComponent<Button>();
        //sixButton = six.GetComponent<Button>();
        //sevenButton = seven.GetComponent<Button>();
        //eightButton = eight.GetComponent<Button>();
        //nineButton = nine.GetComponent<Button>();
        //zeroButton = zero.GetComponent<Button>();

        //tabButton = tabulator.GetComponent<Button>();
        //shiftButton = shift.GetComponent<Button>();
        //pfeilRechtsButton = pfeilRechts.GetComponent<Button>();
        //öButton = ö.GetComponent<Button>();
        //äButton = ä.GetComponent<Button>();
        //üButton = ü.GetComponent<Button>();
        //strichPunktButton = strichPunkt.GetComponent<Button>();
        //doppelPunktButton = doppelPunkt.GetComponent<Button>();
        //unterStrichButton = unterStrich.GetComponent<Button>();
        //hochCharButton = hochChar.GetComponent<Button>();
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
        if ((paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV < paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<LowerKeyboardDistract>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<LowerKeyboardDistract>().sb;
            InputSelected = GetComponent<LowerKeyboardDistract>().InputSelected;
        }

        if ((paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV > timeForCSV) && (paypalNoDistract.GetComponent<LowerKeyboardDistract>().timeForCSV < paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV))
        {
            timeForCSV = paypalNoDistract.GetComponent<AltKeyboardDistract>().timeForCSV;
            csvDocumentation = paypalNoDistract.GetComponent<AltKeyboardDistract>().csvDocumentation;
            sb = paypalNoDistract.GetComponent<AltKeyboardDistract>().sb;
            InputSelected = GetComponent<AltKeyboardDistract>().InputSelected;
        }

        universalBlock += Time.deltaTime;
        //buttonBlockedDown += Time.deltaTime;
        //buttonBlockedUp += Time.deltaTime;
        //buttonBlockeda += Time.deltaTime;
        //buttonBlockedb += Time.deltaTime;
        //buttonBlockedc += Time.deltaTime;
        //buttonBlockedd += Time.deltaTime;
        //buttonBlockede += Time.deltaTime;
        //buttonBlockedf += Time.deltaTime;
        //buttonBlockedg += Time.deltaTime;
        //buttonBlockedh += Time.deltaTime;
        //buttonBlockedi += Time.deltaTime;
        //buttonBlockedj += Time.deltaTime;
        //buttonBlockedk += Time.deltaTime;
        //buttonBlockedl += Time.deltaTime;
        //buttonBlockedm += Time.deltaTime;
        //buttonBlockedn += Time.deltaTime;
        //buttonBlockedo += Time.deltaTime;
        //buttonBlockedp += Time.deltaTime;
        //buttonBlockedq += Time.deltaTime;
        //buttonBlockedr += Time.deltaTime;
        //buttonBlockeds += Time.deltaTime;
        //buttonBlockedt += Time.deltaTime;
        //buttonBlockedu += Time.deltaTime;
        //buttonBlockedv += Time.deltaTime;
        //buttonBlockedw += Time.deltaTime;
        //buttonBlockedx += Time.deltaTime;
        //buttonBlockedy += Time.deltaTime;
        //buttonBlockedz += Time.deltaTime;
        //buttonBlockedspace += Time.deltaTime;
        //buttonBlockedzero += Time.deltaTime;
        //buttonBlockedone += Time.deltaTime;
        //buttonBlockedtwo += Time.deltaTime;
        //buttonBlockedthree += Time.deltaTime;
        //buttonBlockedfour += Time.deltaTime;
        //buttonBlockedfive += Time.deltaTime;
        //buttonBlockedsix += Time.deltaTime;
        //buttonBlockedseven += Time.deltaTime;
        //buttonBlockedeight += Time.deltaTime;
        //buttonBlockednine += Time.deltaTime;
        //buttonBlockedß += Time.deltaTime;
        //buttonBlockeddel += Time.deltaTime;

        //buttonBlockedStrichPunkt += Time.deltaTime;
        //buttonBlockedStern += Time.deltaTime;
        //buttonBlockedtab += Time.deltaTime;
        //buttonBlockedshift += Time.deltaTime;
        //buttonBlockedUnterStrich += Time.deltaTime;
        //buttonBlockedpfeilRechts += Time.deltaTime;
        //buttonBlockedä += Time.deltaTime;
        //buttonBlockedü += Time.deltaTime;
        //buttonBlockedö += Time.deltaTime;
        //buttonBlockedHochChar += Time.deltaTime;
        //buttonBlockedDoppelPunkt += Time.deltaTime;
        //buttonBlockedAlt += Time.deltaTime;


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
            var remainChars = 8 - distraction.text.Length;
            pwWarning.GetComponent<TMP_Text>().text = "At least 8 characters. Characters left: " + remainChars;
            pwWarning.SetActive(true);
        }

        if ((distractionOnScreen.text.Trim().Length == 0) || !(distractionOnScreen.text.Equals(distraction.text)))
        {
            confirmPwWarning.SetActive(true);
        }

        if (difficultyStudy.text.Trim().Length == 0)
        {

        }




        if (!(distraction.text.Trim().Length < 8))
        {
            pwWarning.SetActive(false);
        }

        if ((distractionOnScreen.text.Trim().Length >= 8) && (distractionOnScreen.text.Equals(distraction.text)))
        {
            confirmPwWarning.SetActive(false);
        }

        if (!(difficultyStudy.text.Trim().Length == 0))
        {

        }


        if (!(distraction.text.Trim().Length == 0) && !(distractionOnScreen.text.Trim().Length == 0) && !(difficultyStudy.text.Trim().Length == 0) && (distractionOnScreen.text.Equals(distraction.text)))
        {

            csvDocumentation = ToCSVPostStudy(timeForCSV, _gazeX, _gazeY, _gazeZ, _input1_x, _input1_y, _input1_z, _input2_x, _input2_y, _input2_z, _input3_x, _input3_y, _input3_z, difficultyStudy.text, distraction.text, theme.name, participantID);
            SaveToFile();
            lowerKeyboard.SetActive(false);
            altKeyboard.SetActive(false);
            upperKeyboard.SetActive(false);
            currentRandomNumber = Random.Range(0, 2);

            if (currentRandomNumber == 1)
            {
                paypalNoDistract.SetActive(false);
                nextBackgroundScreen.GetComponent<Renderer>().material = remainingMaterial[currentRandomNumber];
                remainingMaterial.RemoveAt(currentRandomNumber);

                remainingKeyboards[currentRandomNumber].SetActive(true);
                remainingKeyboards.RemoveAt(currentRandomNumber);

                remainingScenes[currentRandomNumber].SetActive(true);
                remainingScenes.RemoveAt(currentRandomNumber);
            }
            else if (currentRandomNumber == 0)
            {
                paypalNoDistract.SetActive(false);
                nextBackgroundScreen.GetComponent<Renderer>().material = remainingMaterial[currentRandomNumber];
                remainingMaterial.RemoveAt(currentRandomNumber);

                remainingKeyboards[currentRandomNumber].SetActive(true);
                remainingKeyboards.RemoveAt(currentRandomNumber);

                remainingScenes[currentRandomNumber].SetActive(true);
                remainingScenes.RemoveAt(currentRandomNumber);
            }
            //Hier kommen die zu nutzenden Objekte

            //keyboard.SetActive(false);
            //canvasKeyboard.SetActive(false);
            //lowerKeyboard.SetActive(false);
            //altKeyboard.SetActive(false);
            //upperKeyboard.SetActive(false);
            //paypalDistractKeyboard.SetActive(true);
            //endButton.SetActive(true);
            
            //csvDocumentation = ToCSVPostStudy(participantID, timeForCSV, theme.name, _gazeX, _gazeY, _gazeZ, _input1_x, _input1_y, _input1_z, _input2_x, _input2_y, _input2_z, _input3_x, _input3_y, _input3_z, preferedTopic.GetComponent<Text>().text, difficultyStudy.text, distraction.text);


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

    public void writeA()
    {

        if (aButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "A";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "A";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "A";
            }


            aButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            aButton.enabled = true;
        }
        aButton.interactable = false;
        Invoke("ReActivateA", 0.5f);

    }

    public void writeB()
    {

        if (bButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "B";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "B";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "B";
            }


            bButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            bButton.enabled = true;
        }
        bButton.interactable = false;
        Invoke("ReActivateB", 0.5f);

    }

    public void writeC()
    {

        if (cButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "C";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "C";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "C";
            }


            cButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            cButton.enabled = true;
        }
        cButton.interactable = false;
        Invoke("ReActivateC", 0.5f);

    }

    public void writeD()
    {

        if (dButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "D";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "D";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "D";
            }


            dButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            dButton.enabled = true;
        }
        dButton.interactable = false;
        Invoke("ReActivateD", 0.5f);

    }

    public void writeE()
    {

        if (eButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "E";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "E";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "E";
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

    public void writeF()
    {

        if (fButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "F";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "F";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "F";
            }


            fButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            fButton.enabled = true;
        }
        fButton.interactable = false;
        Invoke("ReActivateF", 0.5f);

    }

    public void writeG()
    {

        if (gButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "G";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "G";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "G";
            }


            gButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            gButton.enabled = true;
        }
        gButton.interactable = false;
        Invoke("ReActivateG", 0.5f);

    }

    public void writeH()
    {

        if (hButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "H";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "H";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "H";
            }


            hButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            hButton.enabled = true;
        }
        hButton.interactable = false;
        Invoke("ReActivateH", 0.5f);

    }

    public void writeI()
    {

        if (iButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "I";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "I";
            }
            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "I";
            }


            iButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            iButton.enabled = true;
        }
        iButton.interactable = false;
        Invoke("ReActivateI", 0.5f);

    }

    public void writeJ()
    {

        if (jButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "J";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "J";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "J";
            }


            jButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            jButton.enabled = true;
        }
        jButton.interactable = false;
        Invoke("ReActivateJ", 0.5f);

    }

    public void writeK()
    {

        if (kButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "K";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "K";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "K";
            }


            kButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            kButton.enabled = true;
        }
        kButton.interactable = false;
        Invoke("ReActivateK", 0.5f);

    }

    public void writeL()
    {

        if (lButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "L";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "L";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "L";
            }


            lButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            lButton.enabled = true;
        }
        lButton.interactable = false;
        Invoke("ReActivateL", 0.5f);

    }

    public void writeM()
    {

        if (mButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "M";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "M";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "M";
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

    public void writeN()
    {

        if (nButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "N";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "N";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "N";
            }


            nButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            nButton.enabled = true;
        }
        nButton.interactable = false;
        Invoke("ReActivateN", 0.5f);

    }

    public void writeO()
    {

        if (oButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "O";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "O";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "O";
            }


            oButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            oButton.enabled = true;
        }
        oButton.interactable = false;
        Invoke("ReActivateO", 0.5f);

    }

    public void writeP()
    {

        if (pButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "P";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "P";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "P";
            }


            pButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            pButton.enabled = true;
        }
        pButton.interactable = false;
        Invoke("ReActivateP", 0.5f);

    }

    public void writeQ()
    {

        if (qButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "Q";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "Q";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "Q";
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

    public void writeR()
    {

        if (rButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "R";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "R";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "R";
            }


            rButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            rButton.enabled = true;
        }
        rButton.interactable = false;
        Invoke("ReActivateR", 0.5f);

    }

    public void writeS()
    {

        if (sButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "S";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "S";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "S";
            }


            sButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            sButton.enabled = true;
        }
        sButton.interactable = false;
        Invoke("ReActivateS", 0.5f);

    }

    public void writeT()
    {

        if (tButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "T";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "T";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "T";
            }


            tButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            tButton.enabled = true;
        }
        tButton.interactable = false;
        Invoke("ReActivateT", 0.5f);

    }

    public void writeU()
    {

        if (uButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "U";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "U";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "U";
            }


            uButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            uButton.enabled = true;
        }
        uButton.interactable = false;
        Invoke("ReActivateU", 0.5f);

    }

    public void writeV()
    {

        if (vButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "V";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "V";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "V";
            }


            vButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            vButton.enabled = true;
        }
        vButton.interactable = false;
        Invoke("ReActivateV", 0.5f);

    }

    public void writeW()
    {

        if (wButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "W";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "W";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "W";
            }


            wButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            wButton.enabled = true;
        }
        wButton.interactable = false;
        Invoke("ReActivateW", 0.5f);

    }

    public void writeX()
    {

        if (xButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "X";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "X";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "X";
            }


            xButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            xButton.enabled = true;
        }
        xButton.interactable = false;
        Invoke("ReActivateX", 0.5f);

    }

    public void writeY()
    {

        if (yButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "Y";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "Y";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "Y";
            }


            yButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            yButton.enabled = true;
        }
        yButton.interactable = false;
        Invoke("ReActivateY", 0.5f);

    }

    public void writeZ()
    {

        if (zButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "Z";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "Z";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "Z";
            }


            zButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            zButton.enabled = true;
        }
        zButton.interactable = false;
        Invoke("ReActivateZ", 0.5f);

    }

    public void writeOne()
    {

        if (oneButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "!";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "!";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "!";
            }


            oneButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            oneButton.enabled = true;
        }
        oneButton.interactable = false;
        Invoke("ReActivateOne", 0.5f);

    }

    public void writeTwo()
    {

        if (twoButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "''";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "''";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "''";
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
                difficultyStudy.GetComponent<InputField>().text += "§";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "§";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "§";
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

    public void writeFour()
    {

        if (fourButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "$";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "$";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "$";
            }


            fourButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            fourButton.enabled = true;
        }
        fourButton.interactable = false;
        Invoke("ReActivateFour", 0.5f);

    }

    public void writeFive()
    {

        if (fiveButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "%";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "%";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "%";
            }


            fiveButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            fiveButton.enabled = true;
        }
        fiveButton.interactable = false;
        Invoke("ReActivateFive", 0.5f);

    }

    public void writeSix()
    {

        if (sixButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "&";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "&";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "&";
            }


            sixButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            sixButton.enabled = true;
        }
        sixButton.interactable = false;
        Invoke("ReActivateSix", 0.5f);

    }

    public void writeSeven()
    {

        if (sevenButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "/";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "/";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "/";
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
                difficultyStudy.GetComponent<InputField>().text += "(";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "(";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "(";
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
                difficultyStudy.GetComponent<InputField>().text += ")";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += ")";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += ")";
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
                difficultyStudy.GetComponent<InputField>().text += "=";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "=";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "=";
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
                difficultyStudy.GetComponent<InputField>().text += "?";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "?";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "?";
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
                difficultyStudy.GetComponent<InputField>().text += ">";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += ">";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += ">";
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

    public void writeStrichPunkt()
    {
        if (strichPunktButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += ";";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += ";";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += ";";
            }


            strichPunktButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            strichPunktButton.enabled = true;
        }
        strichPunktButton.interactable = false;
        Invoke("ReActivateStrichPunkt", 0.5f);
    }

    public void writeDoppelPunkt()
    {
        if (doppelPunktButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += ":";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += ":";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += ":";
            }


            doppelPunktButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            doppelPunktButton.enabled = true;
        }
        doppelPunktButton.interactable = false;
        Invoke("ReActivateDoppelPunkt", 0.5f);
    }

    public void writeUnterstrich()
    {
        if (unterStrichButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "_";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "_";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "_";
            }


            unterStrichButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            unterStrichButton.enabled = true;
        }
        unterStrichButton.interactable = false;
        Invoke("ReActivateUnterstrich", 0.5f);
    }

    public void writeHochStrich()
    {
        if (hochCharButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "'";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "'";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "'";
            }


            hochCharButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            hochCharButton.enabled = true;
        }
        hochCharButton.interactable = false;
        Invoke("ReActivateHochChar", 0.5f);
    }

    public void writeStern()
    {
        if (sternButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "*";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "*";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "*";
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




            if (upperKeyboard.activeSelf == true)
            {
                upperKeyboard.SetActive(false);
                altKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<UpperKeyboardDistract>().enabled = false;
                GetComponent<AltKeyboardDistract>().enabled = true;
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



            if (upperKeyboard.activeSelf == true)
            {
                upperKeyboard.SetActive(false);
                lowerKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<UpperKeyboardDistract>().enabled = false;
                GetComponent<LowerKeyboardDistract>().enabled = true;

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

    public void writeÖ()
    {
        if (öButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "Ö";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "Ö";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "Ö";
            }


            öButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            öButton.enabled = true;
        }
        öButton.interactable = false;
        Invoke("ReActivateÖ", 0.5f);
    }

    public void writeÄ()
    {
        if (äButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "Ä";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "Ä";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "Ä";
            }


            äButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            äButton.enabled = true;
        }
        äButton.interactable = false;
        Invoke("ReActivateÄ", 0.5f);
    }

    public void writeÜ()
    {
        if (üButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<InputField>().text += "Ü";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<InputField>().text += "Ü";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<InputField>().text += "Ü";
            }


            üButton.enabled = false;
            universalBlock = 0;
        }
        if (universalBlock > 0.5f)
        {
            üButton.enabled = true;
        }
        üButton.interactable = false;
        Invoke("ReActivateÜ", 0.5f);
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

    public string ToCSVPostStudy(float csvTime, double xgaze, double ygaze, double zgaze, double xEmail, double yEmail, double zEmail, double xPw, double yPw, double zPw, double xconfpw, double yconfpw, double zconfpw, string email, string pw, string backgroundScreenName, string partID)
    {
        //var sb = new StringBuilder("Participant_ID Time Scene X_Gaze Y_Gaze Z_Gaze X_Position_Email Y_Position_Email Z_Position_Email X_Position_PW Y_Position_PW Z_Position_PW X_Position_ConfirmedPW Y_Position_ConfirmedPW Z_Position_ConfirmedPW Prefered_Topic Email Password");
        sb.Append('\n').Append(csvTime.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString()).Append(" ").Append(xEmail.ToString()).Append(" ").Append(yEmail.ToString()).Append(" ").Append(zEmail.ToString()).Append(" ").Append(xPw.ToString()).Append(" ").Append(yPw.ToString()).Append(" ").Append(zPw.ToString()).Append(" ").Append(xconfpw.ToString()).Append(" ").Append(yconfpw.ToString()).Append(" ").Append(zconfpw.ToString()).Append(" ").Append(email.ToString()).Append(" ").Append(pw.ToString()).Append(" ").Append(backgroundScreenName.ToString()).Append(" ").Append(partID.ToString());
        return sb.ToString();

    }

    public string ToCSVPostStudyNoEmail(string partID, float csvTime, string backgroundScreenName, double xgaze, double ygaze, double zgaze, double xEmail, double yEmail, double zEmail, double xPw, double yPw, double zPw, double xconfpw, double yconfpw, double zconfpw)
    {
        sb.Append('\n').Append(partID.ToString()).Append(" ").Append(csvTime.ToString()).Append(" ").Append(backgroundScreenName.ToString()).Append(" ").Append(xgaze.ToString()).Append(" ").Append(ygaze.ToString()).Append(" ").Append(zgaze.ToString()).Append(" ").Append(xEmail.ToString()).Append(" ").Append(yEmail.ToString()).Append(" ").Append(zEmail.ToString()).Append(" ").Append(xPw.ToString()).Append(" ").Append(yPw.ToString()).Append(" ").Append(zPw.ToString()).Append(" ").Append(xconfpw.ToString()).Append(" ").Append(yconfpw.ToString()).Append(" ").Append(zconfpw.ToString());
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
    public void OnClickLaser()
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
    }
}
