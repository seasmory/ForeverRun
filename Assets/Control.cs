using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    public Animator animator;
    public float power;
	private Rigidbody2D rb2D;
	private BoxCollider2D Col,Col2;
	Vector2 initSize,initSize2,initOff,initOff2;
	bool touchField=false;
	bool slide=false;
	
	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
		Col = GetComponent<BoxCollider2D>();
		Col2 = this.gameObject.transform.GetChild(0).GetComponent<BoxCollider2D>();
		initSize = Col.size;
		initOff = Col.offset;
		initSize2 = Col2.size;
		initOff2 = Col2.offset;
	}
	
	void Update(){
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector2 jump = new Vector2 (0, power);
		if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && touchField && !slide){
			rb2D.AddForce(jump, ForceMode2D.Impulse);
			touchField=false;
            animator.SetBool("Jump", true);
		}
		if(Input.GetKey(KeyCode.DownArrow) && touchField){
			animator.SetBool("Slide", true);
			Col.size = new Vector2(2.4f,1.3f);
			Col.offset = new Vector2(-0.09957877f, -0.6f);
			Col2.size = new Vector2(2.4f,1.3f);
			Col2.offset = new Vector2(-0.09957877f, -0.6f);
		}
		else{
			animator.SetBool("Slide", false);
			Col.size = initSize;
			Col.offset = initOff;
			Col2.size = initSize2;
			Col2.offset = initOff2;
		}
		Debug.Log(Col.size.x);
	}
	
	void OnTriggerStay2D(Collider2D other){
        if (other.tag == "Ground") {
            touchField = true;
            animator.SetBool("Jump", false);
        }
	}
	
}
