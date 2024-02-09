using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerFallOver : MonoBehaviour
{
    [SerializeField]
    public CircleCollider2D Collider1;

    int score;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider == Collider1)
        {
            Debug.Log(Collider1);
        }
            if (other.collider == Collider1)
        {
            score = GameObject.Find("Finish").GetComponent<FinishScript>().score ;
            Debug.Log("HeadHitFloor");
            Debug.Log("Level Completed, Your Score was:" + score + "!! Better Luck Next Time");
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }
}
