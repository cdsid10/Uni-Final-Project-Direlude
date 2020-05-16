﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTarget : MonoBehaviour
{
    public Animator anim;
    public GameObject sLight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullets")
        {
            anim.SetTrigger("pressed");
            yield return new WaitForSeconds(1);
            sLight.SetActive(true);
        }
    }
}
