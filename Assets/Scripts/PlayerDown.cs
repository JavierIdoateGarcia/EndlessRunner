using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDown : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;

    public GameManager gameManager;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("down"))
        {
            stand.SetActive(true);
            crouch.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            gameManager.GameOver();
        }
    }
}