using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obs : MonoBehaviour {
	public Text counter;
	public Text Hcounter;
	private Rigidbody2D rb2D;
	private Vector2 velocity;
	private Sprite mySprite;
	private System.Random rnd = new System.Random();
	private int count;
	private int Hcount;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
		velocity = new Vector2 (-10, 0);
		count = 0;
		updateCounter();
		Hcount = GameObject.Find("HighScoreKeeper").GetComponent<HighScore>().getHscore();
		Hcounter.text = "High Score: " + Hcount.ToString();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb2D.MovePosition(rb2D.position+velocity*Time.fixedDeltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			updateHscore();
			GameObject.Find("GameState").GetComponent<pause>().togglePause();
			rb2D.position=new Vector2 (13,rnd.Next(0,3));
			velocity = new Vector2(-10,0);
		}
		if (other.tag == "Stopper") {
			float height = rnd.Next(0,40);
			height /= 20;
			rb2D.position=new Vector2 (13,height);
			velocity = velocity + new Vector2(-0.5f,0);
			count++;
			updateCounter();
		}
		if(count>Hcount) updateHcounter();
	}
	
	void updateHcounter(){
		Hcount = count;
		Hcounter.text = "High Score: " + Hcount.ToString();
	}
	
	void updateCounter(){
		counter.text = "Score: " + count.ToString();
	}
	
	public void updateHscore(){
		GameObject.Find("HighScoreKeeper").GetComponent<HighScore>().updateHscore(Hcount);
	}
}
