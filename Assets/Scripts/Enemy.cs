using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody Rigidbody { get; private set; }
    Vector3 origin;
    [SerializeField] GameObject damageNumberPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (transform.position.y < 10)
            Respawn();*/
    }

    public void TakeDamage(float amount)
    {
        var damageNumber = Instantiate(damageNumberPrefab, transform.position, Quaternion.identity) ;
        damageNumber.GetComponent<DamageNumber>().SetNumber(amount);
    }

    public void ApplyKnockback(Vector3 knockback)
    {

    }

    public void Respawn()
    {
        transform.position = origin;
    }
}
