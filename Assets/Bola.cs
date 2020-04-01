using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour
{
    public int speed = 30;
    // Start is called before the first frame update
    public Rigidbody2D sesuatu;
    void Start()
    {
        sesuatu.velocity = new Vector2(-1, -1) * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.name == "RightWall" || other.collider.name == "LeftWall")
        {
            StartCoroutine(hitungMundur());
            GetComponent<Transform>().position = new Vector2(0, 0);

        }
    }

    IEnumerator hitungMundur()
    {

        yield return new WaitForSeconds(1);

    }
}
