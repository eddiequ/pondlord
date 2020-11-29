using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LilyButton : MonoBehaviour
{
    // Start is called before the first frame update
    public LilyType mLilyType = LilyType.None;
    public Button mButton;
    private bool isSelected = false; // Custom state for button press

    void Start()
    {
        mButton = GetComponent<Button>();
        mButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButtonClick() {
        Debug.Log("You have clicked the button " + mLilyType.ToString("g"));
        ColorBlock cBlock = mButton.colors;
        Image buttonImage = mButton.GetComponent<Image>();
        if (!isSelected) {
          buttonImage.color = cBlock.pressedColor;
        } else {
          buttonImage.color = cBlock.normalColor;
        }
        isSelected = !isSelected;
    }
}
