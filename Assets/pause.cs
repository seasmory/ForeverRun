using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour{
	GameObject res,res2;
	bool paused = false;
    // Start is called before the first frame update
    void Start(){
		res = GameObject.Find("RestartButton");
		res2 = GameObject.Find("MainButton");
		res.GetComponent<Renderer>().enabled = false;
		res.GetComponent<Collider2D>().enabled = false;
		res2.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Q))
			paused = togglePause();
    }
	
	public bool togglePause(){
		if(Time.timeScale == 0f){
			Time.timeScale = 1f;
			res.GetComponent<Renderer>().enabled = false;
			res.GetComponent<Collider2D>().enabled = false;
			res2.SetActive(false);
			return(false);
		}
		else{
			Time.timeScale = 0f;
			res.GetComponent<Renderer>().enabled = true;
			res.GetComponent<Collider2D>().enabled = true;
			res2.SetActive(true);
			return(true);
		}
	}
}
