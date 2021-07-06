using UnityEngine;

namespace GravityBall
{
    public class Ground : ObjectController
    {
        private void Update()
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;

            if (transform.position.x < -spawnPositionX + 1 - transform.localScale.x / 2)
            {
                transform.position = new Vector2(spawnPositionX, transform.position.y);
                transform.localScale = new Vector3(Random.Range(4, 6), 1, 1);
            }
        }
    }
}