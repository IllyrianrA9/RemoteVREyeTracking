using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;

public class AltKeyboardDInput : MonoBehaviour
{
    //This is the lowercase Input script

    public bool wasActive = false;
    public GameObject lowerKeyboard;
    public GameObject altKeyboard;
    public GameObject upperKeyboard;


    public GameObject postStudy;
    public GameObject postStudySheet;

    public GameObject canvasForPartID;
    private int participantNumberReal;

    public string file = "demographyData";
    public GameObject participant;
    private string participantID;

    public TMP_InputField age;
    public TMP_InputField gender;
    public TMP_InputField vision;
    public TMP_InputField residency;
    public GameObject origin;
    public TMP_InputField experience;
    public TMP_InputField remoteStudies;
    public GameObject objectButton;
    private Button button;

    public GameObject ageWarning;
    public GameObject genderWarning;
    public GameObject visionWarning;
    public GameObject residencyWarning;
    public GameObject originWarning;
    public GameObject experienceWarning;
    public GameObject remoteStudiesWarning;

    public GameObject initialText;
    public GameObject demography;
    public GameObject keyboard;
    public GameObject canvasKeyboard;
    public GameObject startExperimentButton;

    public int InputSelected;

    public GameObject arrowUpKey;
    public GameObject arrowDownKey;
    private Button buttonArrowUp;
    private Button buttonArrowDown;

    private string ageText;
    private string genderText;
    private string visionText;
    private string residencyText;
    private string originText;
    private string experienceText;
    private string remoteStudiesText;

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

        if (GetComponent<UpperKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<UpperKeyboardInput>().InputSelected;
            GetComponent<UpperKeyboardInput>().wasActive = false;
        }
        if (GetComponent<ArrowInputField>().wasActive == true)
        {
            InputSelected = GetComponent<ArrowInputField>().InputSelected;
            GetComponent<ArrowInputField>().wasActive = false;
        }
        participantID = participant.GetComponent<Text>().text;

        switch (InputSelected)
        {
            case 0:
                age.Select();
                break;
            case 1:
                gender.Select();
                break;
            case 2:
                vision.Select();
                break;
            case 3:
                residency.Select();
                break;
            case 4:
                origin.GetComponent<TMP_InputField>().Select();
                break;
            case 5:
                experience.Select();
                break;
            case 6:
                remoteStudies.Select();
                break;
        }
        if (partTrueID)
        {
            participantNumberReal = canvasForPartID.GetComponent<ManageParticipantID>().participantNumber;
            participantID = participant.GetComponent<Text>().text;
            file = file + participantNumberReal + ".txt";
            partTrueID = false;
        }
        button = objectButton.GetComponent<Button>();
        ageText = age.GetComponent<TMP_InputField>().text;
        genderText = gender.GetComponent<TMP_InputField>().text;
        visionText = vision.GetComponent<TMP_InputField>().text;
        residencyText = residency.GetComponent<TMP_InputField>().text;
        originText = origin.GetComponent<TMP_InputField>().text;
        experienceText = experience.GetComponent<TMP_InputField>().text;
        remoteStudiesText = remoteStudies.GetComponent<TMP_InputField>().text;

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
        if (GetComponent<UpperKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<UpperKeyboardInput>().InputSelected;
            GetComponent<UpperKeyboardInput>().wasActive = false;
        }
        if (GetComponent<ArrowInputField>().wasActive == true)
        {
            InputSelected = GetComponent<ArrowInputField>().InputSelected;
            GetComponent<ArrowInputField>().wasActive = false;
        }
        switch (InputSelected)
        {
            case 0:
                age.Select();
                break;
            case 1:
                gender.Select();
                break;
            case 2:
                vision.Select();
                break;
            case 3:
                residency.Select();
                break;
            case 4:
                origin.GetComponent<TMP_InputField>().Select();
                break;
            case 5:
                experience.Select();
                break;
            case 6:
                remoteStudies.Select();
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
        if (age.text.Trim().Length == 0)
        {
            ageWarning.SetActive(true);
        }

        if (gender.text.Trim().Length == 0)
        {
            genderWarning.SetActive(true);
        }

        if (vision.text.Trim().Length == 0)
        {
            visionWarning.SetActive(true);
        }

        if (residency.text.Trim().Length == 0)
        {
            residencyWarning.SetActive(true);
        }

        if (origin.GetComponent<TMP_InputField>().text.Trim().Length == 0)
        {
            originWarning.SetActive(true);
        }

        if (experience.text.Trim().Length == 0)
        {
            experienceWarning.SetActive(true);
        }
        if (remoteStudies.text.Trim().Length == 0)
        {
            remoteStudiesWarning.SetActive(true);
        }


        if (!(age.text.Trim().Length == 0))
        {
            ageWarning.SetActive(false);
        }

        if (!(gender.text.Trim().Length == 0))
        {
            genderWarning.SetActive(false);
        }

        if (!(vision.text.Trim().Length == 0))
        {
            visionWarning.SetActive(false);
        }

        if (!(residency.text.Trim().Length == 0))
        {
            residencyWarning.SetActive(false);
        }

        if (!(origin.GetComponent<TMP_InputField>().text.Trim().Length == 0))
        {
            originWarning.SetActive(false);
        }

        if (!(experience.text.Trim().Length == 0))
        {
            experienceWarning.SetActive(false);
        }
        if (!(remoteStudies.text.Trim().Length == 0))
        {
            remoteStudiesWarning.SetActive(false);
        }
        if (!(age.text.Trim().Length == 0) && !(gender.text.Trim().Length == 0) && !(vision.text.Trim().Length == 0) && !(residency.text.Trim().Length == 0) && !(origin.GetComponent<TMP_InputField>().text.Trim().Length == 0) && !(experience.text.Trim().Length == 0) && !(remoteStudies.text.Trim().Length == 0))
        {
            if (ageWarning.activeSelf == true)
            {
                ageWarning.SetActive(false);
            }
            if (genderWarning.activeSelf == true)
            {
                genderWarning.SetActive(false);
            }
            if (visionWarning.activeSelf == true)
            {
                visionWarning.SetActive(false);
            }
            if (residencyWarning.activeSelf == true)
            {
                residencyWarning.SetActive(false);
            }
            if (originWarning.activeSelf == true)
            {
                originWarning.SetActive(false);
            }
            if (experienceWarning.activeSelf == true)
            {
                experienceWarning.SetActive(false);
            }
            if (remoteStudiesWarning.activeSelf == true)
            {
                remoteStudiesWarning.SetActive(false);
            }

            //Hier kommen die zu nutzenden Objekte
            demography.SetActive(false);
            canvasKeyboard.SetActive(false);
            postStudy.SetActive(true);
            postStudySheet.SetActive(true);
            lowerKeyboard.SetActive(false);
            altKeyboard.SetActive(false);
            upperKeyboard.SetActive(false);

            //Hier schreibe ich in eine Datei
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
                InputSelected = 6;
            }
            switch (InputSelected)
            {
                case 0:
                    age.Select();
                    break;
                case 1:
                    gender.Select();
                    break;
                case 2:
                    vision.Select();
                    break;
                case 3:
                    residency.Select();
                    break;
                case 4:
                    origin.GetComponent<TMP_InputField>().Select();
                    break;
                case 5:
                    experience.Select();
                    break;
                case 6:
                    remoteStudies.Select();
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
            if (InputSelected > 6)
            {
                InputSelected = 0;
            }

            switch (InputSelected)
            {
                case 0:
                    age.Select();
                    break;
                case 1:
                    gender.Select();
                    break;
                case 2:
                    vision.Select();
                    break;
                case 3:
                    residency.Select();
                    break;
                case 4:
                    origin.GetComponent<TMP_InputField>().Select();
                    break;
                case 5:
                    experience.Select();
                    break;
                case 6:
                    remoteStudies.Select();
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "€";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "€";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "€";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "€";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "€";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "€";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "€";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "µ";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "µ";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "µ";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "µ";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "µ";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "µ";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "µ";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "@";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "@";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "@";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "@";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "@";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "@";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "@";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "²";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "²";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "²";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "²";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "²";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "²";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "²";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "³";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "³";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "³";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "³";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "³";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "³";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "³";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "{";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "{";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "{";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "{";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "{";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "{";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "{";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "[";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "[";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "[";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "[";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "[";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "[";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "[";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "]";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "]";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "]";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "]";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "]";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "]";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "]";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "}";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "}";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "}";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "}";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "}";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "}";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "}";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "\\";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "\\";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "\\";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "\\";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "\\";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "\\";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "\\";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += " ";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += " ";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += " ";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += " ";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += " ";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += " ";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += " ";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "|";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "|";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "|";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "|";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "|";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "|";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "|";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "~";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "~";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "~";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "~";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "~";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "~";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "~";
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




            if (altKeyboard.activeSelf == true)
            {
                altKeyboard.SetActive(false);
                lowerKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<AltKeyboardDInput>().enabled = false;
                GetComponent<ArrowInputField>().enabled = true;
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

            if (altKeyboard.activeSelf == true)
            {
                altKeyboard.SetActive(false);
                upperKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<AltKeyboardDInput>().enabled = false;
                GetComponent<UpperKeyboardInput>().enabled = true;
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


    public void writeTabulator()
    {

        if (tabButton.enabled == true)
        {
            InputSelected += 1;
            if (InputSelected > 6)
            {
                InputSelected = 0;
            }
            switch (InputSelected)
            {
                case 0:
                    age.Select();
                    break;
                case 1:
                    gender.Select();
                    break;
                case 2:
                    vision.Select();
                    break;
                case 3:
                    residency.Select();
                    break;
                case 4:
                    origin.GetComponent<TMP_InputField>().Select();
                    break;
                case 5:
                    experience.Select();
                    break;
                case 6:
                    remoteStudies.Select();
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
            if (vision.isFocused && (vision.GetComponent<TMP_InputField>().text.Length > 0))
            {
                vision.GetComponent<TMP_InputField>().text = vision.GetComponent<TMP_InputField>().text.Substring(0, vision.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (age.isFocused && (age.GetComponent<TMP_InputField>().text.Length > 0))
            {
                age.GetComponent<TMP_InputField>().text = age.GetComponent<TMP_InputField>().text.Substring(0, age.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (gender.isFocused && (gender.GetComponent<TMP_InputField>().text.Length > 0))
            {
                gender.GetComponent<TMP_InputField>().text = gender.GetComponent<TMP_InputField>().text.Substring(0, gender.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (residency.isFocused && (residency.GetComponent<TMP_InputField>().text.Length > 0))
            {
                residency.GetComponent<TMP_InputField>().text = residency.GetComponent<TMP_InputField>().text.Substring(0, residency.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (origin.GetComponent<TMP_InputField>().isFocused && (origin.GetComponent<TMP_InputField>().text.Length > 0))
            {
                origin.GetComponent<TMP_InputField>().text = origin.GetComponent<TMP_InputField>().text.Substring(0, origin.GetComponent<TMP_InputField>().text.Length - 1);
            }

            if (experience.isFocused && (experience.GetComponent<TMP_InputField>().text.Length > 0))
            {
                experience.GetComponent<TMP_InputField>().text = experience.GetComponent<TMP_InputField>().text.Substring(0, experience.GetComponent<TMP_InputField>().text.Length - 1);
            }
            if (remoteStudies.isFocused && (remoteStudies.GetComponent<TMP_InputField>().text.Length > 0))
            {
                remoteStudies.GetComponent<TMP_InputField>().text = remoteStudies.GetComponent<TMP_InputField>().text.Substring(0, remoteStudies.GetComponent<TMP_InputField>().text.Length - 1);
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


    private void ReActivatePfeilRechts()
    {
        pfeilRechtsButton.interactable = true;
    }

    private void ReActivateShift()
    {
        shiftButton.interactable = true;
    }

    private void ReActivateAlt()
    {
        altButton.interactable = true;
    }

    private void ReActivateStern()
    {
        sternButton.interactable = true;
    }

    private void ReActivateTab()
    {
        tabButton.interactable = true;
    }
    private void ReActivateArrowDown()
    {
        buttonArrowDown.interactable = true;
    }

    private void ReActivateArrowUp()
    {
        buttonArrowUp.interactable = true;
    }
    private void ReActivateE()
    {
        eButton.interactable = true;
    }

    

    private void ReActivateM()
    {
        mButton.interactable = true;
    }

    private void ReActivateQ()
    {
        qButton.interactable = true;
    }

    private void ReActivateTwo()
    {
        twoButton.interactable = true;
    }

    private void ReActivateThree()
    {
        threeButton.interactable = true;
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

    public string ToCSVDemography(string partID, string age, string gender, string vision, string residency, string origin, string experience, string remoteStudies)
    {
        var sb = new StringBuilder("Participant_ID, Age, Gender, Vision, Residency, Origin, Experience, Remote_Studies_participated");
        sb.Append('\n').Append(partID.ToString()).Append(" ").Append(age.ToString()).Append(" ").Append(gender.ToString()).Append(" ").Append(vision.ToString()).Append(" ").Append(residency.ToString()).Append(" ").Append(origin.ToString()).Append(" ").Append(experience.ToString()).Append(" ").Append(remoteStudies.ToString());
        return sb.ToString();

    }

    public void SaveToFile()
    {
        var content = ToCSVDemography(participantID, age.GetComponent<TMP_InputField>().text, gender.GetComponent<TMP_InputField>().text, vision.GetComponent<TMP_InputField>().text, residency.GetComponent<TMP_InputField>().text, origin.GetComponent<TMP_InputField>().text, experience.GetComponent<TMP_InputField>().text, remoteStudies.GetComponent<TMP_InputField>().text);
        string path = GetFilePath(file);
        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
        }

    }

    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
}
