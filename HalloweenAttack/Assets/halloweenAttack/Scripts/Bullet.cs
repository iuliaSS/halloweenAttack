using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Generare de proiectile
 * 
 */
public class Bullet : MonoBehaviour {

    /**
     * Tipul de proiectil
     */
    public GameObject bulletPrefab;

    /**
     * Viteza proiectulului
     */
    public float speed;

    /**
     * Timpul la care este lansat
     */
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
