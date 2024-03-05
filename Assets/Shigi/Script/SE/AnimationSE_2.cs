using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSE_2 : MonoBehaviour
{
    // SE
    public AudioClip RunningSE; // ëñÇÈ
    public AudioClip AttackSE; // çUåÇ
    public AudioClip AttackVC; // çUåÇVc
    public AudioClip DefenseVC; // çUåÇÇ≥ÇÍÇÈVc
    public AudioClip DeathVC_1; // éÄ
    public AudioClip DeathVC_2; // éÄ

    AudioSource aud;


    // Start is called before the first frame update
    void Start()
    {
        this.aud = GetComponent<AudioSource>();

    }

    // ëñÇÈSE
    void Running(string RunningSE)
    {
        this.aud.PlayOneShot(this.RunningSE);
    }
    
    // çUåÇ
    void Attack(string AttackSE)
    {
        this.aud.PlayOneShot(this.AttackSE);
    }
    // çUåÇ
    void AttackVc(string AttackVC)
    {
        this.aud.PlayOneShot(this.AttackVC);
    }

    // çUåÇÇ≥ÇÍÇÈ
    void DefenseVc(string DefenseVC)
    {
        this.aud.PlayOneShot(this.DefenseVC);
    }

    // éÄ
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
