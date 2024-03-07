using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITileBtManag : MonoBehaviour
{
    [SerializeField] GameObject DD;
    DropdownManager ddManag;

    [SerializeField] GameObject GameDire;
    GridMap gmap;

    public GameObject AttackBtPrefab;
    public GameObject MoveBtPrefab;
    public GameObject SkillBtPrefab;
    public Transform panel;

    //public event Action<Units> OnPushAttackBt;
    //public event Action<Units> OnPushSkillBt;
    /*
    // Start is called before the first frame update
    void Start()
    {
        ddManag = DD.GetComponent<DropdownManager>();
        ddManag.OnUnitsSelected += PlaceMoveButtons;
        ddManag.OnUnitsSelected += PlaceAttackButtons;
        ddManag.OnUnitsSelected += PlaceSkillButtons;

        gmap = GameDire.GetComponent<GridMap>();
    }*/
    /*
    // �A�^�b�N�{�^���̔z�u
    public void PlaceAttackButtons(Units unit)
    {
        // ���j�b�g����A�^�b�N�����W���X�g���擾
        List<Vector2> attackRange = unit.attackRange;

        // �A�^�b�N�����W���X�g���̈ʒu�ɍU���\�ȃ{�^����z�u
        foreach (Vector2 position in attackRange)
        {
            // �m�[�h���O���b�h�͈͓̔��ɂ��邩�m�F
            if (gmap.CheckBoundary((int)position.x, (int)position.y))
            {
                // �U���\�Ȉʒu�ɑΉ����郏�[���h���W���擾
                Vector3 worldPosition = gmap.GetWorldPosition((int)position.x, (int)position.y);

                // �U���\�ȃ{�^���𐶐����Ĕz�u
                GameObject button = Instantiate(AttackBtPrefab, panel);
                button.transform.position = worldPosition;

                
            }
        }
    }*/
    /*
    // �X�L���{�^���̔z�u
    public void PlaceSkillButtons(Units unit)
    {
        // ���j�b�g����X�L�������W���X�g���擾
        List<Vector2> skillRange = unit.skillRange;

        //�X�L�������W�������̏ꍇ
        if (IsSkillRangeSameAsAttackRange(unit))
        {
            //�A�^�b�N�{�^���������ꂽ����OnSkillButtonClick(Units unit)���Ăяo��
        }

        // �X�L�������W�ƃA�^�b�N�����W�������łȂ��ꍇ�̂ݔz�u
        if (!IsSkillRangeSameAsAttackRange(unit))
        {
            // �X�L�������W���X�g���̈ʒu�ɃX�L���{�^����z�u
            foreach (Vector2 position in skillRange)
            {
                int x = (int)position.x;
                int y = (int)position.y;

                // �m�[�h���O���b�h�͈͓̔��ɂ��邩�m�F
                if (gmap.CheckBoundary(x, y))
                {

                    // �X�L���\�Ȉʒu�ɑΉ����郏�[���h���W���擾
                    Vector3 worldPosition = gmap.GetWorldPosition(x, y);

                    // �X�L���{�^���𐶐����Ĕz�u
                    GameObject button = Instantiate(SkillBtPrefab, panel);
                    button.transform.position = worldPosition;

                    // �{�^���ɃX�L���̏�����ǉ�����Ȃǂ̏������s��
                    

                }
            }
        }
    }
    /*
    // �X�L�������W���A�^�b�N�����W�Ɠ������ǂ����𔻒肷�郁�\�b�h
    private bool IsSkillRangeSameAsAttackRange(Units unit)
    {
        List<Vector2> skillRange = unit.skillRange;
        List<Vector2> attackRange = unit.attackRange;

        // �X�L�������W�ƃA�^�b�N�����W�������ł��邩�ǂ����𔻒�
        return skillRange.Count == attackRange.Count && new HashSet<Vector2>(skillRange).SetEquals(attackRange);
    }
    *//*
    // �ړ��{�^���̔z�u
    public void PlaceMoveButtons(Units unit)
    {
        // ���j�b�g����ړ��\�͈͂��擾
        List<Vector2> moveRange = unit.moveRange;

        // �ړ��͈͓��̈ʒu�Ɉړ��\�ȃ{�^����z�u
        foreach (Vector2 position in moveRange)
        {
            int x = (int)position.x;
            int y = (int)position.y;

            // �m�[�h���O���b�h�͈͓̔��ɂ��邩�m�F
            if (gmap.CheckBoundary(x, y))
            {
                // �m�[�h���ʍs�\���ǂ������m�F
                if (gmap.grid[x, y].passable)
                {
                    // �ړ��\�ȏꍇ�́A���̈ʒu�Ɉړ��{�^����z�u
                    Vector3 worldPosition = gmap.GetWorldPosition(x, y);
                    GameObject button = Instantiate(MoveBtPrefab, panel);
                    button.transform.position = worldPosition;
                }
            }
        }
    }*/
    /*
    // �U���̏���
    // �U���̏���
    private void OnAttackButtonClick(Units unit)
    {
        // �{�^�����N���b�N���ꂽ�Ƃ��̍U���������L�q
        // �{�^���̃m�[�h�����擾���A���̃m�[�h���Units�����邩����
        // ����Ȃ�A�C�x���g�𔭐������A���̃m�[�h���Units���擾����

        // �{�^�����z�u���ꂽ�m�[�h�̈ʒu���擾
        Vector2 buttonPosition = GetAttackButtonPosition(unit);

        // �m�[�h���Units�����݂��邩�`�F�b�N
        if (IsUnitOnNode(buttonPosition))
        {
            // �m�[�h���Units���擾
            Units unitsOnNode = GetUnitsOnNode(buttonPosition);

            // OnAttackButtonClick�C�x���g�𔭉΂��AUnits��n��
            if (unitsOnNode != null)
            {
                // �m�[�h���Units�����݂���ꍇ�A�C�x���g�𔭐�
                OnPushAttackBt?.Invoke(unitsOnNode);
}
        }
    }*/
    /*
    // �{�^�����z�u���ꂽ�m�[�h�̈ʒu���擾���郁�\�b�h
    private Vector2 GetAttackButtonPosition(Units unit)
    {
        // ���j�b�g����U�������W���X�g���擾
        List<Vector2> attackRange = unit.attackRange;

        // �{�^�����z�u���ꂽ�ʒu���擾����
        foreach (Vector2 position in attackRange)
        {
            if (gmap.CheckBoundary((int)position.x, (int)position.y))
            {
                // �{�^���̈ʒu��Ԃ�
                return position;
            }
        }

        // �{�^�����z�u����Ă��Ȃ��ꍇ�́A�f�t�H���g�̈ʒu��Ԃ�
        return Vector2.zero;
    }*/

    // �m�[�h���Units�����݂��邩�ǂ������`�F�b�N���郁�\�b�h
    private bool IsUnitOnNode(Vector2 position)
    {
        // �m�[�h���Units�����݂��邩���`�F�b�N
        // �����ŕK�v�ɉ����ăm�[�h�̏�Ԃ��m�F���Ă�������
        // �Ⴆ�΁Agmap.grid[(int)position.x, (int)position.y]����łȂ����Ƃ��m�F����Ȃ�
        return true; // ���̕Ԃ�l�A���ۂ̏����ɍ��킹�ďC�����Ă�������
    }

    /*// �m�[�h���Units���擾���郁�\�b�h
    private Units GetUnitsOnNode(Vector2 position)
    {
        // �m�[�h���Units���擾���鏈��
        // �Ⴆ�΁Agmap.grid[(int)position.x, (int)position.y]����Units���擾����Ȃ� 
        //} else {return null;} // ���̕Ԃ�l�A���ۂ̏����ɍ��킹�ďC�����Ă�������
    }
    /*
    // �X�L���̏���
    private void OnSkillButtonClick(Units unit)
    {
        // �{�^�����N���b�N���ꂽ�Ƃ��̃X�L���������L�q
        // �{�^���̃m�[�h�����擾���A���̃m�[�h���Units�����邩����
        // ����Ȃ�A�C�x���g�𔭐������A���̃m�[�h���Units���擾����

        // �{�^�����z�u���ꂽ�m�[�h�̈ʒu���擾
        Vector2 buttonPosition = GetSkillButtonPosition(unit);

        // �m�[�h���Units�����݂��邩�`�F�b�N
        if (IsUnitOnNode(buttonPosition))
        {
            // �m�[�h���Units���擾
            Units unitsOnNode = GetUnitsOnNode(buttonPosition);

            // OnSkillButtonClick�C�x���g�𔭉΂��AUnits��n��
            if (unitsOnNode != null)
            {
                // �m�[�h���Units�����݂���ꍇ�A�C�x���g�𔭐�
                
                OnPushSkillBt?.Invoke(unitsOnNode);
}
        }
    }
    */
    /*
    private Vector2 GetSkillButtonPosition(Units unit)
    {
        // ���j�b�g����U�������W���X�g���擾
        List<Vector2> attackRange = unit.skillRange;

        // �{�^�����z�u���ꂽ�ʒu���擾����
        foreach (Vector2 position in attackRange)
        {
            if (gmap.CheckBoundary((int)position.x, (int)position.y))
            {
                // �{�^���̈ʒu��Ԃ�
                return position;
            }
        }



    }*/
}
