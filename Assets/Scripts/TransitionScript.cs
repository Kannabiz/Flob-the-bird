using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    [SerializeField] RectTransform fader;

    void Start()
    {
        fader.gameObject.SetActive(true);

        LeanTween.alpha(fader, 1, 0.4f);
        LeanTween.alpha(fader, 0, 0.4f).setOnComplete(() =>
        {
            fader.gameObject.SetActive(false);
        });

    }

    public void nextScene(int i)
    {
        fader.gameObject.SetActive(true);

        LeanTween.alpha(fader, 0, 0.4f);
        LeanTween.alpha(fader, 1, 0.4f).setOnComplete(() =>
        {
            SceneManager.LoadScene(i);

        });
    }

    public void endScreen(int i)
    {
        fader.gameObject.SetActive(true);

        LeanTween.alpha(fader, 0, 0.6f);
        LeanTween.alpha(fader, 1, 0.7f).setOnComplete(() =>
        {
            SceneManager.LoadScene(i);

        });
    }
}
