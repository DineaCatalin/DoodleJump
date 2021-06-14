using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] private List<Vector3> relativeWaypoints;
    [SerializeField] private IPlatformMovement _movement;

    private int currentWaypointIndex;

    private void Start()
    {
        for (int i = 0; i < relativeWaypoints.Count; i++)
        {
            relativeWaypoints[i] += transform.position;
        }
    }

    private void Update()
    {
        var currentWaypoint = relativeWaypoints[currentWaypointIndex];

        _movement.Move(transform, currentWaypoint, Time.deltaTime);

        if (Vector3.Distance(transform.position, currentWaypoint) < _movement.distanceDeltaChangeWaypoint)
        {
            currentWaypointIndex++;
            currentWaypointIndex = currentWaypointIndex % relativeWaypoints.Count;
        }
    }
}
