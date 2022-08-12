using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Flag")
        {
            PlayerManager.isLevelCompleted = true;
            gameObject.SetActive(false);
        }
    }
}
