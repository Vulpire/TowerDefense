﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public int health;
    public float speed;
	
	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}
}
