using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakPlatform : MonoBehaviour
{

    private Animator BreakPlat;
    [SerializeField] private AnimationClip anim_break;
    [SerializeField] private Transform Hero;
    

    void Start()
    {
        BreakPlat = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.y+0.5f < Hero.position.y)
        {
            BreakPlat.Play(anim_break.name);
            Destroy(gameObject, 0.3f);
        }
    }


}
