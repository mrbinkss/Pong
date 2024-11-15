using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int score = 0;
    public int winningScore = 5;

    private void Awake()
    {
        //Persist
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        this.score = 0;
    }

    private void LoadLevel(int level)
    {
        this.level = level;
        SceneManager.LoadScene(level);
    }
}
