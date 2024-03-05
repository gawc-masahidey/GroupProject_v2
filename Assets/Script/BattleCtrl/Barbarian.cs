using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Barbarian : Units
{
    // 斧持ちおじいちゃん

    // 識別番号
    public int identifyNum = 1;
    public override int GetIdentifyNum()
    {
        return identifyNum;
    }

    // 戦力
    //public float maxForce = 10000f; // 最大
    //public float nowForce = 1000f;  // 今

    // 攻撃力
    //public float attackForce = 1.5f;
    // 防御力
    //public float defenseForce = 0.8f;

    // 歩数
    //public int step = 6;

    // スキル


    // アニメーション実験用 <<
    Animator animator;
    //  >>



    // Start is called before the first frame update
    void Start()
    {
        //ステータスセット
        nowForce = MAXFORCE;
        attackForce = 1.5f;
        defenseForce = 0.8f;
        step = 6;

        // アニメーション実験用 <<
        this.animator = GetComponent<Animator>();

        //  >>


    }

    // Update is called once per frame
    void Update()
    {
        // アニメーション実験用 <<

        // 走る
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.animator.SetBool("RunningBool", true);　// アニメーション切り替え

            transform.Translate(Vector3.right * Time.deltaTime); // 移動
        }
        else 
        {
            this.animator.SetBool("RunningBool", false);

        }
        // 攻撃
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.animator.SetTrigger("AttackTrigger");　// アニメーション切り替え
        }
        // 攻撃される
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.animator.SetTrigger("DefenseTrigger");　// アニメーション切り替え
        }
        // 死
        if (Input.GetKey(KeyCode.D))
        {
            this.animator.SetTrigger("DeathTrigger");　// アニメーション切り替え
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
