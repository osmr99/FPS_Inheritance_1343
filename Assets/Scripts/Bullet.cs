using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] float damageAmount;
    [SerializeField] float knockbackForce;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
        GetComponent<Rigidbody>().velocity = transform.forward * 150;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var target = other.gameObject.GetComponent<Damageable>();
        if (target != null)
        {
            var direction = GetComponent<Rigidbody>().velocity;
            direction.Normalize();

            Debug.Log("hit enemy trigger");
            target.Hit(direction * knockbackForce, damageAmount);
        }

        Destroy(gameObject);
    }
}
