using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArrowInputField : MonoBehaviour
{

    public TMP_InputField age;
    public TMP_InputField gender;
    public TMP_InputField vision;
    public TMP_InputField residency;
    public TMP_InputField origin;
    public TMP_InputField experience;
    public TMP_InputField remoteStudies;
    public GameObject objectButton;
    private Button button;

    public GameObject ageObject;
    public GameObject genderObject;
    public GameObject visionObject;
    public GameObject residencyObject;
    public GameObject originObject;
    public GameObject experienceObejct;
    public GameObject remoteStudiesObject;

    public int InputSelected;

    // Start is called before the first frame update
    void Start()
    {
        button = objectButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (age.text.Trim().Length == 0)
            {
                ageObject.SetActive(true);
            }

            if (gender.text.Trim().Length == 0)
            {
                genderObject.SetActive(true);
            }

            if (vision.text.Trim().Length == 0)
            {
                visionObject.SetActive(true);
            }

            if (residency.text.Trim().Length == 0)
            {
                residencyObject.SetActive(true);
            }

            if (origin.text.Trim().Length == 0)
            {
                originObject.SetActive(true);
            }

            if (experience.text.Trim().Length == 0)
            {
                experienceObejct.SetActive(true);
            }

            if (remoteStudies.text.Trim().Length == 0)
            {
                remoteStudiesObject.SetActive(true);
            }

            if (!(age.text.Trim().Length == 0))
            {
                ageObject.SetActive(false);
            }

            if (!(gender.text.Trim().Length == 0))
            {
                genderObject.SetActive(false);
            }

            if (!(vision.text.Trim().Length == 0))
            {
                visionObject.SetActive(false);
            }

            if (!(residency.text.Trim().Length == 0))
            {
                residencyObject.SetActive(false);
            }

            if (!(origin.text.Trim().Length == 0))
            {
                originObject.SetActive(false);
            }

            if (!(experience.text.Trim().Length == 0))
            {
                experienceObejct.SetActive(false);
            }

            if (!(remoteStudies.text.Trim().Length == 0))
            {
                remoteStudiesObject.SetActive(false);
            }
            if (!(age.text.Trim().Length == 0) && !(gender.text.Trim().Length == 0) && !(vision.text.Trim().Length == 0) & !(residency.text.Trim().Length == 0) && !(origin.text.Trim().Length == 0) && !(experience.text.Trim().Length == 0) && !(remoteStudies.text.Trim().Length == 0))
            {
                if (ageObject.activeSelf == true)
                {
                    ageObject.SetActive(false);
                }
                if (genderObject.activeSelf == true)
                {
                    genderObject.SetActive(false);
                }
                if (visionObject.activeSelf == true)
                {
                    visionObject.SetActive(false);
                }
                if (residencyObject.activeSelf == true)
                {
                    residencyObject.SetActive(false);
                }
                if (originObject.activeSelf == true)
                {
                    originObject.SetActive(false);
                }
                if (experienceObejct.activeSelf == true)
                {
                    experienceObejct.SetActive(false);
                }
                if (remoteStudiesObject.activeSelf == true)
                {
                    remoteStudiesObject.SetActive(false);
                }
                button.onClick.Invoke();

            }
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            InputSelected--;
            if(InputSelected < 0)
            {
                InputSelected = 6;
            }
            SelectInputField();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            InputSelected++;
            if(InputSelected > 6)
            {
                InputSelected = 0;
            }
            SelectInputField();
        }

        void SelectInputField()
        {
            switch (InputSelected)
            {
                case 0: age.Select();
                    break;
                case 1: gender.Select();
                    break;
                case 2: vision.Select();
                    break;
                case 3: residency.Select();
                    break;
                case 4: origin.Select();
                    break;
                case 5: experience.Select();
                    break;
                case 6: remoteStudies.Select();
                    break;
            }
        }
    }
}
