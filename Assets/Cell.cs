using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Cell : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Image mBgImg, mContentImg;
    public RectTransform mRectTransform;
    public Color mNormalColor;
    public Board mBoard = null;
    public Global mGlobal;
    
    public Sprite goldLilySprite, blueLilySprite, pinkLilySprite, whiteLilySprite;
    // Start is called before the first frame update
    void Start()
    {
        goldLilySprite = Resources.Load<Sprite>("img_yellow");
        blueLilySprite = Resources.Load<Sprite>("img_blue");
        pinkLilySprite = Resources.Load<Sprite>("img_pink");
        whiteLilySprite = Resources.Load<Sprite>("img_white");

        mRectTransform = GetComponent<RectTransform>();
        mBgImg = GetComponent<Image>();
        GameObject c = transform.GetChild(0).gameObject;
        mContentImg = c.GetComponent<Image>();
        GameObject globalObj = GameObject.Find("GlobalObj");
        mGlobal = globalObj.GetComponent<Global>();
        mBgImg.color = mNormalColor;
        mContentImg.color = mNormalColor;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData) {
      Debug.Log("Cell click");
      if (mGlobal.mSelectedLilyType != LilyType.None) {
        Debug.Log("Cell click " + mGlobal.mSelectedLilyType.ToString("g"));
        switch (mGlobal.mSelectedLilyType)
        {
            case LilyType.Gold: 
              mContentImg.sprite = goldLilySprite;
              break;
            case LilyType.Blue:
              mContentImg.sprite = blueLilySprite;
              break;
            case LilyType.Pink:
              mContentImg.sprite = pinkLilySprite;
              break;
            case LilyType.White:
              mContentImg.sprite = whiteLilySprite;
              break;
            default:
              break;
        }
      }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("The cursor entered the selectable UI element.");
        Color newColor = mNormalColor;
        newColor.a = 0.8f;
        mBgImg.color = newColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      Debug.Log("The cursor exited the selectable UI element.");
      mBgImg.color = mNormalColor;
    }

}
