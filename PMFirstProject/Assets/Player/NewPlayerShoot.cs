using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerShoot : MonoBehaviour
{

    public GameObject prefab;
    public float Bulletspeed = 5.0f;
    public float bulletLifetime = 2.0f;

    // Update is called once per frame
    void Update()
    {
        //when the mouse is clicked
        if (Input.GetButton("Fire1"))
        {
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * Bulletspeed;
            Destroy(bullet, bulletLifetime);
        }
    }
}