using UnityEngine;
public class Player : MonoBehaviour
{
    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 currentPosition = transform.position;
        Vector3 newPosition = new Vector3(currentPosition.x + inputX, currentPosition.y + inputY);
        transform.position = newPosition;
    }
}
