using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject randomCarNpc;
    bool can_spawn = true;

    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        while (can_spawn == true)
        {
            Instantiate(randomCarNpc, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
