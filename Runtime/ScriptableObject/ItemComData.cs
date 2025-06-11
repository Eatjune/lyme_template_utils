using UnityEngine;

[CreateAssetMenu(menuName = "LymeGame/Resource/ItemComData", fileName = "ItemComData")]
public class ItemComData : ScriptableObject {
	[SerializeField]
	private string m_id;

	public string Id {
		get {
			if (!string.IsNullOrEmpty(m_id)) return m_id;
			return name;
		}
	}

	public string DescName;
	public string Description;

	protected ItemData m_itemData;

	/// <summary>
	/// 实例化该scriptableObject
	/// </summary>
	/// <param name="data">父data</param>
	public ItemComData GetInstance(ItemData data) {
		var obj = Instantiate(this);
		obj.name = this.name;
		obj.m_itemData = data;
		return obj;
	}
}