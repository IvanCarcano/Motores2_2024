using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float time = 3;
    private float variantTime = 0;
    void Update()
    {
        if (variantTime < time)
        {
            variantTime += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
