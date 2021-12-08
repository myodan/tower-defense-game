using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Button : MonoBehaviour
{
    public GameObject info_win = null;

    public void info()
    {
        if (info_win.activeSelf)
        {
            info_win.SetActive(false);
        }
        else
        {
            info_win.SetActive(true);
        }
    }
}
