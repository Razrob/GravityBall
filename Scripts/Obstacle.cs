using UnityEngine;

namespace GravityBall
{
    public class Obstacle : ObjectController
    {
        private void Update()
        {
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
            if (transform.position.x < -spawnPositionX) transform.position = new Vector2(spawnPositionX, transform.position.y);
        }
    }
}