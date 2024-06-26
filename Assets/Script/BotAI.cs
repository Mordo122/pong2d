using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAI : MonoBehaviour
{
    public Transform ball;
    public Transform enemy;
    public float speed = 1f;
    private Vector2 destination;

    public void MoveToBall()
    {
        destination = new Vector2 (enemy.transform.position.x,ball.position.y);
        transform.position = Vector2.Lerp(enemy.transform.position,destination,speed * Time.deltaTime);
    }

    void Update()
    {
        StartCoroutine(AIDelay(2f)); 
        MoveToBall();
    }

    private IEnumerator AIDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        MoveToBall();
    }
}