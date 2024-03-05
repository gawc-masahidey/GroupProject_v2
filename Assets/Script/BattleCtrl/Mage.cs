using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Units
{
    // 魔女

    // 識別番号
    public int identifyNum = 3;
    public override int GetIdentifyNum() 
    {
       return identifyNum;
    }

    // 戦力
    //public  float maxForce = 10000f; // 最大
    //public float nowForce = 1000f;  // 今

    // 攻撃力
    //public float attackForce = 0.8f;
    // 防御力
    //public float defenseForce = 1.0f;

    // 歩数
    //public int step = 3;

    // スキル
    public float attackForce2 = 1.0f; // 2マス目に攻撃
    public float attackForce3 = 1.2f; // 3マス目に攻撃


    // アニメーション実験用 <<
    Animator animator;
    //  >>


    // Start is called before the first frame update
    void Start()
    {
        // アニメーション実験用 <<
        this.animator = GetComponent<Animator>();

        //  >>

    }

    // Update is called once per frame
    void Update()
    {
        //ステータスセット
        nowForce = MAXFORCE;
        attackForce = 0.8f;
        defenseForce = 1.0f;
        step = 3;

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
        // スキル攻撃
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.animator.SetTrigger("Attack2Trigger");　// アニメーション切り替え
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
