using UnityEngine;

[CreateAssetMenu(menuName = "LymeGame/SOData/SOTemplateDatabase", fileName = "SOTemplateDatabase")]
public class SOTemplateDatabase : ScriptableObject {
	public SOTemplateData[] ItemData;

	/// <summary>
	/// 根据id获取SObjectData
	/// </summary>
	public SOTemplateData GetItem(string id) {
		foreach (var itemData in ItemData) {
			if (itemData.Id == id) {
				return itemData;
			}
		}

		return null;
	}
}