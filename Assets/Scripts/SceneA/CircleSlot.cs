using UnityEngine;

public class CircleSlot : MonoBehaviour
{
    // 이것은 실험용2

    [SerializeField] private SpriteRenderer spriterender;

    private void Reset()
    {
        spriterender = GetComponent<SpriteRenderer>();
    }

    public void SetBlack(bool isBlack)
    {
        if (spriterender == null) spriterender = GetComponent<SpriteRenderer>();
        spriterender.color = isBlack ? Color.black : Color.white;
    }
}
