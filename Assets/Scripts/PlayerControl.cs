using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject enemy; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (enemy != null)
                enemy.GetComponent<EnemyColorChange>().ChangeColor();
        }
    }
}
