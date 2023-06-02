using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyAtack : IAtack
{

    private float _timer = 0;
    public void Atack(IApplyDamage target)
    {
        if (_timer <= 0)
        {
            target.ApplyDamage(20);
            _timer = 2f;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
}
