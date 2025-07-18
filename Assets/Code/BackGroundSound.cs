using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BackGroundSound : MonoBehaviour
{
    public Scrollbar volumeSlider;

    void Start()
    {
        // 슬라이더 값 초기화
        volumeSlider.value = AudioManager.Instance.backGround.volume;


        // 슬라이더 값이 변경될 때 호출될 함수 연결
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void SetVolume(float value)
    {
        AudioManager.Instance.backGround.volume = value;
    }
}
