using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dart : MonoBehaviour
{

    [SerializeField] float _launchSpeed = 1;

    public void Fire()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * _launchSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Dart>() != null)
        {
            SceneManager.LoadScene(0);
        }
        
        transform.SetParent(collision.transform);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;

        if (collision.gameObject.GetComponent<Dart>() == null)
        {
            var scoreCounter = FindObjectOfType<ScoreCounter>();
            scoreCounter.AddPoint();
        }
    }

}
