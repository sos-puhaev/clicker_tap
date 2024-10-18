using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TapAnimation : MonoBehaviour
{
    private Vector3 defaultScale;
    public float pressScale = 0.9f;
    public float animationDuration = 0.1f;

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        defaultScale = transform.localScale;
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        StartCoroutine(AnimateButton());
    }

    IEnumerator AnimateButton()
    {
        yield return StartCoroutine(ScaleTo(new Vector3(pressScale, pressScale, pressScale), animationDuration));

        yield return StartCoroutine(ScaleTo(defaultScale, animationDuration));
    }

    IEnumerator ScaleTo(Vector3 targetScale, float duration)
    {
        Vector3 startScale = transform.localScale;
        float time = 0;

        while (time < duration)
        {
            transform.localScale = Vector3.Lerp(startScale, targetScale, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.localScale = targetScale;
    }
}