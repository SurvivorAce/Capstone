using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoAnim : MonoBehaviour {

    public Animator anim;
    
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	void Update () {
        anim.SetBool("Idle", true);
    }
}
