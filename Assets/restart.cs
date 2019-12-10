using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour{
    private bool isInside;
    // Start is called before the first frame update
    void Start(){
        isInside = false;
    }

    // Update is called once per frame
	
	void OnMouseEnter(){
        Debug.Log("hmm");
        isInside = true;
	}
	
	void OnMouseExit(){
        isInside = false;
	}

    private void OnMouseUp(){
        if (isInside){
			GameObject.Find("Obstacle").GetComponent<Obs>().updateHscore();
			GameObject.Find("GameState").GetComponent<pause>().togglePause();
            SceneManager.LoadScene("Skuer");
        }
    }
	
}
