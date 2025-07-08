using UnityEngine;
using UnityEngine.UI;

public class SoundSet : MonoBehaviour
{
    public Scrollbar volumeSlider;

    void Start()
    {
        // �����̴� �� �ʱ�ȭ
        volumeSlider.value = AudioManager.Instance.audioSource.volume;


        // �����̴� ���� ����� �� ȣ��� �Լ� ����
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void SetVolume(float value)
    {
        AudioManager.Instance.audioSource.volume = value;
    }
}
