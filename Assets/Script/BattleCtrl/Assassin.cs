using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Assassin : Units
{
    // アサシン

    // 識別番号
    public int identifyNum = 4;
    public override int GetIdentifyNum()
    {
        return identifyNum;
    }

    // 戦力
    //public float maxForce = 10000f; // 最大
    //public float nowForce = 1000f;  // 今

    // 攻撃力
    //public float attackForce = 1.4f;
    // 防御力
    //public float defenseForce = 1.2f;

    // 歩数
    //public int step = 4;

    // スキル
    public float attackForce2 = 1.0f; // 1回目に攻撃　1.0以上1.6以下 Random.Range(1.0f, 1.6f)
    public float attackForce3 = 1.0f; // 2回目に攻撃　0.8以上1.3以下 Random.Range(0.8f, 1.3f)

    //int attackRandom = 0; // 2回攻撃判定用　１か２ Random.Range(1, 3)


    // アニメーション実験用 <<
    Animator animator;
    public GameObject Knife;
    public GameObject Knife2;
    //  >>


    // Start is called before the first frame update
    void Start()
    {
        //ステータスセット
        nowForce = MAXFORCE;
        attackForce = 1.0f;
        defenseForce = 1.0f;
        step = 4;

        // アニメーション実験用 <<
        this.animator = GetComponent<Animator>();


        //  >>

    }

    // Update is called once per frame
    void Update()
    {
        // アニメーション実験用 <<
        Knife.SetActive(true);
        Knife2.SetActive(false);


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
            //attackForce2 = Random.Range(1.0f, 1.6f); // 1回目に攻撃　1.0以上1.6以下
            //Debug.Log(attackForce2);

            //attackForce3 = Random.Range(0.8f, 1.3f); // 2回目に攻撃　0.8以上1.3以下
            //Debug.Log(attackForce3);

            this.animator.SetTrigger("Attack2Trigger"); // アニメーション切り替え

        }
        //ゲームオブジェクト表示/非表示 (剣から弓に持ち替える) <<
        Animator animator = GetComponent<Animator>();
        var clipInfo = animator.GetCurrentAnimatorClipInfo(0)[0];
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0); //layerNo:Base Layer == 0 

        // 特定のアニメーションクリップの名前を指定
        string targetClipName = "Spellcast_Raise";
        if (stateInfo.IsName(targetClipName) && stateInfo.normalizedTime < 1.0f)
        {
            // 再生中。
            Knife2.SetActive(true);
            Knife2.transform.Rotate(new Vector3(0, 0, -30));
            Knife.SetActive(false);

        }
        // >>

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
