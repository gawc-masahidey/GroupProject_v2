using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Units : MonoBehaviour
{

    
    // 戦力
    public const float MAXFORCE = 10000f;
    public float nowForce { get; set; }

    // 攻撃力
    public float attackForce { get; set; }
    // 防御力
    public float defenseForce { get; set; }

    // 歩数
    public int step { get; set; }
    public bool enableAttack { get; set; }
    public bool enableMove { get; set; }
    public bool enableSkill { get; set; }

    public bool enableUnit { get; set; }

    public Vector2Int NowPos { get; set; }

    public event Action EndUnit;//ユニットのターンがエンドしたときに呼び出すイベント

    // スキル

    private void Start()
    {
        
    }

    public void CheckTileInfo() 
    {
        //タイルインフォをもらって行動可能かどうかをチェックする
        //アイデンティティナンバーを使用して、どの兵種か判断する
        //攻撃、移動、スキルの仕様が可能であればボタンが押せるようになる
        
    }

    public abstract void Attack();

    public abstract void Move();

    public abstract void Skill();

    public void unitTurnEnd()
    {
        this.enableUnit = false;
        EndUnit?.Invoke();
    }
    public void unitTurnStart() 
    {
        this.enableUnit = true;
    }

    public abstract int GetIdentifyNum();

    public void BattleCalc(Units unit) 
    {
        float teki = unit.nowForce;
        float mikata = this.nowForce * this.attackForce;
        float damage;
        if (mikata - teki >= 0)
        {
            damage = (mikata - teki) * (2.0f - unit.defenseForce);
        }
        else 
        {
            damage = 100;
        }

        unit.nowForce = unit.nowForce - damage;
    }

    public void SetNowPos(GridObject gObj)
    {
        this.NowPos = gObj.positionOnGrid;
        Debug.Log(NowPos);
    }


    public void HealToFull()
    {
        nowForce = MAXFORCE;
    }


}
