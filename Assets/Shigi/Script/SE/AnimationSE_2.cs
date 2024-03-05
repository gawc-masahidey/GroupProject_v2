using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSE_2 : MonoBehaviour
{
    // SE
    public AudioClip RunningSE; // ����
    public AudioClip AttackSE; // �U��
    public AudioClip AttackVC; // �U��Vc
    public AudioClip DefenseVC; // �U�������Vc
    public AudioClip DeathVC_1; // ��
    public AudioClip DeathVC_2; // ��

    AudioSource aud;


    // Start is called before the first frame update
    void Start()
    {
        this.aud = GetComponent<AudioSource>();

    }

    // ����SE
    void Running(string RunningSE)
    {
        this.aud.PlayOneShot(this.RunningSE);
    }
    
    // �U��
    void Attack(string AttackSE)
    {
        this.aud.PlayOneShot(this.AttackSE);
    }
    // �U��
    void AttackVc(string AttackVC)
    {
        this.aud.PlayOneShot(this.AttackVC);
    }

    // �U�������
    void DefenseVc(string DefenseVC)
    {
        this.aud.PlayOneShot(this.DefenseVC);
    }

    // ��
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
