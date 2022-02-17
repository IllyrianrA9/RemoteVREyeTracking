using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;

public class ArrowInputFieldPostStudy : MonoBehaviour
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
        if (GetComponent<LowerKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<LowerKeyboardInput>().InputSelected;
            GetComponent<LowerKeyboardInput>().wasActive = false;
        }
        if (GetComponent<AltKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<AltKeyboardInput>().InputSelected;
            GetComponent<AltKeyboardInput>().wasActive = false;
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
        if (GetComponent<LowerKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<LowerKeyboardInput>().InputSelected;
            GetComponent<LowerKeyboardInput>().wasActive = false;
        }
        if (GetComponent<AltKeyboardInput>().wasActive == true)
        {
            InputSelected = GetComponent<AltKeyboardInput>().InputSelected;
            GetComponent<AltKeyboardInput>().wasActive = false;
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
            postStudy.SetActive(false);
            lastText.SetActive(true);
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
        if(buttonBlockedUp > 1f)
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
      if(buttonBlockedDown > 1f)
        {
            buttonArrowDown.enabled = true;
        }
      
        buttonArrowDown.interactable = false;
        Invoke("ReActivateArrowDown", 1f);
    }

    public void writeA()
    {

        if(aButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "A";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "A";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "A";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "A";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "A";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "A";
            }
            aButton.enabled = false;
            buttonBlockeda = 0;
        }
        if(buttonBlockeda > 1f)
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "B";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "B";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "B";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "B";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "B";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "B";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "C";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "C";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "C";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "C";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "C";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "C";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "D";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "D";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "D";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "D";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "D";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "D";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "E";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "E";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "E";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "E";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "E";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "E";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "F";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "F";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "F";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "F";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "F";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "F";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "G";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "G";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "G";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "G";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "G";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "G";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "H";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "H";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "H";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "H";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "H";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "H";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "I";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "I";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "I";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "I";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "I";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "I";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "J";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "J";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "J";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "J";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "J";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "J";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "K";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "K";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "K";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "K";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "K";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "K";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "L";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "L";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "L";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "L";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "L";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "L";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "M";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "M";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "M";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "M";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "M";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "M";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "N";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "N";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "N";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "N";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "N";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "N";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "O";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "O";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "O";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "O";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "O";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "O";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "P";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "P";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "P";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "P";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "P";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "P";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "Q";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "Q";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "Q";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "Q";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "Q";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "Q";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "R";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "R";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "R";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "R";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "R";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "R";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "S";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "S";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "S";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "S";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "S";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "S";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "T";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "T";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "T";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "T";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "T";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "T";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "U";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "U";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "U";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "U";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "U";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "U";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "V";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "V";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "V";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "V";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "V";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "V";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "W";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "W";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "W";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "W";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "W";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "W";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "X";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "X";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "X";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "X";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "X";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "X";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "Y";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "Y";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "Y";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "Y";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "Y";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "Y";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "Z";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "Z";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "Z";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "Z";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "Z";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "Z";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "!";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "!";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "!";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "!";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "!";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "!";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "''";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "''";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "''";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "''";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "''";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "''";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "�";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "�";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "�";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "�";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "�";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "�";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "$";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "$";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "$";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "$";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "$";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "$";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "%";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "%";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "%";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "%";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "%";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "%";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "&";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "&";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "&";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "&";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "&";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "&";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "/";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "/";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "/";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "/";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "/";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "/";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "(";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "(";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "(";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "(";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "(";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "(";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += ")";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += ")";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += ")";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += ")";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += ")";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += ")";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "=";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "=";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "=";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "=";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "=";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "=";
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
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "?";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "?";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "?";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "?";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "?";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "?";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += ">";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += ">";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += ">";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += ">";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += ">";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += ">";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += ";";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += ";";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += ";";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += ";";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += ";";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += ";";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += ":";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += ":";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += ":";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += ":";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += ":";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += ":";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "_";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "_";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "_";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "_";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "_";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "_";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "'";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "'";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "'";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "'";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "'";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "'";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "*";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "*";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "*";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "*";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "*";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "*";
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
                GetComponent<ArrowInputFieldPostStudy>().enabled = false;
                GetComponent<AltKeyboardInput>().enabled = true;
            }
            altButton.enabled = false;
            buttonBlockedAlt= 0;
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

           

            if (upperKeyboard.activeSelf == true)
            {
                upperKeyboard.SetActive(false);
                lowerKeyboard.SetActive(true);
                wasActive = true;
                GetComponent<ArrowInputFieldPostStudy>().enabled = false;
                GetComponent<LowerKeyboardInput>().enabled = true;
                
            }
            shiftButton.enabled = false;
            buttonBlockedshift= 0;
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
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "�";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "�";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "�";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "�";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "�";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "�";
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
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "�";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "�";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "�";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "�";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "�";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "�";
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
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "�";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "�";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "�";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "�";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "�";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "�";
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
                answerWrong.GetComponent<TMP_InputField>().text = answerWrong.GetComponent<TMP_InputField>().text.Substring(0, answerWrong.GetComponent<TMP_InputField>().text.Length -1);
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

    public void ReActivateA()
    {
        aButton.interactable = true;
    }

    public void ReActivateB()
    {
        bButton.interactable = true;
    }

    public void ReActivateC()
    {
        cButton.interactable = true;
    }

    public void ReActivateD()
    {
        dButton.interactable = true;
    }

    public void ReActivateE()
    {
        eButton.interactable = true;
    }

    public void ReActivateF()
    {
        fButton.interactable = true;
    }

    public void ReActivateG()
    {
        gButton.interactable = true;
    }

    public void ReActivateH()
    {
        hButton.interactable = true;
    }

    public void ReActivateI()
    {
        iButton.interactable = true;
    }

    public void ReActivateJ()
    {
        jButton.interactable = true;
    }

    public void ReActivateK()
    {
        kButton.interactable = true;
    }

    public void ReActivateL()
    {
        lButton.interactable = true;
    }

    public void ReActivateM()
    {
        mButton.interactable = true;
    }

    public void ReActivateN()
    {
        nButton.interactable = true;
    }

    public void ReActivateO()
    {
        oButton.interactable = true;
    }

    public void ReActivateP()
    {
        pButton.interactable = true;
    }

    public void ReActivateQ()
    {
        qButton.interactable = true;
    }

    public void ReActivateR()
    {
        rButton.interactable = true;
    }

    public void ReActivateS()
    {
        sButton.interactable = true;
    }

    public void ReActivateT()
    {
        tButton.interactable = true;
    }

    public void ReActivateU()
    {
        uButton.interactable = true;
    }

    public void ReActivateV()
    {
        vButton.interactable = true;
    }

    public void ReActivateW()
    {
        wButton.interactable = true;
    }

    public void ReActivateX()
    {
        xButton.interactable = true;
    }

    public void ReActivateY()
    {
        yButton.interactable = true;
    }

    public void ReActivateZ()
    {
        zButton.interactable = true;
    }

    public void ReActivateOne()
    {
        oneButton.interactable = true;
    }

    public void ReActivateTwo()
    {
        twoButton.interactable = true;
    }

    public void ReActivateThree()
    {
        threeButton.interactable = true;
    }

    public void ReActivateFour()
    {
        fourButton.interactable = true;
    }

    public void ReActivateFive()
    {
        fiveButton.interactable = true;
    }

    public void ReActivateSix()
    {
        sixButton.interactable = true;
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

    public void ReActivate�()
    {
        �Button.interactable = true;
    }

    public void ReActivateSpace()
    {
        spaceButton.interactable = true;
    }

    public void ReActivateDelChar()
    {
        deleteChar.interactable = true;
    }

    public void ReActivate�()
    {
        �Button.interactable = true;
    }

    public void ReActivate�()
    {
        �Button.interactable = true;
    }

    public void ReActivate�()
    {
        �Button.interactable = true;
    }

    public void ReActivatePfeilRechts()
    {
        pfeilRechtsButton.interactable = true;
    }

    public void ReActivateStrichPunkt()
    {
        strichPunktButton.interactable = true;
    }

    public void ReActivateShift()
    {
        shiftButton.interactable = true;
    }

    public void ReActivateAlt()
    {
        altButton.interactable = true;
    }

    public void ReActivateDoppelPunkt()
    {
        doppelPunktButton.interactable = true;
    }

    public void ReActivateUnterstrich()
    {
        unterStrichButton.interactable = true;
    }

    public void ReActivateStern()
    {
        sternButton.interactable = true;
    }

    public void ReActivateHochChar()
    {
        hochCharButton.interactable = true;
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
