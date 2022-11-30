using UnityEngine;

public class Movement : MonoBehaviour
{
    float moveX;
    float moveY;
    float speed = 7f;

    void Update()
    {
        Vector3 pos = transform.position;
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        pos += new Vector3(moveX, moveY, 0)*speed*Time.deltaTime; 
        pos.x = Mathf.Clamp(pos.x, -7.5f, 7.5f);
        pos.y = Mathf.Clamp(pos.y, -3.7f, 3.7f);
        transform.position = pos;
    }
    
}
