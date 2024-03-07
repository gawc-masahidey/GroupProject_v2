using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Units : MonoBehaviour
{

    
    // ���
    public const float MAXFORCE = 10000f;
    public float nowForce { get; set; }

    // �U����
    public float attackForce { get; set; }
    // �h���
    public float defenseForce { get; set; }

    // ����
    public int step { get; set; }
    public bool enableAttack { get; set; }
    public bool enableMove { get; set; }
    public bool enableSkill { get; set; }

    public bool enableUnit { get; set; }

    public Vector2Int NowPos { get; set; }

    public event Action EndUnit;//���j�b�g�̃^�[�����G���h�����Ƃ��ɌĂяo���C�x���g

    // �X�L��

    private void Start()
    {
        
    }

    public void CheckTileInfo() 
    {
        //�^�C���C���t�H��������čs���\���ǂ������`�F�b�N����
        //�A�C�f���e�B�e�B�i���o�[���g�p���āA�ǂ̕��킩���f����
        //�U���A�ړ��A�X�L���̎d�l���\�ł���΃{�^����������悤�ɂȂ�
        
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
