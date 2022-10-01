using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField] HealthPlayer HealthDisplay;
    [SerializeField] int Health = 3;
    
    private void Awake()
    {
        var numGameManager = FindObjectsOfType<GameManager>().Length;

        if (numGameManager > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            HealthDisplay.HealthShow(Health);
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ProcessPlayerDeath()
    {
        Health--;
        HealthDisplay.HealthShow(Health);
        if (Health == 0)
        {
            LoadMainMenu();
        }
        else 
        {
            LoadLevel(GetCurrentBuildIndex());
        }
    }

    public void LoadMainMenu()
    {
        LoadLevel(0);
        Destroy(gameObject);
    }

    public void LoadLevel(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);
        DOTween.KillAll();
    }

    public void LoadNextLevel()
    {
        var nextSceneIndex = GetCurrentBuildIndex() + 1;
        
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        LoadLevel(nextSceneIndex);
        DOTween.KillAll();
    }

    private int GetCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
