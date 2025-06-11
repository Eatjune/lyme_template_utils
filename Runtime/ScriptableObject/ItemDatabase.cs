using UnityEngine;

[CreateAssetMenu(menuName = "LymeGame/Resource/ItemDatabase", fileName = "ItemDatabase")]
public class ItemDatabase : ScriptableObject {
	public ItemData[] ItemData;

	/// <summary>
	/// 根据id获取sobjectData
	/// </summary>
	public ItemData GetItem(string id) {
		foreach (var itemData in ItemData) {
			if (itemData.Id == id) {
				return itemData;
			}
		}

		return null;
	}
}