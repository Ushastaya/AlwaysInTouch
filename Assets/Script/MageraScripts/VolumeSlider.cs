using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    public AudioSource audioSource;    

    void Start()
    {
        volumeSlider.value = GlobalVolumeManager.instance.globalVolume; // ��������� ���������� �������� ��������
        audioSource.volume = GlobalVolumeManager.instance.globalVolume; // ��������� ��������� ��������� �����

        volumeSlider.onValueChanged.AddListener(delegate { OnVolumeSliderValueChanged(); }); // ���������� ��������� ������� ��������� �������� ��������
    }

    void OnVolumeSliderValueChanged()
    {
        float volume = volumeSlider.value;
        audioSource.volume = volume; // ��������� ��������� �����
        GlobalVolumeManager.instance.globalVolume = volume; // ���������� ���������� ���������
    }
}
