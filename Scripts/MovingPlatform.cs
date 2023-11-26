using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] GameObject[] wayPoints;
    int currentIndex = 0;
    [SerializeField] float speed = 10f;

    void Update()
    {
        if(Vector3.Distance(transform.position, wayPoints[currentIndex].transform.position) < 0.1f){
            currentIndex++;
            if(currentIndex >= wayPoints.Length){
                currentIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentIndex].transform.position, speed*Time.deltaTime);
    }
}
