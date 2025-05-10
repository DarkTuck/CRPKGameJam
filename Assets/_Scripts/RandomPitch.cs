using UnityEngine;
using NaughtyAttributes;
using System.Threading.Tasks;

public class RandomPitch : MonoBehaviour
{
    [SerializeField][BoxGroup("Settings")][MinMaxSlider(-3,3)]Vector2 minMaxValue;
    [SerializeField][BoxGroup("Settings")][ValidateInput("IsGreaterThanZero","Interval must be greater than zero")]float interval;
    [SerializeField][Required]AudioSource audioSource;
    bool shouldPlay = true;
    private bool IsGreaterThanZero(float value)
    {
        return value > 0;
    }

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
            audioSource.pitch = Random.Range(minMaxValue.x, minMaxValue.y);
            await Task.Delay(Mathf.RoundToInt(interval*1000));
        }
    }
}
