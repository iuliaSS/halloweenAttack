using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject bulletPrefab;
    public float speed;
    public float time;
    private float nextActionTime;

    // Use this for initialization
    void Start () {
        speed *= -1;
        nextActionTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= nextActionTime)
        {
            nextActionTime += time;
			GameObject instanceBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
			instanceBullet.GetComponent<Rigidbody>().velocity = instanceBullet.transform.right * speed;
            Destroy(instanceBullet, 15);
        }
    }
}
