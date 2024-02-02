using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class Navigation : MonoBehaviour {
    [SerializeField] private Transform target;
    [SerializeField] private NavMeshAgent agent;

    private void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        agent.destination = target.position;
    }
}