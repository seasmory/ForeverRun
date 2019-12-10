using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour{
    float scrollSpeed = 8f;
    Vector2 startPos;

    void Start(){
        startPos = new Vector2(0, 2.9f);
    }

    void Update(){
        //float newPos = Mathf.Repeat(Time.time * scrollSpeed, 13);
        transform.Translate((new Vector2(-1, 0)) * scrollSpeed * Time.deltaTime);
        if (transform.position.x < -27)
        {
            transform.position = startPos;
        }
    }
}