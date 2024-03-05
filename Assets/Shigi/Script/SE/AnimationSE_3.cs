using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSE_3 : MonoBehaviour
{
    // SE
    public AudioClip RunningSE; // ‘–‚é
    public AudioClip AttackSE; // UŒ‚
    public AudioClip AttackVC; // UŒ‚Vc
    public AudioClip SkillsAttackSE_1; // ƒXƒLƒ‹UŒ‚
    public AudioClip SkillsAttackSE_2; // ƒXƒLƒ‹UŒ‚
    public AudioClip SkillsAttackVC; // ƒXƒLƒ‹UŒ‚Vc
    public AudioClip DefenseVC; // UŒ‚‚³‚ê‚éVc
    public AudioClip DeathVC_1; // €
    public AudioClip DeathVC_2; // €

    AudioSource aud;


    // Start is called before the first frame update
    void Start()
    {
        this.aud = GetComponent<AudioSource>();

    }

    // ‘–‚éSE
    void Running(string RunningSE)
    {
        this.aud.PlayOneShot(this.RunningSE);
    }
    
    // UŒ‚
    void Attack(string AttackSE)
    {
        this.aud.PlayOneShot(this.AttackSE);
    }
    // UŒ‚
    void AttackVc(string AttackVC)
    {
        this.aud.PlayOneShot(this.AttackVC);
    }

    //  ƒXƒLƒ‹UŒ‚
    void SkillsAttack1(string SkillsAttackSE_1)
    {
        this.aud.PlayOneShot(this.SkillsAttackSE_1);
    }
    //  ƒXƒLƒ‹UŒ‚
    void SkillsAttack2(string SkillsAttackSE_2)
    {
        this.aud.PlayOneShot(this.SkillsAttackSE_2);
    }
    // ƒXƒLƒ‹UŒ‚
    void SkillsAttackVc(string SkillsAttackVC)
    {
        this.aud.PlayOneShot(this.SkillsAttackVC);
    }

    // UŒ‚‚³‚ê‚é
    void DefenseVc(string DefenseVC)
    {
        this.aud.PlayOneShot(this.DefenseVC);
    }

    // €
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
