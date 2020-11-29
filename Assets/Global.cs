using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LilyType {
  Gold,
  Blue,
  Pink,
  White,
  None
}

public static class GameConstants {
  public static int mBoardWidth = 8;
  public static int mBoardHeight = 8;
}

public class Global : MonoBehaviour
{
    // Start is called before the first frame update
    public LilyType mSelectedLilyType = LilyType.None;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLilySelect(LilyType newType) {
      mSelectedLilyType = newType;
    }

    public void OnLilyDeselect() {
      mSelectedLilyType = LilyType.None;
    }
}
