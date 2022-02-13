using UnityEngine;

public class PrologueManager : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        anim.SetBool("Fade", false);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}