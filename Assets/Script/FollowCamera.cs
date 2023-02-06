using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform animal_people_wolf_1_SimpleMovement;
    public Vector3 offset;
    void Update()
    {
        transform.position = animal_people_wolf_1_SimpleMovement.position + offset;
    }
}
