using UnityEngine;
using UnityEngine.SceneManagement;
using NaughtyAttributes;

public class LoadScene : MonoBehaviour
{
    [SerializeField][Scene] string sceneToLoad;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
