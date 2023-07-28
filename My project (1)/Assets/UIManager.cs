using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject btnGameOver;
    static public UIManager intances;

    private void Awake()
    {
        UIManager.intances = this;
        this.btnGameOver = GameObject.Find("BtnGameOver");
        this.btnGameOver.SetActive(false);
    }

}
