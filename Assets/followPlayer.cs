using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    public float distanceTokill=5f;

    private void LateUpdate()
    {
        if (target.position.y-distanceTokill > transform.position.y)
        {
            Vector3 newPosition = new Vector3(target.position.x, target.position.y-distanceTokill, transform.position.z);
            transform.position = newPosition;
        }
    }
}
