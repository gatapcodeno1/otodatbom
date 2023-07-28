using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl instance;
    public DamageRecive damageRecive;
    public PlayerStatus playerStatus;
    private void Awake()
    {
        PlayerCtrl.instance = this;
        this.damageRecive = GetComponent<DamageRecive>();
        this.playerStatus = GetComponent<PlayerStatus>();

    }
}
