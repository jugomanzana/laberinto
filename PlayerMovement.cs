using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; 9f;
    public float mouseSense; 210f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate((0, 0, -speed * Time.deltaTime));
        }
        {
            
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime, 0);
    }
}