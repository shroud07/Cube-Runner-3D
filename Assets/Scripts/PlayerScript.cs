using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rb;
    public float force = 1000f;
    public float speed = 10f;
    public float maxX;
    public float minX;
    // start is called before the first frame update
    private void Start()
    {

    }

    // update is called once per frame
    private void Update()
    {
        // Movement first
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }

        // Then clamp
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;
    }


    private void FixedUpdate()
    {
        rb.AddForce(0, 0, force*Time.deltaTime);
    }
}
