using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int enemyhp = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            if (collision.gameObject.GetComponent<Bala>() != null)
            {
                enemyhp -= collision.gameObject.GetComponent<Bala>().daño;
            }
            if (enemyhp <= 0)
            {
                print("enemigo destruido");
                Destroy(gameObject);
            }
        }
    }
}
