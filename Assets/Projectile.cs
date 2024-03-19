using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Projectile : MonoBehaviour
{
    float damageAmount;
    float speed;
    UnityAction OnHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialize(float damage, float velocity, UnityAction onHit)
    {
        damageAmount = damage;
        speed = velocity;
        OnHit += onHit;

        GetComponent<Rigidbody>().velocity = transform.forward * speed;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var target = other.gameObject.GetComponent<Damageable>();
        if (target != null)
        {
            var direction = GetComponent<Rigidbody>().velocity;
            direction.Normalize();

            Debug.Log("hit enemy trigger");
            target.Hit(direction * speed * 0.1f, damageAmount);
            OnHit?.Invoke();
        }

        Destroy(gameObject);
    }
}
