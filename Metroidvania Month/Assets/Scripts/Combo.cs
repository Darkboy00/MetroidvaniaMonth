using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour
{
    public Animator ani;
    public int combo;
    public bool attackcombo;
    public AudioSource audio;
    public AudioClip[] sound;
    void Start()
    {
        ani = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }
    public void Start_Combo()
    {
        attackcombo = false;
        if(combo < 2)
        {
            combo++;
        }
    }
    public void Finish_Ani()
    {
        attackcombo = false;
        combo = 0;
    }
    public void ComboSys()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && !attackcombo)
        {
            attackcombo = true;
            ani.SetTrigger("" + combo);
            audio.clip = sound[combo];
            audio.Play();
        }
    }
    void Update()
    {
        ComboSys();
    }
}