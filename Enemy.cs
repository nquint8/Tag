using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    public GameObject Player;
    private NavMeshAgent Enemy;

  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(Player.transform.position);
    }
}
