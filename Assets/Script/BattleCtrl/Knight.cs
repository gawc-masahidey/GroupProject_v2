using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Units
{
    // �R�m

    // ���ʔԍ�
    public int identifyNum = 2;
    public override int GetIdentifyNum()
    {
        return identifyNum;
    }

    // ���
    //public float maxForce = 10000f; // �ő�
    //public float nowForce = 1000f;  // ��

    // �U����
    //public float attackForce = 1.4f;
    // �h���
    //public float defenseForce = 1.2f;

    // ����
    //public int step = 4;

    // �X�L��


    // �A�j���[�V���������p <<
    Animator animator;
    //  >>


    // Start is called before the first frame update
    void Start()
    {
        //�X�e�[�^�X�Z�b�g
        nowForce = MAXFORCE;
        attackForce = 1.0f;
        defenseForce = 1.4f;
        step = 4;


        // �A�j���[�V���������p <<
        this.animator = GetComponent<Animator>();

        //  >>
    }

    // Update is called once per frame
    void Update()
    {
        // �A�j���[�V���������p <<

        // ����
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.animator.SetBool("RunningBool", true);�@// �A�j���[�V�����؂�ւ�

            transform.Translate(Vector3.right * Time.deltaTime); // �ړ�
        }
        else
        {
            this.animator.SetBool("RunningBool", false);

        }
        // �U��
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.animator.SetTrigger("AttackTrigger");�@// �A�j���[�V�����؂�ւ�
        }
        // �U�������
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.animator.SetTrigger("DefenseTrigger");�@// �A�j���[�V�����؂�ւ�
        }
        // ��
        if (Input.GetKey(KeyCode.D))
        {
            this.animator.SetTrigger("DeathTrigger");�@// �A�j���[�V�����؂�ւ�
        }

        //  >>







    }


    public override void Attack()
    {
        Debug.Log("KBattle");
        enableUnit = false;
    }

    public override void Move()
    {
        Debug.Log("KMove");
    }

    public override void Skill()
    {
        Debug.Log("KSkill");
        enableUnit = false;
    }

}
