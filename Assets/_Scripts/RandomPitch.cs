using UnityEngine;
using NaughtyAttributes;
using System.Threading.Tasks;

public class RandomPitch : MonoBehaviour
{
    [SerializeField][BoxGroup("Settings")]float minValue, maxValue;
    [SerializeField][BoxGroup("Settings")]float interval;
    [SerializeField]AudioSource audioSource;
    bool shouldPlay = true;

    void OnEnable()
    {
        shouldPlay = true;
        _ = RandomizePitch();
    }

    void OnDisable()
    {
        shouldPlay = false;
    }

    async Task RandomizePitch()
    {
        while (shouldPlay)
        {
            audioSource.pitch = Random.Range(minValue, maxValue);
            await Task.Delay(Mathf.RoundToInt(interval*1000));
        }
    }
}
