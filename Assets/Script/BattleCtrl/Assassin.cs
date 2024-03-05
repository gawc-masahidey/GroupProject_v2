using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Assassin : Units
{
    // �A�T�V��

    // ���ʔԍ�
    public int identifyNum = 4;
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
    public float attackForce2 = 1.0f; // 1��ڂɍU���@1.0�ȏ�1.6�ȉ� Random.Range(1.0f, 1.6f)
    public float attackForce3 = 1.0f; // 2��ڂɍU���@0.8�ȏ�1.3�ȉ� Random.Range(0.8f, 1.3f)

    //int attackRandom = 0; // 2��U������p�@�P���Q Random.Range(1, 3)


    // �A�j���[�V���������p <<
    Animator animator;
    public GameObject Knife;
    public GameObject Knife2;
    //  >>


    // Start is called before the first frame update
    void Start()
    {
        //�X�e�[�^�X�Z�b�g
        nowForce = MAXFORCE;
        attackForce = 1.0f;
        defenseForce = 1.0f;
        step = 4;

        // �A�j���[�V���������p <<
        this.animator = GetComponent<Animator>();


        //  >>

    }

    // Update is called once per frame
    void Update()
    {
        // �A�j���[�V���������p <<
        Knife.SetActive(true);
        Knife2.SetActive(false);


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
            //attackForce2 = Random.Range(1.0f, 1.6f); // 1��ڂɍU���@1.0�ȏ�1.6�ȉ�
            //Debug.Log(attackForce2);

            //attackForce3 = Random.Range(0.8f, 1.3f); // 2��ڂɍU���@0.8�ȏ�1.3�ȉ�
            //Debug.Log(attackForce3);

            this.animator.SetTrigger("Attack2Trigger"); // �A�j���[�V�����؂�ւ�

        }
        //�Q�[���I�u�W�F�N�g�\��/��\�� (������|�Ɏ����ւ���) <<
        Animator animator = GetComponent<Animator>();
        var clipInfo = animator.GetCurrentAnimatorClipInfo(0)[0];
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0); //layerNo:Base Layer == 0 

        // ����̃A�j���[�V�����N���b�v�̖��O���w��
        string targetClipName = "Spellcast_Raise";
        if (stateInfo.IsName(targetClipName) && stateInfo.normalizedTime < 1.0f)
        {
            // �Đ����B
            Knife2.SetActive(true);
            Knife2.transform.Rotate(new Vector3(0, 0, -30));
            Knife.SetActive(false);

        }
        // >>

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
        Debug.Log("aBattle");
        enableUnit = false;
    }

    public override void Move()
    {
        Debug.Log("aMove");
    }

    public override void Skill()
    {
        Debug.Log("aSkill");
        enableUnit = false;
    }

}
