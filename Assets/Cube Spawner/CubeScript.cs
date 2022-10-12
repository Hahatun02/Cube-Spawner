using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private float speed;
    private float distance;
    private float time; //Время существования куба

    public void SetParams(float speed, float distance)
    {
        this.speed = speed;
        this.distance = distance;

        time = distance / speed;
    }

    private void FixedUpdate()
    {
        time -= Time.deltaTime;

        if (time < 0)
            Destroy(gameObject);
        else
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
}
