using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;

public class UpperKeyboardInput : MonoBehaviour
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
    public GameObject �;
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
    public GameObject �;
    public GameObject �;
    public GameObject �;
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
    private Button �Button;
    private Button deleteChar;

    private Button tabButton;
    private Button �Button;
    private Button �Button;
    private Button �Button;
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
    public float buttonBlocked� = 0;
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
    public float buttonBlocked� = 0;
    public float buttonBlocked� = 0;
    public float buttonBlocked� = 0;
    public float buttonBlockedStrichPunkt = 0;
    public float buttonBlockedDoppelPunkt = 0;
    public float buttonBlockedUnterStrich = 0;
    public float buttonBlockedAlt = 0;
    public float buttonBlockedStern = 0;
    public float buttonBlockedHochChar = 0;
    private bool partTrueID = true;

    void Start()
    {

        if (GetComponent<ArrowInputField>().wasActive == true)
        {
            InputSelected = GetComponent<ArrowInputField>().InputSelected;
            GetComponent<ArrowInputField>().wasActive = false;
        }
        if (GetComponent<AltKeyboardDInput>().wasActive == true)
        {
            InputSelected = GetComponent<AltKeyboardDInput>().InputSelected;
            GetComponent<AltKeyboardDInput>().wasActive = false;
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
        �Button = �.GetComponent<Button>();
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
        �Button = �.GetComponent<Button>();
        �Button = �.GetComponent<Button>();
        �Button = �.GetComponent<Button>();
        strichPunktButton = strichPunkt.GetComponent<Button>();
        doppelPunktButton = doppelPunkt.GetComponent<Button>();
        unterStrichButton = unterStrich.GetComponent<Button>();
        hochCharButton = hochChar.GetComponent<Button>();
        sternButton = stern.GetComponent<Button>();
        altButton = alt.GetComponent<Button>();


    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<ArrowInputField>().wasActive == true)
        {
            InputSelected = GetComponent<ArrowInputField>().InputSelected;
            GetComponent<ArrowInputField>().wasActive = false;
        }
        if (GetComponent<AltKeyboardDInput>().wasActive == true)
        {
            InputSelected = GetComponent<AltKeyboardDInput>().InputSelected;
            GetComponent<AltKeyboardDInput>().wasActive = false;
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
        buttonBlocked� += Time.deltaTime;
        buttonBlockeddel += Time.deltaTime;

        buttonBlockedStrichPunkt += Time.deltaTime;
        buttonBlockedStern += Time.deltaTime;
        buttonBlockedtab += Time.deltaTime;
        buttonBlockedshift += Time.deltaTime;
        buttonBlockedUnterStrich += Time.deltaTime;
        buttonBlockedpfeilRechts += Time.deltaTime;
        buttonBlocked� += Time.deltaTime;
        buttonBlocked� += Time.deltaTime;
        buttonBlocked� += Time.deltaTime;
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

    public void writeA()
    {

        if (aButton.enabled == true)
        {
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "A";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "A";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "A";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "A";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "A";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "A";
            }

            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "A";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "B";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "B";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "B";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "B";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "B";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "B";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "B";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "C";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "C";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "C";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "C";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "C";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "C";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "C";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "D";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "D";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "D";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "D";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "D";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "D";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "D";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "E";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "E";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "E";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "E";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "E";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "E";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "E";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "F";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "F";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "F";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "F";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "F";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "F";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "F";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "G";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "G";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "G";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "G";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "G";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "G";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "G";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "H";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "H";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "H";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "H";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "H";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "H";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "H";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "I";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "I";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "I";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "I";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "I";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "I";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "I";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "J";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "J";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "J";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "J";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "J";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "J";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "J";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "K";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "K";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "K";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "K";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "K";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "K";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "K";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "L";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "L";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "L";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "L";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "L";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "L";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "L";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "M";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "M";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "M";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "M";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "M";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "M";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "M";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "N";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "N";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "N";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "N";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "N";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "N";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "N";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "O";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "O";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "O";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "O";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "O";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "O";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "O";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "P";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "P";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "P";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "P";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "P";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "P";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "P";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "Q";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "Q";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "Q";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "Q";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "Q";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "Q";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "Q";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "R";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "R";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "R";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "R";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "R";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "R";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "R";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "S";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "S";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "S";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "S";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "S";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "S";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "S";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "T";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "T";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "T";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "T";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "T";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "T";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "T";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "U";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "U";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "U";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "U";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "U";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "U";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "U";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "V";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "V";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "V";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "V";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "V";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "V";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "V";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "W";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "W";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "W";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "W";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "W";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "W";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "W";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "X";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "X";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "X";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "X";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "X";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "X";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "X";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "Y";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "Y";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "Y";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "Y";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "Y";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "Y";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "Y";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "Z";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "Z";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "Z";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "Z";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "Z";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "Z";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "Z";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "!";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "!";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "!";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "!";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "!";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "!";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "!";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "''";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "''";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "''";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "''";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "''";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "''";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "''";
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
                vision.GetComponent<TMP_InputField>().text += "�";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "�";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "�";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "�";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "�";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "�";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "�";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "$";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "$";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "$";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "$";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "$";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "$";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "$";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "%";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "%";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "%";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "%";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "%";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "%";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "%";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "&";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "&";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "&";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "&";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "&";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "&";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "&";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "/";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "/";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "/";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "/";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "/";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "/";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "/";
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
                vision.GetComponent<TMP_InputField>().text += "(";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "(";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "(";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "(";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "(";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "(";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "(";
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
                vision.GetComponent<TMP_InputField>().text += ")";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += ")";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += ")";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += ")";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += ")";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += ")";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += ")";
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
                vision.GetComponent<TMP_InputField>().text += "=";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "=";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "=";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "=";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "=";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "=";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "=";
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

    public void write�()
    {

        if (�Button.enabled == true)
        {
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "?";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "?";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "?";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "?";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "?";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "?";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "?";
            }
            �Button.enabled = false;
            buttonBlocked� = 0;
        }
        if (buttonBlocked� > 1f)
        {
            �Button.enabled = true;
        }
        �Button.interactable = false;
        Invoke("ReActivate�", 1f);

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
                vision.GetComponent<TMP_InputField>().text += ">";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += ">";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += ">";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += ">";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += ">";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += ">";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += ">";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += ";";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += ";";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += ";";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += ";";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += ";";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += ";";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += " ";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += ":";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += ":";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += ":";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += ":";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += ":";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += ":";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += ":";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "_";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "_";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "_";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "_";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "_";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "_";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "_";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "'";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "'";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "'";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "'";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "'";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "'";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "'";
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
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "*";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "*";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "*";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "*";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "*";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "*";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "*";
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




            if (upperKeyboard.activeSelf == true)
            {
                upperKeyboard.SetActive(false);
                altKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<UpperKeyboardInput>().enabled = false;
                GetComponent<AltKeyboardDInput>().enabled = true;
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

            if (upperKeyboard.activeSelf == true)
            {
                upperKeyboard.SetActive(false);
                lowerKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<UpperKeyboardInput>().enabled = false;
                GetComponent<ArrowInputField>().enabled = true;
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

    public void write�()
    {

        if (�Button.enabled == true)
        {
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "�";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "�";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "�";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "�";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "�";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "�";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "�";
            }
            �Button.enabled = false;
            buttonBlocked� = 0;
        }
        if (buttonBlocked� > 1f)
        {
            �Button.enabled = true;
        }
        �Button.interactable = false;
        Invoke("ReActivate�", 1f);

    }

    public void write�()
    {

        if (�Button.enabled == true)
        {
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "�";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "�";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "�";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "�";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "�";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "�";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "�";
            }
            �Button.enabled = false;
            buttonBlocked� = 0;
        }
        if (buttonBlocked� > 1f)
        {
            �Button.enabled = true;
        }
        �Button.interactable = false;
        Invoke("ReActivate�", 1f);

    }

    public void write�()
    {

        if (�Button.enabled == true)
        {
            if (vision.isFocused)
            {
                vision.GetComponent<TMP_InputField>().text += "�";
            }

            if (age.isFocused)
            {
                age.GetComponent<TMP_InputField>().text += "�";
            }

            if (gender.isFocused)
            {
                gender.GetComponent<TMP_InputField>().text += "�";
            }

            if (residency.isFocused)
            {
                residency.GetComponent<TMP_InputField>().text += "�";
            }

            if (origin.GetComponent<TMP_InputField>().isFocused)
            {
                origin.GetComponent<TMP_InputField>().text += "�";
            }

            if (experience.isFocused)
            {
                experience.GetComponent<TMP_InputField>().text += "�";
            }
            if (remoteStudies.isFocused)
            {
                remoteStudies.GetComponent<TMP_InputField>().text += "�";
            }
            �Button.enabled = false;
            buttonBlocked� = 0;
        }
        if (buttonBlocked� > 1f)
        {
            �Button.enabled = true;
        }
        �Button.interactable = false;
        Invoke("ReActivate�", 1f);

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

    private void ReActivate�()
    {
        �Button.interactable = true;
    }

    private void ReActivate�()
    {
        �Button.interactable = true;
    }

    private void ReActivate�()
    {
        �Button.interactable = true;
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

    private void ReActivate�()
    {
        �Button.interactable = true;
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
