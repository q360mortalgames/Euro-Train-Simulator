using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnContinueGame()
    {
        UIHandler.Instance.RequestToEnableObject(0);
    }

    public void OnExitGame()
    {
        Application.Quit();
    }
}
