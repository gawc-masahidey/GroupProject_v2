using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUseBt : MonoBehaviour
{
    //DDown
    [SerializeField] GameObject DD;
    DropdownManager ddManag;

    [SerializeField] GameObject BattleBt;
    [SerializeField] GameObject MoveBt;
    [SerializeField] GameObject SkillBt;
    //[SerializeField] GameObject TacBt;
    //[SerializeField] GameObject TicBt;

    // �O���X�N���v�g����������擾���邽�߂̎Q��
    Units unit;
    

    // Start is called before the first frame update
    void Start()
    {
        ddManag = DD.GetComponent<DropdownManager>();
        ddManag.OnUnitsSelected += UpdateBtState;
        // �{�^���̎g�p�ۂ��X�V
        UpdateButtonAvailability();
    }

    // �����Ɋ�Â��ă{�^���̎g�p�ۂ��X�V���郁�\�b�h
    void UpdateButtonAvailability()
    {
        // �������擾���ă{�^���̎g�p�ۂ𔻒f
        bool canUseBattleButton = unit.enableAttack;
        bool canUseMoveButton = unit.enableMove;
        bool canUseSkillButton = unit.enableSkill;

        // �{�^���̎g�p�ۂ�ݒ�
        BattleBt.SetActive(canUseBattleButton);
        MoveBt.SetActive(canUseMoveButton);
        SkillBt.SetActive(canUseSkillButton);
        
    }

    void UpdateBtState(Units SelctedUnit) 
    {
        unit = SelctedUnit;
        UpdateButtonAvailability();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

