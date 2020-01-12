using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {
    private Transform monster;
    public float life;
    public float speed;
    public float maxBoundX, minBoundX;

    // Start is called before the first frame update
    void Start () {
        monster = GetComponent<Transform> ();
    }

    // Update is called once per frame
    void Update () {
            if (monster.position.x <= maxBoundX && monster.position.x > minBoundX) {
            monster.position += Vector3.right * speed;
        } else if (monster.position.x >= minBoundX && monster.position ) {
            monster.position += Vector3.right * -speed;
        }
    }
}