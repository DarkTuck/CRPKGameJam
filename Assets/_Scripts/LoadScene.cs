using UnityEngine;
using UnityEngine.SceneManagement;
using NaughtyAttributes;

public class LoadScene : MonoBehaviour
{
    public static LoadScene Instance {get; private set;}
    [SerializeField][Scene] string sceneToLoad;

    private void Awake()
    {
        Instance = this;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
