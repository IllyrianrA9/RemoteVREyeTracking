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
    public GameObject ﬂ;
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
    private Button ﬂButton;
    private Button deleteChar;

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
    public float buttonBlockedﬂ = 0;
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
        ﬂButton = ﬂ.GetComponent<Button>();
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


    }

    // Update is called once per frame
    void Update()
    {
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
        buttonBlockedﬂ += Time.deltaTime;
        buttonBlockeddel += Time.deltaTime;

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
                difficultyStudy.GetComponent<TMP_InputField>().text += "a";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "a";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "a";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "a";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "a";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "a";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "b";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "b";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "b";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "b";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "b";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "b";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "c";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "c";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "c";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "c";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "c";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "c";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "d";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "d";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "d";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "d";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "d";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "d";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "e";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "e";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "e";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "e";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "e";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "e";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "f";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "f";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "f";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "f";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "f";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "f";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "g";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "g";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "g";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "g";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "g";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "g";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "h";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "h";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "h";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "h";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "h";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "h";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "i";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "i";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "i";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "i";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "i";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "i";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "j";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "j";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "j";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "j";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "j";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "j";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "k";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "k";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "k";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "k";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "k";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "k";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "l";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "l";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "l";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "l";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "l";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "l";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "m";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "m";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "m";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "m";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "m";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "m";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "n";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "n";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "n";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "n";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "n";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "n";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "o";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "o";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "o";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "o";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "o";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "o";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "p";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "p";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "p";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "p";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "p";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "p";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "q";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "q";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "q";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "q";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "q";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "q";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "r";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "r";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "r";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "r";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "r";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "r";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "s";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "s";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "s";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "s";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "s";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "s";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "t";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "t";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "t";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "t";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "t";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "t";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "u";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "u";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "u";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "u";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "u";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "u";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "v";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "v";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "v";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "v";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "v";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "v";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "w";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "w";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "w";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "w";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "w";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "w";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "x";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "x";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "x";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "x";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "x";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "x";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "y";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "y";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "y";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "y";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "y";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "y";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "z";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "z";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "z";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "z";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "z";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "z";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "1";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "1";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "1";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "1";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "1";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "1";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "2";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "2";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "2";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "2";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "2";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "2";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "3";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "3";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "3";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "3";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "3";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "3";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "4";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "4";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "4";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "4";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "4";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "4";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "5";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "5";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "5";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "5";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "5";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "5";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "6";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "6";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "6";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "6";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "6";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "6";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "7";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "7";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "7";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "7";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "7";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "7";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "8";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "8";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "8";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "8";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "8";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "8";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "9";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "9";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "9";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "9";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "9";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "9";
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
                difficultyStudy.GetComponent<TMP_InputField>().text += "0";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "0";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "0";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "0";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "0";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "0";
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

    public void writeﬂ()
    {

        if (ﬂButton.enabled == true)
        {
            if (difficultyStudy.isFocused)
            {
                difficultyStudy.GetComponent<TMP_InputField>().text += "ﬂ";
            }

            if (distraction.isFocused)
            {
                distraction.GetComponent<TMP_InputField>().text += "ﬂ";
            }

            if (distractionOnScreen.isFocused)
            {
                distractionOnScreen.GetComponent<TMP_InputField>().text += "ﬂ";
            }

            if (answerWrong.isFocused)
            {
                answerWrong.GetComponent<TMP_InputField>().text += "ﬂ";
            }

            if (moreInstruction.GetComponent<TMP_InputField>().isFocused)
            {
                moreInstruction.GetComponent<TMP_InputField>().text += "ﬂ";
            }

            if (vrCamera.isFocused)
            {
                vrCamera.GetComponent<TMP_InputField>().text += "ﬂ";
            }
            ﬂButton.enabled = false;
            buttonBlockedﬂ = 0;
        }
        if (buttonBlockedﬂ > 1f)
        {
            ﬂButton.enabled = true;
        }
        ﬂButton.interactable = false;
        Invoke("ReActivateﬂ", 1f);

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

    public void ReActivateﬂ()
    {
        ﬂButton.interactable = true;
    }

    public void ReActivateSpace()
    {
        spaceButton.interactable = true;
    }

    public void ReActivateDelChar()
    {
        deleteChar.interactable = true;
    }
}
