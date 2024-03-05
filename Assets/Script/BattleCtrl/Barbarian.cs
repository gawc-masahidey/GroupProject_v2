using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Barbarian : Units
{
    // �����������������

    // ���ʔԍ�
    public int identifyNum = 1;
    public override int GetIdentifyNum()
    {
        return identifyNum;
    }

    // ���
    //public float maxForce = 10000f; // �ő�
    //public float nowForce = 1000f;  // ��

    // �U����
    //public float attackForce = 1.5f;
    // �h���
    //public float defenseForce = 0.8f;

    // ����
    //public int step = 6;

    // �X�L��


    // �A�j���[�V���������p <<
    Animator animator;
    //  >>



    // Start is called before the first frame update
    void Start()
    {
        //�X�e�[�^�X�Z�b�g
        nowForce = MAXFORCE;
        attackForce = 1.5f;
        defenseForce = 0.8f;
        step = 6;

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
        Debug.Log("BBattle");
        enableUnit = false;
    }

    public override void Move()
    {
        Debug.Log("BMove");
    }

    public override void Skill()
    {
        Debug.Log("BSkill");
        enableUnit = false;
    }

}
