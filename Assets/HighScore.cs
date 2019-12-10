using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour{
	private int Hscore;
	
    // Start is called before the first frame update
    void Start(){
		DontDestroyOnLoad(this.gameObject);
		Hscore = 0;
    }

    // Update is called once per frame
    void Update(){
        
    }
	
	public void updateHscore(int newHscore){
		Hscore = newHscore;
	}
	
	public int getHscore(){
		return Hscore;
	}
	
}
