using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;

public class SelectAnswers : MonoBehaviour
{
    public GameObject topicSelection;
    public GameObject topic1;
    public GameObject topic2;
    public GameObject topic3;
    public GameObject topic4;
    public GameObject topic5;
    public GameObject topic6;
    public GameObject topic7;
    public GameObject topic8;

    public GameObject cancelVote1;
    public GameObject cancelVote2;

    public GameObject confirmSelection;

    public GameObject chosenAnswer1;
    public GameObject chosenAnswer2;

    private Button topicButton1;
    private Button topicButton2;
    private Button topicButton3; 
    private Button topicButton4;
    private Button topicButton5;
    private Button topicButton6;
    private Button topicButton7;
    private Button topicButton8;

    private Button cancelVoteButton1;
    private Button cancelVoteButton2;

    private Button confirmSelectionButton;

    private string chosenStringAnswer1;
    private string chosenStringAnswer2;
    // Start is called before the first frame update
    void Start()
    {
        topicButton1 = topic1.GetComponent<Button>();
        topicButton2 = topic2.GetComponent<Button>();
        topicButton3 = topic3.GetComponent<Button>();
        topicButton4 = topic4.GetComponent<Button>();
        topicButton5 = topic5.GetComponent<Button>();
        topicButton6 = topic6.GetComponent<Button>();
        topicButton7 = topic7.GetComponent<Button>();
        topicButton8 = topic8.GetComponent<Button>();

        cancelVoteButton1 = cancelVote1.GetComponent<Button>();
        cancelVoteButton2 = cancelVote2.GetComponent<Button>();

        confirmSelectionButton = confirmSelection.GetComponent<Button>();

        chosenStringAnswer1 = chosenAnswer1.GetComponent<TMP_Text>().text;
        chosenStringAnswer2 = chosenAnswer2.GetComponent<TMP_Text>().text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectTopic1()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton1.GetComponentInChildren<Text>().text;
            topic1.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if (string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton1.GetComponentInChildren<Text>().text;
            topic1.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectTopic2()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton2.GetComponentInChildren<Text>().text;
            topic2.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if (string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton2.GetComponentInChildren<Text>().text;
            topic2.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }

    }

    public void selectTopic3()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton3.GetComponentInChildren<Text>().text;
            topic3.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if (string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton3.GetComponentInChildren<Text>().text;
            topic3.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectTopic4()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton4.GetComponentInChildren<Text>().text;
            topic4.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if (string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton4.GetComponentInChildren<Text>().text;
            topic4.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectTopic5()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton5.GetComponentInChildren<Text>().text;
            topic5.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if (string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton5.GetComponentInChildren<Text>().text;
            topic5.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectTopic6()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton6.GetComponentInChildren<Text>().text;
            topic6.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if (string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton6.GetComponentInChildren<Text>().text;
            topic6.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectTopic7()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton7.GetComponentInChildren<Text>().text;
            topic7.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton7.GetComponentInChildren<Text>().text;
            topic7.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectTopic8()
    {
        if (string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text))
        {
            chosenAnswer1.GetComponent<TMP_Text>().text = topicButton8.GetComponentInChildren<Text>().text;
            topic8.SetActive(false);
            cancelVote1.SetActive(true);
        }
        else if (string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text))
        {
            chosenAnswer2.GetComponent<TMP_Text>().text = topicButton8.GetComponentInChildren<Text>().text;
            topic8.SetActive(false);
            cancelVote2.SetActive(true);
        }
        if(!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void cancelVote1WithClick()
    {
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton1.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic1.SetActive(true);
        }
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton2.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic2.SetActive(true);
        }
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton3.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic3.SetActive(true);
        }
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton4.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic4.SetActive(true);
        }
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton5.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic5.SetActive(true);
        }
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton6.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic6.SetActive(true);
        }
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton7.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic7.SetActive(true);
        }
        if (chosenAnswer1.GetComponent<TMP_Text>().text.Trim().Equals(topicButton8.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer1.GetComponent<TMP_Text>().text = "";
            cancelVote1.SetActive(false);
            topic8.SetActive(true);
        }
    }

    public void cancelVote2WithClick()
    {
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton1.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic1.SetActive(true);
        }
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton2.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic2.SetActive(true);
        }
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton3.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic3.SetActive(true);
        }
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton4.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic4.SetActive(true);
        }
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton5.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic5.SetActive(true);
        }
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton6.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic6.SetActive(true);
        }
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton7.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic7.SetActive(true);
        }
        if (chosenAnswer2.GetComponent<TMP_Text>().text.Trim().Equals(topicButton8.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            chosenAnswer2.GetComponent<TMP_Text>().text = "";
            cancelVote2.SetActive(false);
            topic8.SetActive(true);
        }
    }
    public void confirmSelectionWithClick()
    {
        if(!(string.IsNullOrWhiteSpace(chosenAnswer1.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(chosenAnswer2.GetComponent<TMP_Text>().text)))
        {
            topicSelection.SetActive(false);
            //Aktiviere ersten Bildschirm &
        }
    }
}
