using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OptionsPanel : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] Toggle muteToggle;
    [SerializeField] Slider bgmSlider;
    [SerializeField] TMP_Text bgmVolText;

    private void OnEnable()
    {
        muteToggle.isOn = audioManager.IsMute;
        bgmSlider.value = audioManager.BgmVolume;
        SetBgmVolText(bgmSlider.value);
    }

    public void SetBgmVolText(float value)
    {
        bgmVolText.text = Mathf.RoundToInt(bgmSlider.value  * 100).ToString();
    }
}
