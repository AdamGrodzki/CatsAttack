using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 direction;
    float speed = 5.0f;
    void Start()
    {
        shootDirection();
        Destroy(gameObject, 1.5f);
    }
    void Update()
    {
        transform.position += direction.normalized *speed*Time.deltaTime;
    }
    void shootDirection()
    {
        Vector3 cursorPosition = Input.mousePosition;
        cursorPosition = Camera.main.ScreenToWorldPoint(cursorPosition);
        cursorPosition.z = 0;
        direction = cursorPosition - transform.position;  
    }
    
}
