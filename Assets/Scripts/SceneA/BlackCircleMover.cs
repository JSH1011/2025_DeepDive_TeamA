using UnityEngine;

public class BlackCircleMover : MonoBehaviour
{
    // 이것은 실험용


    [Header("원 슬롯들 (드래그로 넣거나, Auto Collect 사용)")]
    [SerializeField] private CircleSlot[] slots;

    [Header("시작 검정 위치(인덱스)")]
    [SerializeField] private int startBlackIndex = 0;

    [Header("자동 수집(자식에서 CircleSlot 찾아서 채움)")]
    [SerializeField] private bool autoCollectFromChildren = true;

    private int blackIndex;

    private void Awake()
    {
        if (autoCollectFromChildren || slots == null || slots.Length == 0)
            slots = GetComponentsInChildren<CircleSlot>(true);

        if (slots == null || slots.Length == 0)
        {
            Debug.LogError("CircleSlot이 없습니다.");
            enabled = false;
            return;
        }

        blackIndex = Mathf.Clamp(startBlackIndex, 0, slots.Length - 1);
        RefreshColors();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveNext();
        }
    }

    private void MoveNext()
    {
        blackIndex = (blackIndex + 1) % slots.Length; // 순환 이동
        RefreshColors();
    }

    private void RefreshColors()
    {
        for (int i = 0; i < slots.Length; i++)
            slots[i].SetBlack(i == blackIndex);
    }
}
