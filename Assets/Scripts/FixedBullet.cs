using UnityEngine;

namespace TowerDefenseGame.Scripts
{
    public class FixedBullet : MonoBehaviour
    {
        private void Update()
        {
            Destroy(gameObject, 2.5f);
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            //TODO: big todo
            //collision.gameObject.GetComponent<Unit>().health -= LevelManager.instance.Damage;

            //if (collision.gameObject.GetComponent<Unit>().health < 1 && collision.gameObject.GetComponent<Unit>().Name == "Unit-Level1")
            //{
            //    LevelManager.instance.gold += 1;
            //}
            //if (collision.gameObject.GetComponent<Unit>().health < 1 && collision.gameObject.GetComponent<Unit>().Name == "Unit-Level2")
            //{
            //    LevelManager.instance.gold += 2;
            //}
            //if (collision.gameObject.GetComponent<Unit>().health < 1 && collision.gameObject.GetComponent<Unit>().Name == "Unit-Level3")
            //{
            //    LevelManager.instance.gold += 4;
            //}
            //if (collision.gameObject.GetComponent<Unit>().health < 1)
            //{
            //    Destroy(collision.gameObject);
            //}
            //Destroy(gameObject);
        }
    }
}