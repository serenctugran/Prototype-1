using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float enemySpeed = 25.0f;
    
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemySpeed);
    }
}
