using UnityEngine;
using System.Collections;

public class FighterAnimationDemo : MonoBehaviour {
	
	public Animator anim;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
	

	void Start()
	{
        anim = GetComponent<Animator>();
	}

	void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        if (Input.GetButtonDown("Punch"))
        {
            anim.SetTrigger("Punch");
        }
        if (translation != 0)
        {
            anim.SetBool("WalkForward", true);
            anim.SetBool("Idle", false);
        }
        else
        {
            anim.SetBool("WalkForward", false);
            anim.SetBool("Idle", true);
        }
    }
}