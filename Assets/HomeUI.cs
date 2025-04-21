using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace NultBolts
{
	using System;

	public class HomeUI : MonoBehaviour
	{
		[SerializeField] private GameObject previousLevel;

		[SerializeField] private TextMeshProUGUI txtPrevious;
		[SerializeField] private TextMeshProUGUI txtCurrent;
		[SerializeField] private TextMeshProUGUI txtNext;

		private int currentLevel=1;
		private int maxLevel    =10; // Giả sử có 10 level

		private void Start()
		{
			gameObject.SetActive(true);
			UpdateLevelDisplay();
		}

		void OnEnable()
		{
			UpdateLevelDisplay();
		}

		private void UpdateLevelDisplay()
		{
			currentLevel=DataManager.indexLevel_NB+1;

			// Cập nhật text hiển thị level
			txtPrevious.text=(currentLevel-1).ToString();
			txtCurrent.text =currentLevel.ToString();
			txtNext.text    =(currentLevel+1).ToString();

			// Disable/enable buttons
			previousLevel.SetActive(currentLevel>1);
		}
		

		public void ResetGame() { NultBoltsManager.Instance.ReloadLevel(); }

	}
}
