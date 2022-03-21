using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    private NavMeshAgent pathfinder;
    private Transform target;
    
    void Start()
    {
        pathfinder = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Ball").transform;
    }
    void Update()
    {
        pathfinder.SetDestination(target.position);
        Debug.Log(target.position);
    }
}