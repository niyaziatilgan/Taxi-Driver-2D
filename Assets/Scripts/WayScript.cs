using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject way;
    bool wayBuild = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mainCar") && wayBuild == false)
        {
            Vector3 spawn_Location = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawn_Location, Quaternion.identity);
            wayBuild = true;
            ScoreManager.score += 10;
            Destroy(this.gameObject, 6f);
        }
    }

}
