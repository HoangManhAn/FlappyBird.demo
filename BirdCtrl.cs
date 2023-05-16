using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCtrl : MonoBehaviour
{
    [SerializeField] private float upForce = 200f;

    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
   
    protected void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //GameCtrl.Instance.GameStart();
    }

    protected void Update()
    {
        this.BirdMove();
    }

    

    public void BirdMove()
    {
        if (isDead == false)
        {
            if (InputManager.Instance.GetMouse())
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
                AudioCtrl.Instance.FlapAudio();
                Debug.Log("BirdFlap");
            }
        }
    }

    protected void OnCollisionEnter2D()
    {
        isDead = true;
        anim.SetTrigger("Die");
        GameCtrl.Instance.BirdDied();
        AudioCtrl.Instance.DieAudio();
        Debug.Log("BirdDie");
    }



}
