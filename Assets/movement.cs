using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float horizontal;
    public float vertical;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical"); 

        transform.position += new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;  
    }
}
