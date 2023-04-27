using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int hp;

    public void Damage(int damage)
    {
        hp -= damage;
        Debug.Log("“G‚ÌHP" + hp);
    }

    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
