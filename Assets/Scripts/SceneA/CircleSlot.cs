using UnityEngine;

public class CircleSlot : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;

    private void Reset()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetBlack(bool isBlack)
    {
        if (sr == null) sr = GetComponent<SpriteRenderer>();
        sr.color = isBlack ? Color.black : Color.white;
    }
}
