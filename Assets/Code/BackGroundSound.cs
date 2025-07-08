using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BackGroundSound : MonoBehaviour
{
    public Scrollbar volumeSlider;

    void Start()
    {
        // �����̴� �� �ʱ�ȭ
        volumeSlider.value = AudioManager.Instance.backGround.volume;


        // �����̴� ���� ����� �� ȣ��� �Լ� ����
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void SetVolume(float value)
    {
        AudioManager.Instance.backGround.volume = value;
    }
}
