using UnityEngine;

namespace GravityBall
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private float gravity;
        private bool isGrounded = false;

        [SerializeField] private GameController gameController;

        void Start()
        {
            Physics2D.gravity = new Vector2(0, -gravity);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                Physics2D.gravity = -Physics2D.gravity;
                isGrounded = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.tag == "Ground")
            {
                isGrounded = true;
                gameController.ScoreChange();
            }
            else if (collision.transform.tag == "Obstacle") gameController.GameOver();
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            isGrounded = false;
        }
    }
}