using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Localization
{
    public class LocalizationManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _localizedText;

        public void LoadLocalizedText(string language)
        {
            string address = GetAddressForLanguage(language);

            AsyncOperationHandle<TextAsset> handle = Addressables.LoadAssetAsync<TextAsset>(address);
            handle.Completed += OnLoadCompleted;
        }

        private void OnLoadCompleted(AsyncOperationHandle<TextAsset> handle)
        {
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                _localizedText.text = handle.Result.ToString();
            }
            else
            {
                Debug.LogError("Failed to load localized text.");
            }

            Addressables.Release(handle);
        }

        private string GetAddressForLanguage(string language)
        {
            switch (language.ToLower())
            {
                case "kz":
                    return "KzGroup";
                case "eng":
                    return "EngGroup";
                case "rus":
                    return "RusGroup";
                default:
                    return "RusGroup";
            }
        }
    }
}