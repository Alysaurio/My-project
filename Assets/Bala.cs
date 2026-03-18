using UnityEngine;

public class Bala : MonoBehaviour
{
    public int daño = 10;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
