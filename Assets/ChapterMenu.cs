using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterMenu : MonoBehaviour
{
    public Button[] ChapterButtons; // Buttons for chapters
    public Button[] VerseButtons;   // Buttons for verses, corresponding to chapters

    private void Awake()
    {
        int unlockedChapter = PlayerPrefs.GetInt("UnlockedChapter", 1);

        // Disable all chapter and verse buttons initially
        for (int i = 0; i < ChapterButtons.Length; i++)
        {
            ChapterButtons[i].enabled = false;
            ChapterButtons[i].interactable = false;
        }

        for (int i = 0; i < VerseButtons.Length; i++)
        {
            VerseButtons[i].enabled = false;
            VerseButtons[i].interactable = false;
        }

        // Enable and make interactable unlocked chapters and their verses
        for (int i = 0; i < unlockedChapter; i++)
        {
            ChapterButtons[i].enabled = true;
            ChapterButtons[i].interactable = true;

            VerseButtons[i].enabled = true;
            VerseButtons[i].interactable = true;
        }
    }
}