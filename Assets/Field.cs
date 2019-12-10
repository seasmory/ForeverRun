using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour{
    float scrollSpeed = 8f;
    Vector2 startPos;

    void Start(){
        startPos = new Vector2(-8.5f, -0.3f);
    }

    void Update(){
        //float newPos = Mathf.Repeat(Time.time * scrollSpeed, 13);
        transform.Translate((new Vector2(-1, 0)) * scrollSpeed * Time.deltaTime);
        if (transform.position.x < -28.8f)
        {
            transform.position = startPos;
        }
    }
}