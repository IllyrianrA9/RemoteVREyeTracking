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
            if (string.IsNullOrEmpty(age.text))
            {
                ageObject.SetActive(true);
            }

            if (string.IsNullOrEmpty(gender.text))
            {
                genderObject.SetActive(true);
            }

            if (string.IsNullOrEmpty(vision.text))
            {
                visionObject.SetActive(true);
            }

            if (string.IsNullOrEmpty(residency.text))
            {
                residencyObject.SetActive(true);
            }

            if (string.IsNullOrEmpty(origin.text))
            {
                originObject.SetActive(true);
            }

            if (string.IsNullOrEmpty(experience.text))
            {
                experienceObejct.SetActive(true);
            }

            if (string.IsNullOrEmpty(remoteStudies.text))
            {
                remoteStudiesObject.SetActive(true);
            }

            if (!string.IsNullOrEmpty(age.text))
            {
                ageObject.SetActive(false);
            }

            if (!string.IsNullOrEmpty(gender.text))
            {
                genderObject.SetActive(false);
            }

            if (!string.IsNullOrEmpty(vision.text))
            {
                visionObject.SetActive(false);
            }

            if (!string.IsNullOrEmpty(residency.text))
            {
                residencyObject.SetActive(false);
            }

            if (!string.IsNullOrEmpty(origin.text))
            {
                originObject.SetActive(false);
            }

            if (!string.IsNullOrEmpty(experience.text))
            {
                experienceObejct.SetActive(false);
            }

            if (!string.IsNullOrEmpty(remoteStudies.text))
            {
                remoteStudiesObject.SetActive(false);
            }
            if (!string.IsNullOrEmpty(age.text) && !string.IsNullOrEmpty(gender.text) && !string.IsNullOrEmpty(vision.text) & !string.IsNullOrEmpty(residency.text) && !string.IsNullOrEmpty(origin.text) && !string.IsNullOrEmpty(experience.text) && !string.IsNullOrEmpty(remoteStudies.text))
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
