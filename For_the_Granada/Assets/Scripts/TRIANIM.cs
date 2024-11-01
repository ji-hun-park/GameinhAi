using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRIANIM : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetTrigger("ATTACK");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetTrigger("DASH");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetTrigger("JUMP");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            anim.SetTrigger("DAMAGED");
        }
    }
}
