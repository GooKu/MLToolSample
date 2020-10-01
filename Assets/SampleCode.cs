using UnityEngine;
using UnityEngine.UI;
using MLTool;

public class SampleCode : MonoBehaviour
{
    [SerializeField]
    private TextAsset lines = null;
    [SerializeField]
    private Text sampleText = null;

    private void Start()
    {
        var languageKey = Application.systemLanguage == SystemLanguage.ChineseTraditional ? "zh-tw" : "en";
        WordDic.Init(languageKey, lines.text);
        sampleText.MutliText("test1");
    }

    public void OnDropDownChange(int value)
    {
        var languageKey = value == 0 ? "zh-tw" : "en";
        WordDic.Init(languageKey, lines.text);
        sampleText.MutliText("test1");
    }
}
