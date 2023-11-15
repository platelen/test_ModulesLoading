using UnityEngine;

namespace ProjectConfigSo
{
    [CreateAssetMenu(fileName = "ProjectConfiguration", menuName = "Custom/Project Configuration", order = 1)]
    public class ProjectConfiguration : ScriptableObject
    {
        [SerializeField] private string _environment;
        [SerializeField] private string _scenario;
        [SerializeField] private string[] _otherSettings;

        public string Environment => _environment;

        public string Scenario => _scenario;

        public string[] OtherSettings => _otherSettings;
    }
}