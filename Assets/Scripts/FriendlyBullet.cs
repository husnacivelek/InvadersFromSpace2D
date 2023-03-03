using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyBullet : MonoBehaviour
{
    private float speed = 10f;
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed); 
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Alien"))
        {
            other.gameObject.GetComponent<Alien>().Kill();
            gameObject.SetActive(false);
        }

        if(other.gameObject.CompareTag("EnemyBullet"))
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
