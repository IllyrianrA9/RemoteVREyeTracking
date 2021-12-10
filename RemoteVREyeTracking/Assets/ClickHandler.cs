using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour
{
    public KeyCode key;
    private Button button;

    //Get Button component
    void Awake(){
        button = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if key is in up or down state and start on Click method
        if(Input.GetKeyDown(key)){
            FadeToColor(button.colors.pressedColor);
            button.onClick.Invoke();
        }
        else if(Input.GetKeyUp(key)){
            FadeToColor(button.colors.normalColor);
        }
        
    }
    //Fade to color of pressed button when clicked
    void FadeToColor(Color color){
        Graphic graphic = GetComponent<Graphic>();
        graphic.CrossFadeColor(color, button.colors.fadeDuration, true, true);
    }
}
