using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent navenemy;
    bool follow;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        navenemy = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        follow = true;
        position = other.transform.position;
        var health = GetComponent<Health>();
        if (health != null)
        {
            health.Damage(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            navenemy.SetDestination(position);

        }
    }
}
