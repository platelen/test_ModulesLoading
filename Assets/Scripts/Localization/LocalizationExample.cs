using System;
using TMPro;
using UnityEngine;

namespace Localization
{
    public class LocalizationExample : MonoBehaviour
    {
        public LocalizationManager localizationManager;

        private TextMeshProUGUI _textMesh;

        private void Awake()
        {
            _textMesh = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            // Загружаем локализацию для текущего языка (например, при старте игры)
            localizationManager.LoadLocalizedText("eng");
        }

        // Ваш код для смены языка в игре
        public void ChangeLanguageToKz()
        {
            localizationManager.LoadLocalizedText("kz");
        }

        public void ChangeLanguageToEng()
        {
            localizationManager.LoadLocalizedText("eng");
        }

        public void ChangeLanguageToRus()
        {
            localizationManager.LoadLocalizedText("rus");
        }
    }
}