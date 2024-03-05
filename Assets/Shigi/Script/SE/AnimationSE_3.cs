using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSE_3 : MonoBehaviour
{
    // SE
    public AudioClip RunningSE; // é
    public AudioClip AttackSE; // U
    public AudioClip AttackVC; // UVc
    public AudioClip SkillsAttackSE_1; // XLU
    public AudioClip SkillsAttackSE_2; // XLU
    public AudioClip SkillsAttackVC; // XLUVc
    public AudioClip DefenseVC; // U³êéVc
    public AudioClip DeathVC_1; // 
    public AudioClip DeathVC_2; // 

    AudioSource aud;


    // Start is called before the first frame update
    void Start()
    {
        this.aud = GetComponent<AudioSource>();

    }

    // éSE
    void Running(string RunningSE)
    {
        this.aud.PlayOneShot(this.RunningSE);
    }
    
    // U
    void Attack(string AttackSE)
    {
        this.aud.PlayOneShot(this.AttackSE);
    }
    // U
    void AttackVc(string AttackVC)
    {
        this.aud.PlayOneShot(this.AttackVC);
    }

    //  XLU
    void SkillsAttack1(string SkillsAttackSE_1)
    {
        this.aud.PlayOneShot(this.SkillsAttackSE_1);
    }
    //  XLU
    void SkillsAttack2(string SkillsAttackSE_2)
    {
        this.aud.PlayOneShot(this.SkillsAttackSE_2);
    }
    // XLU
    void SkillsAttackVc(string SkillsAttackVC)
    {
        this.aud.PlayOneShot(this.SkillsAttackVC);
    }

    // U³êé
    void DefenseVc(string DefenseVC)
    {
        this.aud.PlayOneShot(this.DefenseVC);
    }

    // 
    void DeathVc1(string DeathVC_1)
    {
        this.aud.PlayOneShot(this.DeathVC_1);
    }
    void DeathVc2(string DeathVC_1)
    {
        this.aud.PlayOneShot(this.DeathVC_2);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
