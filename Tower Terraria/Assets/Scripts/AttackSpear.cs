using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpear : MonoBehaviour {

    private float timeBtwAttack;
    public float startTimeBtwAttacks;
    public float Persist;
    public int damage;

    public Transform attackPos;
    public float attackRangeX;
    public float attackRangeY;
    public LayerMask WhatIsEnemies;
	
	void Update () {

        if (timeBtwAttack >=0)
        {
           timeBtwAttack -= Time.deltaTime;
        }

            if (Input.GetMouseButtonDown(0))
            {
                if (timeBtwAttack <= 0)
                {
                Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos.position, new Vector2(attackRangeX, attackRangeY), 0, WhatIsEnemies);
                for (int i = 0; i < Persist; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyBehavior>().health -= damage;
                    Debug.Log("damage Taken");
                }
                timeBtwAttack = startTimeBtwAttacks;
            }
                
            }
        }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(attackPos.position, new Vector3(attackRangeX, attackRangeY, 1));
    }
}
