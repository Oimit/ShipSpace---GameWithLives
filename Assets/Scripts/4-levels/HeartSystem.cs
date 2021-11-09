using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    [SerializeField]
    GameObject[] lives;
    [SerializeField]
    private int life;
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            life--;
            Debug.Log("life down" + life);
            numOfLives();
            
        }
    }

    public void numOfLives()
    {
        if (life < 1)
        {
            ToggleVisibility(lives[0].gameObject);
            Debug.Log("Game over!");
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
        else if (life < 2)
        {
            ToggleVisibility(lives[1].gameObject);
        }
        else if (life < 3)
        {
            ToggleVisibility(lives[2].gameObject);
        }
    }

    public void ToggleVisibility(GameObject g)
    {
        Renderer rend = g.GetComponent<Renderer>();
        if (rend.enabled)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
        }
    }

    public void addLife ()
    {
        if (life < 3)
        {
            life++;
            numOfLives();
        }
    }

    void Update()
    {

    }
}
