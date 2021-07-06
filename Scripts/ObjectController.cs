using UnityEngine;

namespace GravityBall
{
    public class ObjectController : MonoBehaviour
    {
        protected GameController gameController;
        protected float spawnPositionX;
        protected int moveSpeed;

        private void Awake()
        {
            gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            spawnPositionX = gameController.objectSpawnXPosition;
            moveSpeed = gameController.objectsMoveSpeed;
        }
    }
}