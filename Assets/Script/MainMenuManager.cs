using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Animator anim;
    public Image image;

    public void StartGame()
    {
        StartCoroutine(Fading());
    }

    private IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => image.color.a == 1);
        Application.LoadLevel("SampleScene");
    }
}