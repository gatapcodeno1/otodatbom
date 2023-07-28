using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReciver : DamageRecive
{
    protected PlayerCtrl playerCtrl;

    private void Awake()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
    }

    public override void Recive(int damage)
    {
        base.Recive(damage);
        if (this.IsDead())
        {
            UIManager.intances.btnGameOver.SetActive(true);
            this.playerCtrl.playerStatus.Dead();

        }
    }
}
