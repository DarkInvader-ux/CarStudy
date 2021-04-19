using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControl : MonoBehaviour
{
    public float LookRadius = 10.0f;
    Transform target;
    //NavMeshAgent agent;
    private Vector3 direction;
    private Rigidbody _rigidbody;
    public float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        //agent = GetComponent<NavMeshAgent>();
        target = PlayerManager.instance.Player.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = target.transform.position - transform.position; 
        float distance = Vector3.Distance(target.position, transform.position);
        
        if (distance <= LookRadius)
        {
            _rigidbody.AddForce(direction * Time.deltaTime * speed);
            transform.LookAt(direction);
            //agent.SetDestination(target.position);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}