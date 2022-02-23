using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.IO;

public class PwEvaluation : MonoBehaviour
{
    public GameObject topic1;
    public GameObject topic2;
    public GameObject topic3;
    public GameObject topic4;
    public GameObject topic5;
    public GameObject topic6;
    public GameObject topic7;
    public GameObject topic8;
    public GameObject topic9;
    public GameObject topic10;

    public GameObject cancelVote1;
    public GameObject cancelVote2;
    public GameObject confirmSelection;

    public GameObject memoryObj;
    public GameObject strongObj;

    public Button topicButton1;
    public Button topicButton2;
    public Button topicButton3;
    public Button topicButton4;
    public Button topicButton5;
    public Button topicButton6;
    public Button topicButton7;
    public Button topicButton8;
    public Button topicButton9;
    public Button topicButton10;

    public Button cancelVoteButton1;
    public Button cancelVoteButton2;

    public Button confirmSelectionButton;

    public string memory;
    public string strongPW;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void selectMemoryTopic1()
    {
        if (string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text))
        {
            memoryObj.GetComponent<TMP_Text>().text = topicButton1.GetComponentInChildren<Text>().text;
            topic1.SetActive(false);
            cancelVote1.SetActive(true);
            memory = memoryObj.GetComponent<TMP_Text>().text;
        }
        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectMemoryTopic2()
    {
        if (string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text))
        {
            memoryObj.GetComponent<TMP_Text>().text = topicButton2.GetComponentInChildren<Text>().text;
            topic2.SetActive(false);
            cancelVote1.SetActive(true);
            memory = memoryObj.GetComponent<TMP_Text>().text;
        }

        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }

    }

    public void selectMemoryTopic3()
    {
        if (string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text))
        {
            memoryObj.GetComponent<TMP_Text>().text = topicButton3.GetComponentInChildren<Text>().text;
            topic3.SetActive(false);
            cancelVote1.SetActive(true);
            memory = memoryObj.GetComponent<TMP_Text>().text;
        }

        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectMemoryTopic4()
    {
        if (string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text))
        {
            memoryObj.GetComponent<TMP_Text>().text = topicButton4.GetComponentInChildren<Text>().text;
            topic4.SetActive(false);
            cancelVote1.SetActive(true);
            memory = memoryObj.GetComponent<TMP_Text>().text;
        }

        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectMemoryTopic5()
    {
        if (string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text))
        {
            memoryObj.GetComponent<TMP_Text>().text = topicButton5.GetComponentInChildren<Text>().text;
            topic5.SetActive(false);
            cancelVote1.SetActive(true);
            memory = memoryObj.GetComponent<TMP_Text>().text;
        }

        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectHardTopic1()
    {
        
        if (string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text))
        {
            strongObj.GetComponent<TMP_Text>().text = topicButton6.GetComponentInChildren<Text>().text;
            topic6.SetActive(false);
            cancelVote2.SetActive(true);
            strongPW = strongObj.GetComponent<TMP_Text>().text;
        }
        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectHardTopic2()
    {
        
        if (string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text))
        {
            strongObj.GetComponent<TMP_Text>().text = topicButton7.GetComponentInChildren<Text>().text;
            topic7.SetActive(false);
            cancelVote2.SetActive(true);
            strongPW = strongObj.GetComponent<TMP_Text>().text;
        }
        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }

    }

    public void selectHardTopic3()
    {
        
        if (string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text))
        {
            strongObj.GetComponent<TMP_Text>().text = topicButton8.GetComponentInChildren<Text>().text;
            topic8.SetActive(false);
            cancelVote2.SetActive(true);
            strongPW = strongObj.GetComponent<TMP_Text>().text;
        }
        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectHardTopic4()
    {
        
        if (string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text))
        {
            strongObj.GetComponent<TMP_Text>().text = topicButton9.GetComponentInChildren<Text>().text;
            topic9.SetActive(false);
            cancelVote2.SetActive(true);
            strongPW = strongObj.GetComponent<TMP_Text>().text;
        }
        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void selectHardTopic5()
    {
        
        if (string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text))
        {
            strongObj.GetComponent<TMP_Text>().text = topicButton10.GetComponentInChildren<Text>().text;
            topic10.SetActive(false);
            cancelVote2.SetActive(true);
            strongPW = strongObj.GetComponent<TMP_Text>().text;
        }
        if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
        {
            confirmSelection.SetActive(true);
        }
    }

    public void cancelVote1WithClick()
    {
        if (memoryObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton1.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            memoryObj.GetComponent<TMP_Text>().text = "";
            memory = "";

            cancelVote1.SetActive(false);
            topic1.SetActive(true);
        }
        if (memoryObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton2.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            memoryObj.GetComponent<TMP_Text>().text = "";
            memory = "";
            cancelVote1.SetActive(false);
            topic2.SetActive(true);
        }
        if (memoryObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton3.GetComponentInChildren<Text>().text.Trim()))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            memoryObj.GetComponent<TMP_Text>().text = "";
            memory = "";
            cancelVote1.SetActive(false);
            topic3.SetActive(true);
        }
        if (memoryObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton4.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            memoryObj.GetComponent<TMP_Text>().text = "";
            memory = "";
            cancelVote1.SetActive(false);
            topic4.SetActive(true);
        }
        if (memoryObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton5.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            memoryObj.GetComponent<TMP_Text>().text = "";
            memory = "";
            cancelVote1.SetActive(false);
            topic5.SetActive(true);
        }
    }

    public void cancelVote2WithClick()
    {
        if (strongObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton6.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            strongObj.GetComponent<TMP_Text>().text = "";
            strongPW = "";
            cancelVote2.SetActive(false);
            topic6.SetActive(true);
        }
        if (strongObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton7.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            strongObj.GetComponent<TMP_Text>().text = "";
            strongPW = "";
            cancelVote2.SetActive(false);
            topic7.SetActive(true);
        }
        if (strongObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton8.GetComponentInChildren<Text>().text.Trim()))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            strongObj.GetComponent<TMP_Text>().text = "";
            strongPW = "";
            cancelVote2.SetActive(false);
            topic8.SetActive(true);
        }
        if (strongObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton9.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            strongObj.GetComponent<TMP_Text>().text = "";
            strongPW = "";
            cancelVote2.SetActive(false);
            topic9.SetActive(true);
        }
        if (strongObj.GetComponent<TMP_Text>().text.Trim().Equals(topicButton10.GetComponentInChildren<Text>().text))
        {
            if (!(string.IsNullOrWhiteSpace(memoryObj.GetComponent<TMP_Text>().text)) && !(string.IsNullOrWhiteSpace(strongObj.GetComponent<TMP_Text>().text)))
            {
                confirmSelection.SetActive(false);
            }
            strongObj.GetComponent<TMP_Text>().text = "";
            strongPW = "";
            cancelVote2.SetActive(false);
            topic10.SetActive(true);
        }
    }
}
