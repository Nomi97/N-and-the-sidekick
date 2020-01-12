using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Transform player;
    public float speed;
    public float maxBoundX, minBoundX;
    public float maxBoundY, minBoundY;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    // Start is called before the first frame update
    void Start () {
        player = GetComponent<Transform> ();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate () {
        float h = Input.GetAxis ("Mouse X");
        float v = Input.GetAxis ("Mouse Y");

        if (player.position.x < minBoundX && h < 0) {
            h = 0;
        } else if (player.position.x > maxBoundX && h > 0) {
            h = 0;
        }

        if (player.position.y < minBoundY && v < 0) {
            v = 0;
        } else if (player.position.y > maxBoundY && v > 0) {
            v = 0;
        }

        player.position += Vector3.right * h * speed;
        player.position += Vector3.up * v * speed;

    }

    void Update() {
          if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
              nextFire = Time.time + fireRate;
              Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}