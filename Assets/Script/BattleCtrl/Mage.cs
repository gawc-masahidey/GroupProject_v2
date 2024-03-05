using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Units
{
    // ����

    // ���ʔԍ�
    public int identifyNum = 3;
    public override int GetIdentifyNum() 
    {
       return identifyNum;
    }

    // ���
    //public  float maxForce = 10000f; // �ő�
    //public float nowForce = 1000f;  // ��

    // �U����
    //public float attackForce = 0.8f;
    // �h���
    //public float defenseForce = 1.0f;

    // ����
    //public int step = 3;

    // �X�L��
    public float attackForce2 = 1.0f; // 2�}�X�ڂɍU��
    public float attackForce3 = 1.2f; // 3�}�X�ڂɍU��


    // �A�j���[�V���������p <<
    Animator animator;
    //  >>


    // Start is called before the first frame update
    void Start()
    {
        // �A�j���[�V���������p <<
        this.animator = GetComponent<Animator>();

        //  >>

    }

    // Update is called once per frame
    void Update()
    {
        //�X�e�[�^�X�Z�b�g
        nowForce = MAXFORCE;
        attackForce = 0.8f;
        defenseForce = 1.0f;
        step = 3;

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
        // �X�L���U��
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.animator.SetTrigger("Attack2Trigger");�@// �A�j���[�V�����؂�ւ�
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
        Debug.Log("MBattle");
        enableUnit = false;
    }

    public override void Move()
    {
        Debug.Log("MMove");
    }

    public override void Skill()
    {
        Debug.Log("MSkill");
        enableUnit = false;
    }


}
