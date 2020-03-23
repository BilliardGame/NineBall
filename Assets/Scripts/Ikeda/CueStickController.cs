using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueStickController : MonoBehaviour {

    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = transform.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("Pull", true);
        }
        if (Input.GetKeyUp("space"))
        {
            animator.SetBool("Pull", false);
            animator.SetBool("Shot", true);
        }
	}
}
