using UnityEngine;
using System.Collections;

public class FighterAnimationDemo : MonoBehaviour {
	
	public Animator anim;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    public float moveSpeed = 10f;
    private Rigidbody rbody;
	

	void Start()
	{
        rbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}

	void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float moveX = inputX*moveSpeed*Time.deltaTime;
        float moveZ = inputZ*moveSpeed*Time.deltaTime;
        rbody.AddForce(moveX, 0f, moveZ);
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        rbody.AddForce(moveX, 0f, moveZ);
        if (Input.GetKeyDown("e"))
        {
            anim.Play("Punch", -1, 0f);
        }
        if (translation > 0)
        {
            anim.SetBool("WalkForward", true);
            anim.SetBool("WalkBackward", false);
            anim.SetBool("Idle", false);
        }
        else if (translation < 0)
        {
            anim.SetBool("WalkForward", false);
            anim.SetBool("WalkBackward", true);
            anim.SetBool("Idle", false);
        }
        else 
        {
            anim.SetBool("WalkForward", false);
            anim.SetBool("WalkBackward", false);
            anim.SetBool("Idle", true);
        }
    }
}